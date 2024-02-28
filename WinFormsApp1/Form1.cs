namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(txtNum1.Text);
            int num2 = Int32.Parse(txtNum2.Text);
            int num3 = num1 + num2;

            lblSum.Text = num3.ToString();


        }
    }
}
