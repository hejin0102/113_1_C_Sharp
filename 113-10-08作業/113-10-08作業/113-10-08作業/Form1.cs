namespace _113_10_08作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblshow.Text = "方塊8";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblshow.Text = "梅花2";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblshow.Text = "黑桃K";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblshow.Text = "黑桃A";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblshow.Text = "黑桃J";
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}