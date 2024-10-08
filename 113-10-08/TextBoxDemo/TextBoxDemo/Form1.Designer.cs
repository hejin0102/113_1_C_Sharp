namespace TextBoxDemo
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(27, 195);
            label2.Name = "label2";
            label2.Size = new Size(186, 41);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(27, 334);
            label3.Name = "label3";
            label3.Size = new Size(177, 41);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 24F);
            button1.Location = new Point(235, 434);
            button1.Name = "button1";
            button1.Size = new Size(286, 61);
            button1.TabIndex = 3;
            button1.Text = "Comfirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Microsoft JhengHei UI", 24F);
            textBoxFirstName.Location = new Point(344, 40);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(160, 48);
            textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Microsoft JhengHei UI", 24F);
            textBoxLastName.Location = new Point(344, 195);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(160, 48);
            textBoxLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(344, 334);
            label4.Name = "label4";
            label4.Size = new Size(160, 41);
            label4.TabIndex = 7;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(label4);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label4;
    }
}
