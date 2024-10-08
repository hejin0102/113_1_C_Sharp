namespace Tutorial2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ptxFront = new PictureBox();
            ptxBack = new PictureBox();
            btnshowback = new Button();
            btnshowfornt = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxFront).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            SuspendLayout();
            // 
            // ptxFront
            // 
            ptxFront.Image = (Image)resources.GetObject("ptxFront.Image");
            ptxFront.Location = new Point(297, 43);
            ptxFront.Name = "ptxFront";
            ptxFront.Size = new Size(148, 210);
            ptxFront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxFront.TabIndex = 1;
            ptxFront.TabStop = false;
            ptxFront.Visible = false;
            // 
            // ptxBack
            // 
            ptxBack.Image = (Image)resources.GetObject("ptxBack.Image");
            ptxBack.Location = new Point(12, 43);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(153, 210);
            ptxBack.SizeMode = PictureBoxSizeMode.Zoom;
            ptxBack.TabIndex = 2;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            // 
            // btnshowback
            // 
            btnshowback.Font = new Font("Microsoft JhengHei UI", 24F);
            btnshowback.Location = new Point(12, 288);
            btnshowback.Name = "btnshowback";
            btnshowback.Size = new Size(153, 74);
            btnshowback.TabIndex = 3;
            btnshowback.Text = "背面";
            btnshowback.UseVisualStyleBackColor = true;
            btnshowback.Click += btnshowback_Click;
            // 
            // btnshowfornt
            // 
            btnshowfornt.Font = new Font("Microsoft JhengHei UI", 24F);
            btnshowfornt.Location = new Point(297, 288);
            btnshowfornt.Name = "btnshowfornt";
            btnshowfornt.Size = new Size(148, 74);
            btnshowfornt.TabIndex = 4;
            btnshowfornt.Text = "正面";
            btnshowfornt.UseVisualStyleBackColor = true;
            btnshowfornt.Click += btnshowfornt_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 24F);
            btnExit.Location = new Point(49, 392);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(363, 107);
            btnExit.TabIndex = 5;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 638);
            Controls.Add(btnExit);
            Controls.Add(btnshowfornt);
            Controls.Add(btnshowback);
            Controls.Add(ptxBack);
            Controls.Add(ptxFront);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxFront).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxFront;
        private PictureBox ptxBack;
        private Button btnshowback;
        private Button btnshowfornt;
        private Button btnExit;
    }
}
