namespace LABA_2_TextEditor
{
    partial class Найти
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbFind = new TextBox();
            tbReplace = new TextBox();
            cbReg = new CheckBox();
            btFind = new Button();
            btReplace = new Button();
            btReplaceAll = new Button();
            btCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 190);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Найти";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 195);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Заменить на";
            // 
            // tbFind
            // 
            tbFind.Location = new Point(473, 136);
            tbFind.Name = "tbFind";
            tbFind.Size = new Size(125, 27);
            tbFind.TabIndex = 2;
            tbFind.TextChanged += tbFind_TextChanged;
            // 
            // tbReplace
            // 
            tbReplace.Location = new Point(458, 72);
            tbReplace.Name = "tbReplace";
            tbReplace.Size = new Size(125, 27);
            tbReplace.TabIndex = 3;
            // 
            // cbReg
            // 
            cbReg.AutoSize = true;
            cbReg.Location = new Point(227, 92);
            cbReg.Name = "cbReg";
            cbReg.Size = new Size(162, 24);
            cbReg.TabIndex = 4;
            cbReg.Text = "Учитывать регистр";
            cbReg.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            btFind.Location = new Point(138, 366);
            btFind.Name = "btFind";
            btFind.Size = new Size(94, 29);
            btFind.TabIndex = 5;
            btFind.Text = "Найти далее";
            btFind.UseVisualStyleBackColor = true;
            // 
            // btReplace
            // 
            btReplace.Location = new Point(412, 332);
            btReplace.Name = "btReplace";
            btReplace.Size = new Size(94, 29);
            btReplace.TabIndex = 6;
            btReplace.Text = "Заменить";
            btReplace.UseVisualStyleBackColor = true;
            // 
            // btReplaceAll
            // 
            btReplaceAll.Location = new Point(534, 378);
            btReplaceAll.Name = "btReplaceAll";
            btReplaceAll.Size = new Size(131, 29);
            btReplaceAll.TabIndex = 7;
            btReplaceAll.Text = "Заменить все";
            btReplaceAll.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(212, 279);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 29);
            btCancel.TabIndex = 8;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // Найти
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancel);
            Controls.Add(btReplaceAll);
            Controls.Add(btReplace);
            Controls.Add(btFind);
            Controls.Add(cbReg);
            Controls.Add(tbReplace);
            Controls.Add(tbFind);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Найти";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "SearchForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbFind;
        private TextBox tbReplace;
        private CheckBox cbReg;
        private Button btFind;
        private Button btReplace;
        private Button btReplaceAll;
        private Button btCancel;
    }
}