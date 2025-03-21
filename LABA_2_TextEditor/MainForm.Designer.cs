namespace LABA_2_TextEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            mFileNew = new ToolStripMenuItem();
            новоеОкноCTRLSHIFTNToolStripMenuItem = new ToolStripMenuItem();
            открытьCTRLOToolStripMenuItem = new ToolStripMenuItem();
            сохранитьCTRLSToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакCTRLSHIFTSToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            отменитьCTRLZToolStripMenuItem = new ToolStripMenuItem();
            вырезатьCTRLXToolStripMenuItem = new ToolStripMenuItem();
            копироватьCTRLCToolStripMenuItem = new ToolStripMenuItem();
            вставитьCTRLVToolStripMenuItem = new ToolStripMenuItem();
            удалитьDelToolStripMenuItem = new ToolStripMenuItem();
            наToolStripMenuItem = new ToolStripMenuItem();
            найтиДалееF3ToolStripMenuItem = new ToolStripMenuItem();
            найтиРанееSHIFTF3ToolStripMenuItem = new ToolStripMenuItem();
            mEditFind = new ToolStripMenuItem();
            mEditGo = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            mFormatTransfer = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            фонToolStripMenuItem = new ToolStripMenuItem();
            синийToolStripMenuItem = new ToolStripMenuItem();
            красныйToolStripMenuItem = new ToolStripMenuItem();
            зеленыйToolStripMenuItem = new ToolStripMenuItem();
            серыйToolStripMenuItem = new ToolStripMenuItem();
            фиолетовыйToolStripMenuItem = new ToolStripMenuItem();
            mViewStatusStrip = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            toolStripStatusLabel7 = new ToolStripStatusLabel();
            toolStripStatusLabel8 = new ToolStripStatusLabel();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, форматToolStripMenuItem, видToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1032, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mFileNew, новоеОкноCTRLSHIFTNToolStripMenuItem, открытьCTRLOToolStripMenuItem, сохранитьCTRLSToolStripMenuItem, сохранитьКакCTRLSHIFTSToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // mFileNew
            // 
            mFileNew.Name = "mFileNew";
            mFileNew.ShortcutKeys = Keys.Control | Keys.N;
            mFileNew.Size = new Size(295, 26);
            mFileNew.Text = "Создать ";
            mFileNew.Click += btnCreateFile_Click;
            // 
            // новоеОкноCTRLSHIFTNToolStripMenuItem
            // 
            новоеОкноCTRLSHIFTNToolStripMenuItem.Name = "новоеОкноCTRLSHIFTNToolStripMenuItem";
            новоеОкноCTRLSHIFTNToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            новоеОкноCTRLSHIFTNToolStripMenuItem.Size = new Size(295, 26);
            новоеОкноCTRLSHIFTNToolStripMenuItem.Text = "Новое окно ";
            новоеОкноCTRLSHIFTNToolStripMenuItem.Click += новоеОкноCTRLSHIFTNToolStripMenuItem_Click;
            // 
            // открытьCTRLOToolStripMenuItem
            // 
            открытьCTRLOToolStripMenuItem.Name = "открытьCTRLOToolStripMenuItem";
            открытьCTRLOToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьCTRLOToolStripMenuItem.Size = new Size(295, 26);
            открытьCTRLOToolStripMenuItem.Text = "Открыть...";
            открытьCTRLOToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьCTRLSToolStripMenuItem
            // 
            сохранитьCTRLSToolStripMenuItem.Name = "сохранитьCTRLSToolStripMenuItem";
            сохранитьCTRLSToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьCTRLSToolStripMenuItem.Size = new Size(295, 26);
            сохранитьCTRLSToolStripMenuItem.Text = "Сохранить";
            сохранитьCTRLSToolStripMenuItem.Click += сохранитьToolStripMenuItem1_Click;
            // 
            // сохранитьКакCTRLSHIFTSToolStripMenuItem
            // 
            сохранитьКакCTRLSHIFTSToolStripMenuItem.Name = "сохранитьКакCTRLSHIFTSToolStripMenuItem";
            сохранитьКакCTRLSHIFTSToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            сохранитьКакCTRLSHIFTSToolStripMenuItem.Size = new Size(295, 26);
            сохранитьКакCTRLSHIFTSToolStripMenuItem.Text = "Сохранить как... ";
            сохранитьКакCTRLSHIFTSToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(295, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьCTRLZToolStripMenuItem, вырезатьCTRLXToolStripMenuItem, копироватьCTRLCToolStripMenuItem, вставитьCTRLVToolStripMenuItem, удалитьDelToolStripMenuItem, наToolStripMenuItem, найтиДалееF3ToolStripMenuItem, найтиРанееSHIFTF3ToolStripMenuItem, mEditFind, mEditGo });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(74, 24);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьCTRLZToolStripMenuItem
            // 
            отменитьCTRLZToolStripMenuItem.Name = "отменитьCTRLZToolStripMenuItem";
            отменитьCTRLZToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            отменитьCTRLZToolStripMenuItem.Size = new Size(245, 26);
            отменитьCTRLZToolStripMenuItem.Text = "Отменить";
            отменитьCTRLZToolStripMenuItem.Click += отменитьCTRLZToolStripMenuItem_Click;
            // 
            // вырезатьCTRLXToolStripMenuItem
            // 
            вырезатьCTRLXToolStripMenuItem.Name = "вырезатьCTRLXToolStripMenuItem";
            вырезатьCTRLXToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            вырезатьCTRLXToolStripMenuItem.Size = new Size(245, 26);
            вырезатьCTRLXToolStripMenuItem.Text = "Вырезать";
            вырезатьCTRLXToolStripMenuItem.Click += вырезатьCTRLXToolStripMenuItem_Click;
            // 
            // копироватьCTRLCToolStripMenuItem
            // 
            копироватьCTRLCToolStripMenuItem.Name = "копироватьCTRLCToolStripMenuItem";
            копироватьCTRLCToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            копироватьCTRLCToolStripMenuItem.Size = new Size(245, 26);
            копироватьCTRLCToolStripMenuItem.Text = "Копировать";
            копироватьCTRLCToolStripMenuItem.Click += копироватьCTRLCToolStripMenuItem_Click;
            // 
            // вставитьCTRLVToolStripMenuItem
            // 
            вставитьCTRLVToolStripMenuItem.Name = "вставитьCTRLVToolStripMenuItem";
            вставитьCTRLVToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            вставитьCTRLVToolStripMenuItem.Size = new Size(245, 26);
            вставитьCTRLVToolStripMenuItem.Text = "Вставить";
            вставитьCTRLVToolStripMenuItem.Click += вставитьCTRLVToolStripMenuItem_Click;
            // 
            // удалитьDelToolStripMenuItem
            // 
            удалитьDelToolStripMenuItem.Name = "удалитьDelToolStripMenuItem";
            удалитьDelToolStripMenuItem.ShortcutKeys = Keys.Delete;
            удалитьDelToolStripMenuItem.Size = new Size(245, 26);
            удалитьDelToolStripMenuItem.Text = "Удалить";
            удалитьDelToolStripMenuItem.Click += удалитьDelToolStripMenuItem_Click;
            // 
            // наToolStripMenuItem
            // 
            наToolStripMenuItem.Name = "наToolStripMenuItem";
            наToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            наToolStripMenuItem.Size = new Size(245, 26);
            наToolStripMenuItem.Text = "Найти";
            наToolStripMenuItem.Click += наToolStripMenuItem_Click;
            // 
            // найтиДалееF3ToolStripMenuItem
            // 
            найтиДалееF3ToolStripMenuItem.Name = "найтиДалееF3ToolStripMenuItem";
            найтиДалееF3ToolStripMenuItem.ShortcutKeys = Keys.F3;
            найтиДалееF3ToolStripMenuItem.Size = new Size(245, 26);
            найтиДалееF3ToolStripMenuItem.Text = "Найти далее";
            // 
            // найтиРанееSHIFTF3ToolStripMenuItem
            // 
            найтиРанееSHIFTF3ToolStripMenuItem.Name = "найтиРанееSHIFTF3ToolStripMenuItem";
            найтиРанееSHIFTF3ToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            найтиРанееSHIFTF3ToolStripMenuItem.Size = new Size(245, 26);
            найтиРанееSHIFTF3ToolStripMenuItem.Text = "Найти ранее";
            // 
            // mEditFind
            // 
            mEditFind.Name = "mEditFind";
            mEditFind.ShortcutKeys = Keys.Control | Keys.H;
            mEditFind.Size = new Size(245, 26);
            mEditFind.Text = "Заменить ";
            // 
            // mEditGo
            // 
            mEditGo.Name = "mEditGo";
            mEditGo.ShortcutKeys = Keys.Control | Keys.G;
            mEditGo.Size = new Size(245, 26);
            mEditGo.Text = "Перейсти";
            mEditGo.Click += mEditGo_Click;
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mFormatTransfer, шрифтToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(77, 24);
            форматToolStripMenuItem.Text = "Формат";
            // 
            // mFormatTransfer
            // 
            mFormatTransfer.Name = "mFormatTransfer";
            mFormatTransfer.Size = new Size(230, 26);
            mFormatTransfer.Text = "Перенос по словам";
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(230, 26);
            шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { фонToolStripMenuItem, mViewStatusStrip });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(49, 24);
            видToolStripMenuItem.Text = "Вид";
            // 
            // фонToolStripMenuItem
            // 
            фонToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { синийToolStripMenuItem, красныйToolStripMenuItem, зеленыйToolStripMenuItem, серыйToolStripMenuItem, фиолетовыйToolStripMenuItem });
            фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            фонToolStripMenuItem.Size = new Size(216, 26);
            фонToolStripMenuItem.Text = "Фон";
            фонToolStripMenuItem.Click += фонToolStripMenuItem_Click;
            // 
            // синийToolStripMenuItem
            // 
            синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            синийToolStripMenuItem.Size = new Size(202, 26);
            синийToolStripMenuItem.Text = "Синий";
            синийToolStripMenuItem.Click += синийToolStripMenuItem_Click;
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(202, 26);
            красныйToolStripMenuItem.Text = "Красный";
            красныйToolStripMenuItem.Click += красныйToolStripMenuItem_Click;
            // 
            // зеленыйToolStripMenuItem
            // 
            зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            зеленыйToolStripMenuItem.Size = new Size(202, 26);
            зеленыйToolStripMenuItem.Text = "Зеленый";
            зеленыйToolStripMenuItem.Click += зеленыйToolStripMenuItem_Click;
            // 
            // серыйToolStripMenuItem
            // 
            серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            серыйToolStripMenuItem.Size = new Size(202, 26);
            серыйToolStripMenuItem.Text = "Желто-зеленый";
            серыйToolStripMenuItem.Click += серыйToolStripMenuItem_Click;
            // 
            // фиолетовыйToolStripMenuItem
            // 
            фиолетовыйToolStripMenuItem.Name = "фиолетовыйToolStripMenuItem";
            фиолетовыйToolStripMenuItem.Size = new Size(202, 26);
            фиолетовыйToolStripMenuItem.Text = "Фиолетовый";
            фиолетовыйToolStripMenuItem.Click += фиолетовыйToolStripMenuItem_Click;
            // 
            // mViewStatusStrip
            // 
            mViewStatusStrip.Name = "mViewStatusStrip";
            mViewStatusStrip.Size = new Size(216, 26);
            mViewStatusStrip.Text = "Строка состояния";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(187, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel5, toolStripStatusLabel6, toolStripStatusLabel7, toolStripStatusLabel8 });
            statusStrip.Location = new Point(0, 463);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1032, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(132, 20);
            toolStripStatusLabel1.Text = "Количество строк";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(17, 20);
            toolStripStatusLabel2.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(126, 20);
            toolStripStatusLabel3.Text = "Количество слов";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(17, 20);
            toolStripStatusLabel4.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(175, 20);
            toolStripStatusLabel5.Text = "Символов с пробелами";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(17, 20);
            toolStripStatusLabel6.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            toolStripStatusLabel7.Size = new Size(181, 20);
            toolStripStatusLabel7.Text = "Символов без пробелов";
            // 
            // toolStripStatusLabel8
            // 
            toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            toolStripStatusLabel8.Size = new Size(17, 20);
            toolStripStatusLabel8.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(1032, 435);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 489);
            Controls.Add(textBox1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem mFileNew;
        private ToolStripMenuItem новоеОкноCTRLSHIFTNToolStripMenuItem;
        private ToolStripMenuItem открытьCTRLOToolStripMenuItem;
        private ToolStripMenuItem сохранитьCTRLSToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакCTRLSHIFTSToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem отменитьCTRLZToolStripMenuItem;
        private ToolStripMenuItem вырезатьCTRLXToolStripMenuItem;
        private ToolStripMenuItem копироватьCTRLCToolStripMenuItem;
        private ToolStripMenuItem вставитьCTRLVToolStripMenuItem;
        private ToolStripMenuItem удалитьDelToolStripMenuItem;
        private ToolStripMenuItem наToolStripMenuItem;
        private ToolStripMenuItem найтиДалееF3ToolStripMenuItem;
        private ToolStripMenuItem найтиРанееSHIFTF3ToolStripMenuItem;
        private ToolStripMenuItem mEditFind;
        private ToolStripMenuItem mEditGo;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem mFormatTransfer;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem фонToolStripMenuItem;
        private ToolStripMenuItem mViewStatusStrip;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabel7;
        private ToolStripStatusLabel toolStripStatusLabel8;
        public TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem зеленыйToolStripMenuItem;
        private ToolStripMenuItem серыйToolStripMenuItem;
        private ToolStripMenuItem фиолетовыйToolStripMenuItem;
    }
}
