namespace Hellow_Word
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
            btnDisplayMessage = new Button();
            SuspendLayout();
            // 
            // btnDisplayMessage
            // 
            btnDisplayMessage.BackColor = SystemColors.ActiveCaption;
            btnDisplayMessage.Font = new Font("Microsoft JhengHei UI", 20F);
            btnDisplayMessage.ForeColor = SystemColors.ControlText;
            btnDisplayMessage.Location = new Point(198, 215);
            btnDisplayMessage.Name = "btnDisplayMessage";
            btnDisplayMessage.Size = new Size(395, 203);
            btnDisplayMessage.TabIndex = 0;
            btnDisplayMessage.Text = "Display Message";
            btnDisplayMessage.UseVisualStyleBackColor = false;
            btnDisplayMessage.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 772);
            Controls.Add(btnDisplayMessage);
            Name = "Form1";
            Text = "Greeting!";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplayMessage;
    }
}
