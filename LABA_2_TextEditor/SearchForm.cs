using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LABA_2_TextEditor
{
    public partial class Перейти : Form
    {
        public Перейти()
        {
            InitializeComponent();
            // this.btFind.Click += btFind_Click;
        }




        private void SearchForm_Shown(object sender, EventArgs e) // Событие при открытии формы поиска и замены
        {
            tbFind.Focus();
        }

        int findCutLength = 0; // На сколько символов обрезаем текст для поиска

        private void tbFind_TextChanged(object sender, EventArgs e) // Cобытие при изменении текста в tbFind
        {
            findCutLength = 0;
        }

        private void tbReplace_TextChanged(object sender, EventArgs e) // Событие при изменении текста в tbReplace
        {
            findCutLength = 0;
        }

        private void cbReg_CheckStateChanged(object sender, EventArgs e) // Событие при изменении статуса cbReg
        {
            findCutLength = 0;
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e) // Событие при закрытии формы (до закрытия)
        {
            findCutLength = 0;
        }

        private void btFind_Click(object sender, EventArgs e) // Кнопка "Найти"
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbRegister.CheckState == CheckState.Checked)
                {
                    FindTextBox(ref main.textBox1, tbFind.Text, ref findCutLength, true);
                }
                else
                {
                    FindTextBox(ref main.textBox1, tbFind.Text, ref findCutLength, false);
                }
            }


        }




        private void btReplace_Click(object sender, EventArgs e) // Кнопка "Заменить"
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbRegister.CheckState == CheckState.Checked)
                {
                    ReplaceTextBox(ref main.textBox1, tbFind.Text, tbReplace.Text, ref findCutLength, true);
                }
                else
                {
                    ReplaceTextBox(ref main.textBox1, tbFind.Text, tbReplace.Text, ref findCutLength, false);
                }
            }
        }

        private void btReplaceAll_Click(object sender, EventArgs e) // Кнопка "Заменить всё"
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbRegister.CheckState == CheckState.Checked)
                {
                    ReplaceAllTextBox(ref main.textBox1, tbFind.Text, tbReplace.Text, true);
                }
                else
                {
                    ReplaceAllTextBox(ref main.textBox1, tbFind.Text, tbReplace.Text, false);
                }
            }
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btFind_Click_1(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbRegister.CheckState == CheckState.Checked)
                {
                    FindTextBox(ref main.textBox1, tbFind.Text, ref findCutLength, true);
                }
                else
                {
                    FindTextBox(ref main.textBox1, tbFind.Text, ref findCutLength, false);
                }
            }
          
        }




        private int FindTextBox(ref TextBox textBox, string findText, ref int findCutLength, bool register)
        {
            // Поиск с учетом регистра
            if (register == true)
            {
                if (textBox.Text.Contains(findText))
                {
                    // Заносим текст в переменную string, удаляем из него уже пройденный 
                    // текст (findCutLength) в переменной nextText
                    string text = textBox.Text;
                    string nextText = text.Remove(0, findCutLength);
                    // Ищем в nextText
                    int resultPosition = nextText.IndexOf(findText);
                    // Если искомое выражение найдено - выделяем его, добавляем его позицию и длину 
                    // к значению пройденного текста (findCutLenght)
                    if (resultPosition != -1)
                    {
                        textBox.Select(resultPosition + findCutLength, findText.Length);
                        textBox.ScrollToCaret();
                        textBox.Focus();
                        findCutLength += findText.Length + resultPosition;
                    }
                    // Если попытка поиска не первая, и больше совпадений в тексте нет - обнуляем
                    // значение пройденного текста и начинаем поиск сначала
                    else if (resultPosition == -1 && findCutLength != 0)
                    {
                        findCutLength = 0;
                        return FindTextBox(ref textBox, findText, ref findCutLength, register);
                    }
                }
                else
                {
                    findCutLength = 0;
                    MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // Поиск без учета регистра
            else if (register == false)
            {
                if (textBox.Text.ToLower().Contains(findText.ToLower()))
                {
                    string text = textBox.Text.ToLower();
                    string nextText = text.Remove(0, findCutLength);
                    int resultPosition = nextText.IndexOf(findText.ToLower());

                    if (resultPosition != -1)
                    {
                        textBox.Select(resultPosition + findCutLength, findText.Length);
                        textBox.ScrollToCaret();
                        textBox.Focus();
                        findCutLength += findText.Length + resultPosition;
                    }
                    else if (resultPosition == -1 && findCutLength != 0)
                    {
                        findCutLength = 0;
                        return FindTextBox(ref textBox, findText, ref findCutLength, register);
                    }
                }
                // Если текст изначально не содержит результатов поиска - обнуляем findCutLength, выводим сообщение
                else
                {
                    findCutLength = 0;
                    MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return 0;
        }

        // Метод "Заменить"
        public static int ReplaceTextBox(ref TextBox textBox, string findText, string replaceText, ref int findCutLength, bool register)
        {
            if (register == true)
            {
                if (textBox.Text.Contains(findText))
                {
                    if (textBox.SelectedText == "" || textBox.SelectedText != findText)
                    {
                        string text = textBox.Text;
                        string nextText = text.Remove(0, findCutLength);
                        int resultPosition = nextText.IndexOf(findText);
                        if (resultPosition != -1)
                        {
                            textBox.Select(resultPosition + findCutLength, findText.Length);
                            textBox.ScrollToCaret();
                            textBox.Focus();
                            findCutLength += findText.Length + resultPosition;
                        }
                        else if (resultPosition == -1 && findCutLength != 0)
                        {
                            findCutLength = 0;
                            return ReplaceTextBox(ref textBox, findText, replaceText, ref findCutLength, register);
                        }
                    }
                    else if (textBox.SelectedText == findText)
                    {
                        textBox.SelectedText = replaceText;
                    }
                }
                else
                {
                    findCutLength = 0;
                    MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (register == false)
            {
                if (textBox.Text.ToLower().Contains(findText.ToLower()))
                {
                    if (textBox.SelectedText == "" || textBox.SelectedText.ToLower() != findText.ToLower())
                    {
                        string text = textBox.Text.ToLower();
                        string nextText = text.Remove(0, findCutLength);
                        int resultPosition = nextText.IndexOf(findText.ToLower());
                        if (resultPosition != -1)
                        {
                            textBox.Select(resultPosition + findCutLength, findText.Length);
                            textBox.ScrollToCaret();
                            textBox.Focus();
                            findCutLength += findText.Length + resultPosition;
                        }
                        else if (resultPosition == -1 && findCutLength != 0)
                        {
                            findCutLength = 0;
                            return ReplaceTextBox(ref textBox, findText, replaceText, ref findCutLength, register);
                        }
                    }
                    else if (textBox.SelectedText.ToLower() == findText.ToLower())
                    {
                        textBox.SelectedText = replaceText;
                    }
                }
                else
                {
                    findCutLength = 0;
                    MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return 0;
        }

        // Метод "Заменить всё"
        public static int ReplaceAllTextBox(ref TextBox textBox, string findText, string replaceText, bool register)
        {
            if (register == true)
            {
                string text = textBox.Text;
                string words = findText;
                if (textBox.Text.Contains(words))
                {
                    int startPosition = text.IndexOf(words);
                    textBox.Select(startPosition, words.Length);
                    textBox.SelectedText = replaceText;
                    return ReplaceAllTextBox(ref textBox, findText, replaceText, register);
                }
                else
                {
                    MessageBox.Show("Замены произведены успешно.", "Заменить всё", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (register == false)
            {
                string text = textBox.Text.ToLower();
                string words = findText.ToLower();
                if (text.Contains(words))
                {
                    int startPosition = text.IndexOf(words);
                    textBox.Select(startPosition, findText.Length);
                    textBox.SelectedText = replaceText;
                    return ReplaceAllTextBox(ref textBox, findText, replaceText, register);
                }
                else
                {
                    MessageBox.Show("Замены произведены успешно.", "Заменить всё", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return 0;
        }

        public static void mEditEnableds(ref TextBox notebox, ref ToolStripMenuItem mEditCopy, ref ToolStripMenuItem mEditCut, ref ToolStripMenuItem mEditDel)
        {
            if (notebox.Text.Length < 1)
            {
                mEditCopy.Enabled = false;
                mEditCut.Enabled = false;
                mEditDel.Enabled = false;
                /*mEditFind.Enabled = false;
                mEditGo.Enabled = false;*/
            }
            else
            {
                mEditCopy.Enabled = true;
                mEditCut.Enabled = true;
                mEditDel.Enabled = true;
                /*  mEditFind.Enabled = true;
                  mEditGo.Enabled = true;*/
            }
        }

        public static void StatusAnalize(ref TextBox notebox, ref ToolStripStatusLabel statusLinesCount, ref ToolStripStatusLabel statusWordsCount, ref ToolStripStatusLabel statusCharSpaceCount, ref ToolStripStatusLabel statusCharCount)
        {
            string text = notebox.Text;
            // Количество строк в тексте
            statusLinesCount.Text = notebox.Lines.Count().ToString();
            // Количество слов в тексте
            statusWordsCount.Text = text.Split(new Char[] { ' ', '\t', '\n', '\r', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-',
                '_', '+', '=', '[', '{', ']', '}', '/', '\\', '|', '"', ':', ';', '.', ',', '>', '<' }, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
            // Количество символов без пробелов
            statusCharCount.Text = text.Replace(" ", "").Replace("\t", "").Replace("\n", "").Replace("\r", "").ToCharArray().Length.ToString();
            // Количество символов с пробелами
            statusCharSpaceCount.Text = text.ToCharArray().Length.ToString();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
    


 

