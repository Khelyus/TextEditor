namespace NewNoteBlock
{
    partial class MainForm
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
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиДалееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиРанееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGoOver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLab1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharSpaceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.notebox = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.фонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фиолетовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.mFormat,
            this.mView,
            this.mHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(832, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCreateFile,
            this.MenuNewWindow,
            this.MenuOpenFile,
            this.MenuSaveFile,
            this.MenuSaveAsFile,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.MenuExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(59, 24);
            this.mFile.Text = "Файл";
            // 
            // MenuCreateFile
            // 
            this.MenuCreateFile.Name = "MenuCreateFile";
            this.MenuCreateFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuCreateFile.Size = new System.Drawing.Size(295, 26);
            this.MenuCreateFile.Text = "Создать";
            this.MenuCreateFile.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // MenuNewWindow
            // 
            this.MenuNewWindow.Name = "MenuNewWindow";
            this.MenuNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.MenuNewWindow.Size = new System.Drawing.Size(295, 26);
            this.MenuNewWindow.Text = "Новое окно";
            this.MenuNewWindow.Click += new System.EventHandler(this.новоеОкноToolStripMenuItem_Click);
            // 
            // MenuOpenFile
            // 
            this.MenuOpenFile.Name = "MenuOpenFile";
            this.MenuOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpenFile.Size = new System.Drawing.Size(295, 26);
            this.MenuOpenFile.Text = "Открыть...";
            this.MenuOpenFile.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // MenuSaveFile
            // 
            this.MenuSaveFile.Name = "MenuSaveFile";
            this.MenuSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSaveFile.Size = new System.Drawing.Size(295, 26);
            this.MenuSaveFile.Text = "Сохранить";
            this.MenuSaveFile.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // MenuSaveAsFile
            // 
            this.MenuSaveAsFile.Name = "MenuSaveAsFile";
            this.MenuSaveAsFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.MenuSaveAsFile.Size = new System.Drawing.Size(295, 26);
            this.MenuSaveAsFile.Text = "Сохранить как...";
            this.MenuSaveAsFile.Click += new System.EventHandler(this.mFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(292, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(292, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuExit.Size = new System.Drawing.Size(295, 26);
            this.MenuExit.Text = "Выход";
            this.MenuExit.Click += new System.EventHandler(this.mFileExit_Click);
            // 
            // mEdit
            // 
            this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCancel,
            this.MenuCut,
            this.MenuCopy,
            this.MenuPaste,
            this.MenuDelete,
            this.MenuFind,
            this.найтиДалееToolStripMenuItem,
            this.найтиРанееToolStripMenuItem,
            this.MenuReplace,
            this.MenuGoOver,
            this.toolStripSeparator5});
            this.mEdit.Name = "mEdit";
            this.mEdit.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mEdit.Size = new System.Drawing.Size(74, 24);
            this.mEdit.Text = "Правка";
            // 
            // MenuCancel
            // 
            this.MenuCancel.Name = "MenuCancel";
            this.MenuCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuCancel.Size = new System.Drawing.Size(253, 26);
            this.MenuCancel.Text = "Отменить";
            this.MenuCancel.Click += new System.EventHandler(this.mEditCancel_Click);
            // 
            // MenuCut
            // 
            this.MenuCut.Enabled = false;
            this.MenuCut.Name = "MenuCut";
            this.MenuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuCut.Size = new System.Drawing.Size(253, 26);
            this.MenuCut.Text = "Вырезать";
            this.MenuCut.Click += new System.EventHandler(this.mEditCut_Click);
            // 
            // MenuCopy
            // 
            this.MenuCopy.Enabled = false;
            this.MenuCopy.Name = "MenuCopy";
            this.MenuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuCopy.Size = new System.Drawing.Size(253, 26);
            this.MenuCopy.Text = "Копировать";
            this.MenuCopy.Click += new System.EventHandler(this.mEditCopy_Click);
            // 
            // MenuPaste
            // 
            this.MenuPaste.Name = "MenuPaste";
            this.MenuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuPaste.Size = new System.Drawing.Size(253, 26);
            this.MenuPaste.Text = "Вставить";
            this.MenuPaste.Click += new System.EventHandler(this.mEditPaste_Click);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Enabled = false;
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MenuDelete.Size = new System.Drawing.Size(253, 26);
            this.MenuDelete.Text = "Удалить";
            this.MenuDelete.Click += new System.EventHandler(this.mEditDel_Click);
            // 
            // MenuFind
            // 
            this.MenuFind.Name = "MenuFind";
            this.MenuFind.Size = new System.Drawing.Size(253, 26);
            this.MenuFind.Text = "Найти";
            this.MenuFind.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // найтиДалееToolStripMenuItem
            // 
            this.найтиДалееToolStripMenuItem.Name = "найтиДалееToolStripMenuItem";
            this.найтиДалееToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.найтиДалееToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.найтиДалееToolStripMenuItem.Text = "Найти далее";
            this.найтиДалееToolStripMenuItem.Click += new System.EventHandler(this.найтиДалееToolStripMenuItem_Click);
            // 
            // найтиРанееToolStripMenuItem
            // 
            this.найтиРанееToolStripMenuItem.Name = "найтиРанееToolStripMenuItem";
            this.найтиРанееToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.найтиРанееToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.найтиРанееToolStripMenuItem.Text = "Найти ранее";
            this.найтиРанееToolStripMenuItem.Click += new System.EventHandler(this.найтиРанееToolStripMenuItem_Click);
            // 
            // MenuReplace
            // 
            this.MenuReplace.Name = "MenuReplace";
            this.MenuReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MenuReplace.Size = new System.Drawing.Size(253, 26);
            this.MenuReplace.Text = "Заменить";
            this.MenuReplace.Click += new System.EventHandler(this.mEditFind_Click);
            // 
            // MenuGoOver
            // 
            this.MenuGoOver.Enabled = false;
            this.MenuGoOver.Name = "MenuGoOver";
            this.MenuGoOver.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.MenuGoOver.Size = new System.Drawing.Size(253, 26);
            this.MenuGoOver.Text = "Перейти...";
            this.MenuGoOver.Click += new System.EventHandler(this.mEditGo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(250, 6);
            // 
            // mFormat
            // 
            this.mFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuWordWrap,
            this.MenuFont});
            this.mFormat.Name = "mFormat";
            this.mFormat.Size = new System.Drawing.Size(77, 24);
            this.mFormat.Text = "Формат";
            // 
            // MenuWordWrap
            // 
            this.MenuWordWrap.CheckOnClick = true;
            this.MenuWordWrap.Name = "MenuWordWrap";
            this.MenuWordWrap.Size = new System.Drawing.Size(230, 26);
            this.MenuWordWrap.Text = "Перенос по словам";
            this.MenuWordWrap.CheckStateChanged += new System.EventHandler(this.mFormatTransfer_CheckStateChanged);
            this.MenuWordWrap.Click += new System.EventHandler(this.MenuWordWrap_Click);
            // 
            // MenuFont
            // 
            this.MenuFont.Name = "MenuFont";
            this.MenuFont.Size = new System.Drawing.Size(230, 26);
            this.MenuFont.Text = "Шрифт";
            this.MenuFont.Click += new System.EventHandler(this.mFormatFont_Click);
            // 
            // mView
            // 
            this.mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStatus,
            this.фонToolStripMenuItem});
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(49, 24);
            this.mView.Text = "Вид";
            // 
            // MenuStatus
            // 
            this.MenuStatus.Checked = true;
            this.MenuStatus.CheckOnClick = true;
            this.MenuStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuStatus.Name = "MenuStatus";
            this.MenuStatus.Size = new System.Drawing.Size(216, 26);
            this.MenuStatus.Text = "Строка состояния";
            this.MenuStatus.CheckStateChanged += new System.EventHandler(this.mViewStatusStrip_CheckStateChanged);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAboutProgram});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(81, 24);
            this.mHelp.Text = "Справка";
            // 
            // MenuAboutProgram
            // 
            this.MenuAboutProgram.Name = "MenuAboutProgram";
            this.MenuAboutProgram.Size = new System.Drawing.Size(187, 26);
            this.MenuAboutProgram.Text = "О программе";
            this.MenuAboutProgram.Click += new System.EventHandler(this.mHelpAboutProgram_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLab1,
            this.statusLinesCount,
            this.statusLab2,
            this.statusWordsCount,
            this.statusLab3,
            this.statusCharSpaceCount,
            this.statusLab4,
            this.statusCharCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 418);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(832, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLab1
            // 
            this.statusLab1.Name = "statusLab1";
            this.statusLab1.Size = new System.Drawing.Size(135, 20);
            this.statusLab1.Text = "Количество строк:";
            // 
            // statusLinesCount
            // 
            this.statusLinesCount.Name = "statusLinesCount";
            this.statusLinesCount.Size = new System.Drawing.Size(17, 20);
            this.statusLinesCount.Text = "0";
            // 
            // statusLab2
            // 
            this.statusLab2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLab2.Name = "statusLab2";
            this.statusLab2.Size = new System.Drawing.Size(129, 20);
            this.statusLab2.Text = "Количество слов:";
            // 
            // statusWordsCount
            // 
            this.statusWordsCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusWordsCount.Name = "statusWordsCount";
            this.statusWordsCount.Size = new System.Drawing.Size(17, 20);
            this.statusWordsCount.Text = "0";
            // 
            // statusLab3
            // 
            this.statusLab3.Name = "statusLab3";
            this.statusLab3.Size = new System.Drawing.Size(178, 20);
            this.statusLab3.Text = "Символов с пробелами:";
            // 
            // statusCharSpaceCount
            // 
            this.statusCharSpaceCount.Name = "statusCharSpaceCount";
            this.statusCharSpaceCount.Size = new System.Drawing.Size(17, 20);
            this.statusCharSpaceCount.Text = "0";
            // 
            // statusLab4
            // 
            this.statusLab4.Name = "statusLab4";
            this.statusLab4.Size = new System.Drawing.Size(184, 20);
            this.statusLab4.Text = "Символов без пробелов:";
            // 
            // statusCharCount
            // 
            this.statusCharCount.Name = "statusCharCount";
            this.statusCharCount.Size = new System.Drawing.Size(17, 20);
            this.statusCharCount.Text = "0";
            // 
            // notebox
            // 
            this.notebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notebox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notebox.Location = new System.Drawing.Point(0, 30);
            this.notebox.Margin = new System.Windows.Forms.Padding(4);
            this.notebox.Multiline = true;
            this.notebox.Name = "notebox";
            this.notebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notebox.Size = new System.Drawing.Size(832, 388);
            this.notebox.TabIndex = 2;
            this.notebox.WordWrap = false;
            this.notebox.TextChanged += new System.EventHandler(this.notebox_TextChanged);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // фонToolStripMenuItem
            // 
            this.фонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.фиолетовыйToolStripMenuItem,
            this.серыйToolStripMenuItem,
            this.белыйToolStripMenuItem});
            this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            this.фонToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.фонToolStripMenuItem.Text = "Фон";
            this.фонToolStripMenuItem.Click += new System.EventHandler(this.фонToolStripMenuItem_Click);
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // фиолетовыйToolStripMenuItem
            // 
            this.фиолетовыйToolStripMenuItem.Name = "фиолетовыйToolStripMenuItem";
            this.фиолетовыйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.фиолетовыйToolStripMenuItem.Text = "Фиолетовый";
            this.фиолетовыйToolStripMenuItem.Click += new System.EventHandler(this.фиолетовыйToolStripMenuItem_Click);
            // 
            // серыйToolStripMenuItem
            // 
            this.серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            this.серыйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.серыйToolStripMenuItem.Text = "Серый";
            this.серыйToolStripMenuItem.Click += new System.EventHandler(this.серыйToolStripMenuItem_Click);
            // 
            // белыйToolStripMenuItem
            // 
            this.белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            this.белыйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.белыйToolStripMenuItem.Text = "Белый";
            this.белыйToolStripMenuItem.Click += new System.EventHandler(this.белыйToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 444);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Мой блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mEdit;
        private System.Windows.Forms.ToolStripMenuItem mFormat;
        private System.Windows.Forms.ToolStripMenuItem mView;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuCreateFile;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAsFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuCancel;
        private System.Windows.Forms.ToolStripMenuItem MenuCut;
        private System.Windows.Forms.ToolStripMenuItem MenuCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuGoOver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MenuWordWrap;
        private System.Windows.Forms.ToolStripMenuItem MenuFont;
        private System.Windows.Forms.ToolStripMenuItem MenuStatus;
        private System.Windows.Forms.ToolStripMenuItem MenuAboutProgram;
        public System.Windows.Forms.TextBox notebox;
        private System.Windows.Forms.ToolStripStatusLabel statusLab3;
        private System.Windows.Forms.ToolStripStatusLabel statusCharSpaceCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab2;
        private System.Windows.Forms.ToolStripStatusLabel statusWordsCount;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripStatusLabel statusLab4;
        private System.Windows.Forms.ToolStripStatusLabel statusCharCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab1;
        private System.Windows.Forms.ToolStripStatusLabel statusLinesCount;
        private System.Windows.Forms.FontDialog fontDialog;
        public System.Windows.Forms.ToolStripMenuItem MenuReplace;
        private System.Windows.Forms.ToolStripMenuItem MenuNewWindow;
        private System.Windows.Forms.ToolStripMenuItem MenuFind;
        private System.Windows.Forms.ToolStripMenuItem найтиДалееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиРанееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фиолетовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйToolStripMenuItem;
    }
}

