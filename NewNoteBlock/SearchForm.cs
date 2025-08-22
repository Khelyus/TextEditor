using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewNoteBlock
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
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

        private void butFind_Click(object sender, EventArgs e) // Кнопка "Найти"
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
               
                    TextWork.FindTextBox(ref main.notebox, tbFind.Text, ref findCutLength, true);
                    Enabled = true;
                
               
            }
        }

        private void butReplace_Click(object sender, EventArgs e) // Кнопка "Заменить"
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
               
                    TextWork.ReplaceTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, ref findCutLength, true); //учитывает регистр
                
                
            }
        }

        private void butReplaceAll_Click(object sender, EventArgs e) // Кнопка "Заменить всё"
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
               
                    TextWork.ReplaceAllTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, true);
                
             
            }
        }

        private void butCancel_Click(object sender, EventArgs e) // Кнопка "Отмена"
        {
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
