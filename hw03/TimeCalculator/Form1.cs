namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int seconds = (Int32.Parse(inputSec.Text));
            if (seconds < 60)
            {
                output.Text = inputSec.Text + " second(s)";
            }
            else if (seconds >= 60 && seconds < 3600)
            {
                output.Text =  (seconds / 60).ToString() + " minute(s)";
            }
            else if (seconds >= 3600 && seconds < 86400)
            {
                output.Text = (seconds / 3600).ToString() + " hour(s)";
            }
            else
            {
                output.Text = (seconds / 86400).ToString() + " day(s)";
            }
        }

        private void inputSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}