namespace FactorialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(input.Text);
            int res = 1;
            result.Text = input.Text + "! = ";
            for (int i = 1; i <= num; i++)
            {
                res *= i;
                if(i == num)
                {
                    result.Text += i.ToString() ;
                }
                else
                {
                    result.Text += i.ToString() + " X ";
                }
            }

            result.Text += " = " + res.ToString();
            result.Visible = true;

        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void input_Click(object sender, EventArgs e)
        {
            result.Visible = false;
            result.Text = string.Empty;
        }
    }
}