
namespace TestForm
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ASCIIEncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF7EncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF8EncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF32EncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnicodeEncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BigUnicodeEncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.rowColStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.encodingStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.formatMenuItem,
            this.viewMenuItem,
            this.infoMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMenuItem,
            this.newWindowMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.fileItemSeparator1,
            this.fileItemSeparator2,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileMenuItem.Text = "Файл";
            // 
            // createMenuItem
            // 
            this.createMenuItem.Name = "createMenuItem";
            this.createMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createMenuItem.Size = new System.Drawing.Size(309, 26);
            this.createMenuItem.Text = "Создать";
            this.createMenuItem.Click += new System.EventHandler(this.Create);
            // 
            // newWindowMenuItem
            // 
            this.newWindowMenuItem.Name = "newWindowMenuItem";
            this.newWindowMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowMenuItem.Size = new System.Drawing.Size(309, 26);
            this.newWindowMenuItem.Text = "Новое окно";
            this.newWindowMenuItem.Click += new System.EventHandler(this.OpenAgain);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(309, 26);
            this.openMenuItem.Text = "Открыть...";
            this.openMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(309, 26);
            this.saveMenuItem.Text = "Сохранить";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(309, 26);
            this.saveAsMenuItem.Text = "Сохранить как...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // fileItemSeparator1
            // 
            this.fileItemSeparator1.Name = "fileItemSeparator1";
            this.fileItemSeparator1.Size = new System.Drawing.Size(306, 6);
            // 
            // fileItemSeparator2
            // 
            this.fileItemSeparator2.Name = "fileItemSeparator2";
            this.fileItemSeparator2.Size = new System.Drawing.Size(306, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeyDisplayString = "ALT+F4";
            this.exitMenuItem.Size = new System.Drawing.Size(309, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.EditSeparator1,
            this.CutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.deleteMenuItem,
            this.EditSeparator2,
            this.findMenuItem,
            this.replaceMenuItem,
            this.shiftMenuItem,
            this.EditSeparator3,
            this.selectAllMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(74, 24);
            this.editMenuItem.Text = "Правка";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(248, 26);
            this.undoMenuItem.Text = "Отменить";
            this.undoMenuItem.Click += new System.EventHandler(this.Undo);
            // 
            // EditSeparator1
            // 
            this.EditSeparator1.Name = "EditSeparator1";
            this.EditSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutMenuItem.Size = new System.Drawing.Size(248, 26);
            this.CutMenuItem.Text = "Вырезать";
            this.CutMenuItem.Click += new System.EventHandler(this.Cut);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(248, 26);
            this.copyMenuItem.Text = "Копировать";
            this.copyMenuItem.Click += new System.EventHandler(this.Copy);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(248, 26);
            this.pasteMenuItem.Text = "Вставить";
            this.pasteMenuItem.Click += new System.EventHandler(this.Paste);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMenuItem.Size = new System.Drawing.Size(248, 26);
            this.deleteMenuItem.Text = "Удалить";
            this.deleteMenuItem.Click += new System.EventHandler(this.Delete);
            // 
            // EditSeparator2
            // 
            this.EditSeparator2.Name = "EditSeparator2";
            this.EditSeparator2.Size = new System.Drawing.Size(245, 6);
            // 
            // findMenuItem
            // 
            this.findMenuItem.Name = "findMenuItem";
            this.findMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findMenuItem.Size = new System.Drawing.Size(248, 26);
            this.findMenuItem.Text = "Найти...";
            this.findMenuItem.Click += new System.EventHandler(this.OpenFinder);
            // 
            // replaceMenuItem
            // 
            this.replaceMenuItem.Name = "replaceMenuItem";
            this.replaceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceMenuItem.Size = new System.Drawing.Size(248, 26);
            this.replaceMenuItem.Text = "Заменить...";
            this.replaceMenuItem.Click += new System.EventHandler(this.OpenReplacer);
            // 
            // shiftMenuItem
            // 
            this.shiftMenuItem.Name = "shiftMenuItem";
            this.shiftMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.shiftMenuItem.Size = new System.Drawing.Size(248, 26);
            this.shiftMenuItem.Text = "Перейти...";
            this.shiftMenuItem.Click += new System.EventHandler(this.OpenShifter);
            // 
            // EditSeparator3
            // 
            this.EditSeparator3.Name = "EditSeparator3";
            this.EditSeparator3.Size = new System.Drawing.Size(245, 6);
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenuItem.Size = new System.Drawing.Size(248, 26);
            this.selectAllMenuItem.Text = "Выделить всё";
            this.selectAllMenuItem.Click += new System.EventHandler(this.SelectAll);
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontMenuItem,
            this.colorMenuItem});
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(77, 24);
            this.formatMenuItem.Text = "Формат";
            // 
            // FontMenuItem
            // 
            this.FontMenuItem.Name = "FontMenuItem";
            this.FontMenuItem.Size = new System.Drawing.Size(224, 26);
            this.FontMenuItem.Text = "Шрифт...";
            this.FontMenuItem.Click += new System.EventHandler(this.ChangeFont);
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.Name = "colorMenuItem";
            this.colorMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorMenuItem.Text = "Цвет...";
            this.colorMenuItem.Click += new System.EventHandler(this.ChangeColor);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // infoMenuItem
            // 
            this.infoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.infoMenuItem.Name = "infoMenuItem";
            this.infoMenuItem.Size = new System.Drawing.Size(81, 24);
            this.infoMenuItem.Text = "Справка";
            // 
            // statusStripMenuItem
            // 
            this.statusStripMenuItem.Name = "statusStripMenuItem";
            this.statusStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip.TabIndex = 10;
            // 
            // rowColStatusLabel
            // 
            this.rowColStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.rowColStatusLabel.Name = "rowColStatusLabel";
            this.rowColStatusLabel.Size = new System.Drawing.Size(115, 17);
            this.rowColStatusLabel.Text = "Строка:1, столбец:1";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 24);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(1067, 508);
            this.textBox.TabIndex = 9;
            this.textBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.textBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileItemSeparator1;
        private System.Windows.Forms.ToolStripSeparator fileItemSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripSeparator EditSeparator1;
        private System.Windows.Forms.ToolStripSeparator EditSeparator2;
        private System.Windows.Forms.ToolStripSeparator EditSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel rowColStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel encodingStatus;
        private System.Windows.Forms.ToolStripMenuItem ASCIIEncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTF7EncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTF8EncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTF32EncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnicodeEncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BigUnicodeEncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

