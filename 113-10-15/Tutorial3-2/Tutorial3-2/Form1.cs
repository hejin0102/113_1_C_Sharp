namespace Tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double Kms;
            double liters;
            double average;

            Kms = double.Parse(txbKm.Text);
            liters = double.Parse(txbLiter.Text);
            average = Kms / liters;

            lblshow.Text = average.ToString("n3");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
