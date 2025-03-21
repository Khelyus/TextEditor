namespace LABA_2_TextEditor
{
    partial class GoToForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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


     /*   private void butGo_Click(object sender, EventArgs e) // Кнопка "Перейти к строке"
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                int lineNumber = Convert.ToInt32(tbLineNum.Text);
                if (lineNumber > 0 && lineNumber <= main.textBox1.Lines.Count())
                {
                    main.textBox1.SelectionStart = main.textBox1.GetFirstCharIndexFromLine(Convert.ToInt32(tbLineNum.Text) - 1);
                    main.textBox1.ScrollToCaret();
                    this.Close();
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e) // Кнопка "Отменить"
        {
            this.Close();
        }*/
    

#region Windows Form Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
        {
            tbLineNum = new NumericUpDown();
            butGo = new Button();
            butCancel = new Button();
            labGo = new Label();
            tbGo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tbLineNum).BeginInit();
            SuspendLayout();
            // 
            // tbLineNum
            // 
            tbLineNum.Location = new Point(91, 64);
            tbLineNum.Name = "tbLineNum";
            tbLineNum.Size = new Size(150, 27);
            tbLineNum.TabIndex = 0;
            // 
            // butGo
            // 
            butGo.Location = new Point(164, 178);
            butGo.Name = "butGo";
            butGo.Size = new Size(94, 29);
            butGo.TabIndex = 1;
            butGo.Text = "Перейти";
            butGo.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            butCancel.Location = new Point(290, 178);
            butCancel.Name = "butCancel";
            butCancel.Size = new Size(94, 29);
            butCancel.TabIndex = 2;
            butCancel.Text = "Отменить";
            butCancel.UseVisualStyleBackColor = true;
            // 
            // labGo
            // 
            labGo.AutoSize = true;
            labGo.Location = new Point(429, 67);
            labGo.Name = "labGo";
            labGo.Size = new Size(50, 20);
            labGo.TabIndex = 3;
            labGo.Text = "label1";
            // 
            // tbGo
            // 
            tbGo.Location = new Point(275, 64);
            tbGo.Name = "tbGo";
            tbGo.Size = new Size(125, 27);
            tbGo.TabIndex = 4;
            // 
            // GoToForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbGo);
            Controls.Add(labGo);
            Controls.Add(butCancel);
            Controls.Add(butGo);
            Controls.Add(tbLineNum);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GoToForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Перейти";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)tbLineNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public NumericUpDown tbLineNum;
        private Button butGo;
        private Button butCancel;
        private Label labGo;
        public TextBox tbGo;
    }
}