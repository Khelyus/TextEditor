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
            textBox1.Multiline = true; // разрешаем многострочный текст
                                       // textBox1 занимает всю свободную поверхность формы
            textBox1.Dock = DockStyle.Fill;
            // включаем вертикальную и горизонтальную полосы прокрутки
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = false; // запрещаем перенос строк
            textBox1.Clear();
            this.Text = "Простой текстовый редактор";
            openFileDialog1.FileName = "Text2.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        }
        // Обработчик события Click пункта меню Открыть
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        { // Вывести диалог открытия файла
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            //if (openFileDialog1.FileName == null) return;
            // Чтение текстового файла:
            try
            {
                var Читатель = new System.IO.StreamReader(openFileDialog1.FileName,
                System.Text.Encoding.UTF8);
                Encoding russianCodePage = Encoding.UTF8;
                // здесь заказ кодовой страницы Winl251 для русских букв
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close();
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show(Ситуация + "\nНет такого файла", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Exception Ситуация)
            {
                // Отчет о других ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
        // Обработчик события Click пункта меню Сохранить как
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) Запись();
        }
        // Вспомогательный метод для записи текста в файл
        private void Запись()
        {
            try
            { // Создание экземпляра StreamWriter для записи в файл:
                var Писатель = new System.IO.StreamWriter(saveFileDialog1.FileName, false,
                System.Text.Encoding.UTF8);
                // - здесь заказ кодовой страницы Winl251 для русских букв
                Писатель.Write(textBox1.Text);
                Писатель.Close();
                textBox1.Modified = false;
            }
            catch (System.Exception Ситуация)
            { // Отчет обо всех возможных ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
        // Обработчик события Click пункта меню Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик события FormClosing формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == false) return;
            // Если текст модифицирован, то спросить, записывать ли файл
            DialogResult MBox = MessageBox.Show("Текст был изменен.\nСохранить изменения?",
            "Простой редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            // YES — диалог; NO — выход; CANCEL — редактировать
            if (MBox == DialogResult.No) return;
            if (MBox == DialogResult.Cancel) e.Cancel = true;
            if (MBox == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Запись();
                    return;
                }
                else e.Cancel = true; // Передумал выходить из программы
            } // DialogResult.Yes

        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
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
            MessageBox.Show("Файл сохранен");
        }


        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string newDocName = Properties.Settings.Default.newDocName;
            string programmName = Properties.Settings.Default.programmName;
            textBox1.Clear();
            docPath = "";
            tbChange = false;
            MainForm.ActiveForm.Text = newDocName + " — " + programmName;

        }

        private void новоеОкноCTRLSHIFTNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var newForm = new MainForm();

            newForm.Show();



        }

        private void вырезатьCTRLXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void копироватьCTRLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void вставитьCTRLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void удалитьDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void наToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Перейти findText = new Перейти();
            /*findText.Owner = this;*/

            findText.Show();
        }



        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.YellowGreen;
        }

        private void фиолетовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Purple;
        }

        private void отменитьCTRLZToolStripMenuItem_Click(object sender, EventArgs e)
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



        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
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