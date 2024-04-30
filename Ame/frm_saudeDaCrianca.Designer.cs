namespace Ame
{
    partial class frm_P1
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
            lbl_1 = new Label();
            lbl_2 = new Label();
            txtBox1 = new TextBox();
            txtBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Location = new Point(46, 46);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(224, 15);
            lbl_1.TabIndex = 0;
            lbl_1.Text = "1- Quando foi a última visita ao pediatra?";
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Location = new Point(46, 95);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(264, 15);
            lbl_2.TabIndex = 1;
            lbl_2.Text = "2- O que o pediatra diz sobre a saúde da criança?";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(46, 64);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(128, 23);
            txtBox1.TabIndex = 2;
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(46, 113);
            txtBox3.Multiline = true;
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(697, 126);
            txtBox3.TabIndex = 3;
            txtBox3.TextChanged += txb_sobreSaude_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(665, 415);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 4;
            button1.Text = "Próximo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm_P1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBox3);
            Controls.Add(txtBox1);
            Controls.Add(lbl_2);
            Controls.Add(lbl_1);
            Name = "frm_P1";
            Text = "Saúde da criança";
            Load += frm_P1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_1;
        private Label lbl_2;
        private TextBox txtBox1;
        private TextBox txtBox3;
        private Button button1;
    }
}