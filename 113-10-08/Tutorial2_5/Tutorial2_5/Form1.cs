namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //顯示撲克牌背面
        private void btnshowback_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;　//設定visible屬性為假
            ptxFront.Visible = false;
        }
        //顯示撲克牌正面
        private void btnshowfornt_Click(object sender, EventArgs e)
        {
            ptxFront.Visible = true;
            ptxBack.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
