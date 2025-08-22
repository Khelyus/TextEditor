using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewNoteBlock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = Properties.Settings.Default.newDocName + " - " + Properties.Settings.Default.programmName;

            TextWork.mEditEnableds(ref notebox, ref MenuCopy, ref MenuCut, ref MenuDelete, ref MenuReplace, ref MenuGoOver);
        }
        public MainForm(string fileName) 
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName)) 
            {
                try
                {
                    string programmName = Properties.Settings.Default.programmName; //извлекает имя программы из настроек приложения.
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    notebox.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + programmName;
                    notebox.Select(0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            TextWork.mEditEnableds(ref notebox, ref MenuCopy, ref MenuCut, ref MenuDelete, ref MenuReplace, ref MenuGoOver);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Задаем сохраненные (или стандартные) настройки
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            notebox.Font = Properties.Settings.Default.textFont;
            if (Properties.Settings.Default.statusStripVisible == true)
            { MenuStatus.CheckState = CheckState.Checked; }
            else
            { MenuStatus.CheckState = CheckState.Unchecked; }
            if (Properties.Settings.Default.textTransfer == true)
            { MenuWordWrap.CheckState = CheckState.Checked; }
            else
            { MenuWordWrap.CheckState = CheckState.Unchecked; }
        }

        bool tbChange = false; // Индикатор изменения текста
        string docPath = ""; //  Путь к файлу

        private void mFileNew_Click(object sender, EventArgs e) 
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ?", "Создание документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.MenuCreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.MenuCreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.MenuCreateFile(ref notebox, ref tbChange, ref docPath);
                }
            }
            else
            {
                FileWork.MenuCreateFile(ref notebox, ref tbChange, ref docPath);
            }
        }

        private void mFileSaveAs_Click(object sender, EventArgs e) 
        {
            FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
        }

        private void notebox_TextChanged(object sender, EventArgs e) 
        {
            tbChange = true; // Индикатор изменения текста
            TextWork.mEditEnableds(ref notebox, ref MenuCopy, ref MenuCut, ref MenuDelete, ref MenuReplace, ref MenuGoOver);
            TextWork.StatusAnalize(ref notebox, ref statusLinesCount , ref statusWordsCount, ref statusCharSpaceCount, ref statusCharCount);
        }

        private void mFileOpen_Click(object sender, EventArgs e) 
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
            }
        }

        private void mFileSave_Click(object sender, EventArgs e) 
        {
            if (docPath != "")
            {
                FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
            }
            else
            {
                FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
            }
        }

        private void mFileExit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }


        private void mEditCancel_Click(object sender, EventArgs e) { 
            notebox.Undo();
        }

        private void mEditCut_Click(object sender, EventArgs e) 
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.Cut();
            }
        }

        private void mEditCopy_Click(object sender, EventArgs e) 
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.Copy();
            }
        }

        private void mEditPaste_Click(object sender, EventArgs e) 
        {
            notebox.Paste();
        }

        private void mEditDel_Click(object sender, EventArgs e) 
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.SelectedText = "";
            }
        }

        private void mEditGiveAll_Click(object sender, EventArgs e) 
        {
            notebox.SelectAll();
        }

        private void mEditTime_Click(object sender, EventArgs e) 
        {
            notebox.AppendText(Environment.NewLine + Convert.ToString(System.DateTime.Now));
        }

        private void mEditFind_Click(object sender, EventArgs e) 
        {
            SearchForm findText = new SearchForm();

            findText.Owner = this;
            findText.Show();
        }

        private void mHelpAboutProgram_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void mViewStatusStrip_CheckStateChanged(object sender, EventArgs e) 
        {
            if (MenuStatus.CheckState == CheckState.Checked)
            {
                statusStrip.Visible = true;
            }
            else
            {
                statusStrip.Visible = false;
            }
        }

        private void mFormatTransfer_CheckStateChanged(object sender, EventArgs e) 
        {
            if (MenuWordWrap.CheckState == CheckState.Checked)
            {
                notebox.WordWrap = true;
                notebox.ScrollBars = ScrollBars.Vertical;
                MenuGoOver.Enabled = false;
                statusLab1.Visible = false;
                statusLinesCount.Visible = false;
            }
            else
            {
                notebox.WordWrap = false;
                notebox.ScrollBars = ScrollBars.Both;
                MenuGoOver.Enabled = true;
                statusLab1.Visible = true;
                statusLinesCount.Visible = true;
            }
        }

        private void mEditGo_Click(object sender, EventArgs e) 
        {
            GoToForm gotoform = new GoToForm();
            gotoform.Owner = this;
            gotoform.tbLineNum.Minimum = 0;
            gotoform.tbLineNum.Maximum = notebox.Lines.Count();
            gotoform.ShowDialog();
        }

        private void mFormatFont_Click(object sender, EventArgs e) 
        {
            fontDialog.ShowDialog();
            notebox.Font = fontDialog.Font;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) 
        {
            Properties.Settings.Default.formWidth = this.Width;
            Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textTransfer = notebox.WordWrap;
            Properties.Settings.Default.textFont = notebox.Font;
            Properties.Settings.Default.statusStripVisible = statusStrip.Visible;
            Properties.Settings.Default.Save();
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                }
                else if (message == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new MainForm();

            newForm.Show();
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnlySearch findText1 = new OnlySearch();

            findText1.Owner = this;
            findText1.Show();
        }
    


        private void найтиДалееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       
        private void найтиРанееToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            
        }

        private void MenuWordWrap_Click(object sender, EventArgs e)
        {

        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox.BackColor = Color.Red;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox.BackColor = Color.Blue;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox.BackColor = Color.Green;
        }

        private void фиолетовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox.BackColor = Color.MediumPurple;
        }

        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox.BackColor = Color.Gray;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox.BackColor = Color.White;
        }
    }
}
