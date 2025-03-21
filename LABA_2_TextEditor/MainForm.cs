using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Unicode;

//System.IO.FileWork;

using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace LABA_2_TextEditor
{
    public partial class MainForm : Form
    {
        String path = String.Empty;
        private int childFormNumber = 0;
        bool tbChange = false;
        string docPath = "";

        public MainForm()
        {
            InitializeComponent();
            textBox1.Multiline = true; // ��������� ������������� �����
                                       // textBox1 �������� ��� ��������� ����������� �����
            textBox1.Dock = DockStyle.Fill;
            // �������� ������������ � �������������� ������ ���������
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = false; // ��������� ������� �����
            textBox1.Clear();
            this.Text = "������� ��������� ��������";
            openFileDialog1.FileName = "Text2.txt";
            openFileDialog1.Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
            saveFileDialog1.Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
        }
        // ���������� ������� Click ������ ���� �������
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        { // ������� ������ �������� �����
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            //if (openFileDialog1.FileName == null) return;
            // ������ ���������� �����:
            try
            {
                var �������� = new System.IO.StreamReader(openFileDialog1.FileName,
                System.Text.Encoding.UTF8);
                Encoding russianCodePage = Encoding.UTF8;
                // ����� ����� ������� �������� Winl251 ��� ������� ����
                textBox1.Text = ��������.ReadToEnd();
                ��������.Close();
            }
            catch (System.IO.FileNotFoundException ��������)
            {
                MessageBox.Show(�������� + "\n��� ������ �����", "������",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Exception ��������)
            {
                // ����� � ������ �������
                MessageBox.Show(��������.Message, "������", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
        // ���������� ������� Click ������ ���� ��������� ���
        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) ������();
        }
        // ��������������� ����� ��� ������ ������ � ����
        private void ������()
        {
            try
            { // �������� ���������� StreamWriter ��� ������ � ����:
                var �������� = new System.IO.StreamWriter(saveFileDialog1.FileName, false,
                System.Text.Encoding.UTF8);
                // - ����� ����� ������� �������� Winl251 ��� ������� ����
                ��������.Write(textBox1.Text);
                ��������.Close();
                textBox1.Modified = false;
            }
            catch (System.Exception ��������)
            { // ����� ��� ���� ��������� �������
                MessageBox.Show(��������.Message, "������", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
        // ���������� ������� Click ������ ���� �����
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ���������� ������� FormClosing �����
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == false) return;
            // ���� ����� �������������, �� ��������, ���������� �� ����
            DialogResult MBox = MessageBox.Show("����� ��� �������.\n��������� ���������?",
            "������� ��������", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            // YES � ������; NO � �����; CANCEL � �������������
            if (MBox == DialogResult.No) return;
            if (MBox == DialogResult.Cancel) e.Cancel = true;
            if (MBox == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ������();
                    return;
                }
                else e.Cancel = true; // ��������� �������� �� ���������
            } // DialogResult.Yes

        }

        private void ���������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile(false);
        }

        private string savedFileName;

        private void SaveFile(bool saveAs)
        {
            if (saveAs || savedFileName == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                savedFileName = saveFileDialog1.FileName;
            }
            File.WriteAllText(savedFileName, textBox1.Text);
            MessageBox.Show("���� ��������");
        }


        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string newDocName = Properties.Settings.Default.newDocName;
            string programmName = Properties.Settings.Default.programmName;
            textBox1.Clear();
            docPath = "";
            tbChange = false;
            MainForm.ActiveForm.Text = newDocName + " � " + programmName;

        }

        private void ���������CTRLSHIFTNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var newForm = new MainForm();

            newForm.Show();



        }

        private void ��������CTRLXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void ����������CTRLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void ��������CTRLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void �������DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ������� findText = new �������();
            /*findText.Owner = this;*/

            findText.Show();
        }



        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.YellowGreen;
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Purple;
        }

        private void ��������CTRLZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void mEditGo_Click(object sender, EventArgs e)
        {
            GoToForm gotoform = new GoToForm();
            gotoform.Owner = this;
            gotoform.tbLineNum.Minimum = 0;
            gotoform.tbLineNum.Maximum = textBox1.Lines.Count();
            gotoform.ShowDialog();


        }



        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}