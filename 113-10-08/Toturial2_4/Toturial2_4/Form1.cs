namespace Toturial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblshow.Text = "芬蘭";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblshow.Text = "法國";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblshow.Text = "德國";
        }
    }
}
