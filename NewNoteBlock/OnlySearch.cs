using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NewNoteBlock
{
    public partial class OnlySearch : Form
    {
        public OnlySearch()
        {
            InitializeComponent();
        }
        int findCutLength = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                
                    TextWork.FindTextBox(ref main.notebox, tbOnlyFind.Text, ref findCutLength, true);
                    Enabled = true;
                    
               
            }
        }

        private void OnlySearch_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            findCutLength++;
        }
    }
}
