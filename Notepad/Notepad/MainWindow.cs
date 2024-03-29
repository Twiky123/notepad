﻿using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using Notepad;
using System.Text;

namespace TestForm
{
    public partial class MainWindow : Form
    {

        /// <summary>
        /// Текущий тип кодирования
        /// </summary>

        /// <summary>
        ///  Объект формы замены. Только одна такая может быть запущена в одно время.
        /// </summary>
        private ReplaceForm replacer;

        /// <summary>
        ///  Объект формы поиска. Только одна такая может быть запущена в одно время.
        /// </summary>
        private FindForm finder;

        /// <summary>
        ///  Объект формы перехода. Только одна такая может быть запущена в одно время.
        /// </summary>
        private ShiftForm shifter;

        /// <summary>
        /// Игнорировать изменения в текстовом поле
        /// </summary>
        private bool ignoreTextChanges;

        /// <summary>
        /// Поле для свойства 'path' (Не использовать)
        /// </summary>
        private string _path;

        /// <summary>
        /// Путь до открытого документа
        /// </summary> 
        private string path
        {
            get => _path;
            set
            {
                _path = value;
                fileName = _path.Substring(path.LastIndexOf('\\') + 1);
                Text = $"Блокнот - {fileName}";
            }
        }

        /// <summary>
        /// Статус: Сохранено/Не сохранено
        /// </summary>
        private bool status;

        /// <summary>
        /// Имя открытого документа
        /// </summary>
        private string fileName;

        /// <summary>
        /// Конструктор без загрузки
        /// </summary>
        public MainWindow()
        {
            _path = string.Empty;
            fileName = "Безымянный.txt";
            InitializeComponent();
            Text = $"Блокнот - {fileName}";
        }

        /// <summary>
        /// Конструктор для открытия файлов извне (через args)
        /// </summary>
        /// <param name="path">Путь к файлу для открытия</param>
        public MainWindow(string path)
        {
            status = true;
            InitializeComponent();
            this.path = path;
        }

        #region Вспомогательные методы

        /// <summary>
        /// Метод проверки сохранения и запроса пользователю
        /// </summary>
        /// <returns>true - действие подтверждено; false - дейтвие отклонено</returns>
        private bool CheckSave()
        {
            if (!status)
            {
                if (File.Exists(path))
                {
                    DialogResult result = SaveDialog.ShowDialog(fileName);
                    if (result == DialogResult.Yes)
                    {
                        SaveFile(this,null);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
                else
                {
                    if (!textBox.Text.Equals(string.Empty))
                    {
                        DialogResult result = SaveDialog.ShowDialog(fileName);
                        if (result == DialogResult.Yes)
                        {
                            SaveFileAs(this, null);
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// TEST
        /// Обработка события отрисовки страницы для печати на принтере
        /// </summary>
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox.Text, textBox.Font, new SolidBrush(textBox.ForeColor), 10, 10);
        }

        /// <summary>
        /// Преобразует текущую позицию курсора в строку и столбец
        /// </summary>
        private string GetCurrentPosition()
        {
            Point pt;
            int line, col, index;
            index = textBox.SelectionStart;
            line = textBox.GetLineFromCharIndex(index);
            pt = textBox.GetPositionFromCharIndex(index);
            pt.X = 0;
            col = index - textBox.GetCharIndexFromPosition(pt);
            return $"Строка {++line}, столбец {++col}";
        }

        #endregion

        #region Файл

        /// <summary>
        /// Обработка события нажатия Файл->Выход
        /// </summary>
        private void ExitApplication(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                Close();
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Сохранить
        /// </summary>
        private void SaveFile(object sender, EventArgs e)
        {
            bool exists = File.Exists(path);
            if (exists && !status)
            {
                try
                {
                    File.WriteAllText(path, textBox.Text);
                    status = true;
                }
                catch (Exception exception)
                {
                    DialogResult result = MessageBox.Show(this,"Ошибка сохранения", $"{exception.Message}]\nХотите сохранить файл '{fileName}' в папке 'Документы'?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/{fileName}", textBox.Text);
                    }
                }
            }
            else if (!exists)
            {
                SaveFileAs(sender,e);
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Сохранить как
        /// </summary>
        private void SaveFileAs(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveDialog.Title = "Сохранение файла";
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveDialog.FileName, textBox.Text);
                    path = saveDialog.FileName;
                    status = true;
                }
                catch (Exception exception)
                {
                    DialogResult result = MessageBox.Show(this, $"{exception.Message}]\nХотите сохранить файл '{fileName}' в папке 'Документы'?", "Ошибка сохранения", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/{fileName}";
                        File.WriteAllText(path, textBox.Text);
                        status = true;
                    }
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Новое окно
        /// </summary>
        private void OpenAgain(object sender, EventArgs e) => Process.Start(Application.ExecutablePath);

        /// <summary>
        /// Обработка события нажатия Файл->Открыть
        /// </summary>
        private void OpenFile(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openDialog.Title = "Открытие файла";
                openDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ignoreTextChanges = true;
                        string readString = File.ReadAllText(openDialog.FileName);
                        if (textBox.MaxLength > readString.Length)
                        {
                            textBox.MaxLength = readString.Length;
                        }
                        textBox.Text = readString;
                        ignoreTextChanges = false;
                        path = openDialog.FileName;
                        status = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(this, exception.Message, "Ошибка чтения");
                    }
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Создать
        /// </summary>
        private void Create(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                _path = ""; //Задаю вручную, чтобы не затрагивать fileName
                fileName = "Безымянный.txt";
                Text = $"Блокнот - {fileName}";
                ignoreTextChanges = true;
                textBox.Text = "";
                ignoreTextChanges = false;
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Печать
        /// </summary>
        private void Print(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = document;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        #endregion

        #region Правка

        /// <summary>
        /// Обработка события нажатия Правка->Отменить
        /// </summary>
        private void Undo(object sender, EventArgs e) => textBox.Undo();

        /// <summary>
        /// Обработка события нажатия Правка->Вырезать
        /// </summary>
        private void Cut(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.Cut();
            }
        }

        /// <summary>
        /// Обработка события нажатия Правка->Копировать
        /// </summary>
        private void Copy(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.Copy();
            }
        }

        /// <summary>
        /// Обработка события нажатия Правка->Вставить
        /// </summary>
        private void Paste(object sender, EventArgs e)
        {
            textBox.Paste(Clipboard.GetText());
        }

        /// <summary>
        /// Обработка события нажатия Правка->Вставить
        /// </summary>
        private void Delete(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.SelectionStart,textBox.SelectionLength);
            }
        }

        /// <summary>
        /// Обработка события нажатия Правка->Поиск в Интернете
        /// </summary>
        private void Search(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                Process.Start($"https://www.google.com/search?q={textBox.SelectedText}");
            }
        }

        /// <summary>
        /// Обработка события нажатия Правка->Выделить всё
        /// </summary>
        private void SelectAll(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        /// <summary>
        /// Обработка события нажатия Правка->Дата и время
        /// </summary>
        private void PasteCurrentDateTime(object sender, EventArgs e)
        {
            textBox.Text += DateTime.Now.ToString("HH:mm dd.MM.yyyy");
        }

        /// <summary>
        /// Обработка события нажатия Правка->Заменить
        /// </summary>
        private void OpenReplacer(object sender, EventArgs e)
        {
            if (replacer == null)
            {
                replacer = new ReplaceForm(textBox);
                replacer.FormClosed += OnReplacerClosed;
                replacer.Show();
            }
            else
            {
                replacer.Focus();
            }
        }

        /// <summary>
        /// Обработка события закрытия формы 'Заменить'
        /// </summary>
        private void OnReplacerClosed(object sender, EventArgs e)
        {
            replacer = null;
        }

        /// <summary>
        /// Обработка события нажатия Правка->Найти
        /// </summary>
        private void OpenFinder(object sender, EventArgs e)
        {
            if (replacer == null)
            {
                finder = new FindForm(textBox);
                finder.FormClosed += OnFinderClosed;
                finder.Show();
            }
            else
            {
                finder.Focus();
            }
        }

        /// <summary>
        /// Обработка события закрытия формы 'Найти'
        /// </summary>
        private void OnFinderClosed(object sender, EventArgs e)
        {
            finder = null;
        }

        /// <summary>
        /// Обработка события нажатия Правка->Перейти
        /// </summary>
        private void OpenShifter(object sender, EventArgs e)
        {
            if (shifter == null)
            {
                shifter = new ShiftForm(textBox);
                shifter.FormClosed += OnShifterClosed;
                shifter.Show();
            }
            else
            {
                shifter.Focus();
            }
        }

        /// <summary>
        /// Обработка события закрытия формы 'Переход'
        /// </summary>
        private void OnShifterClosed(object sender, EventArgs e)
        {
            shifter = null;
        }
        #endregion

        #region Формат

        /// <summary>
        /// Обработка события нажатия Формат->Перенос по словам
        /// </summary>
        private void ChangeWordWrap(object sender, EventArgs e)
        {
            textBox.WordWrap = !textBox.WordWrap;
        }

        /// <summary>
        /// Обработка события нажатия Формат->Шрифт...
        /// </summary>
        private void ChangeFont(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = textBox.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog.Font;
            }
        }

        /// <summary>
        /// Обработка события нажатия Формат->Цвет...
        /// </summary>
        private void ChangeColor(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = textBox.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog.Color;
            }
        }

        #endregion


        /// <summary>
        /// Обработка события обновления текста в TextBox
        /// </summary>
        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanges)
            {
                if (!Text.StartsWith("*"))
                {
                }
                status = false;
            }
        }

        /// <summary>
        /// Обработка события pакрытия окна формы
        /// </summary>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CheckSave())
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Обработка события отпуская кнопки мыши
        /// Для обновления статуса
        /// </summary>
        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            rowColStatusLabel.Text = GetCurrentPosition();
        }

        /// <summary>
        /// Обработка события отпуская кнопки клавиатуры
        /// Для обновления статуса
        /// </summary>
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            rowColStatusLabel.Text = GetCurrentPosition();
        }
    }
}
