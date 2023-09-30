using System.Globalization;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (inputA.Text.Length == 0 && inputB.Text.Length == 0 && inputC.Text.Length == 0)
            {
                total.Text = "";
            }
            else
            {
                int a = inputA.Text.Length == 0 ? 0 : (Int32.Parse(inputA.Text) * 15);
                int b = inputB.Text.Length == 0 ? 0 : (Int32.Parse(inputB.Text) * 12);
                int c = inputC.Text.Length == 0 ? 0 : (Int32.Parse(inputC.Text) * 9);

                revA.Text = a.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                revB.Text = b.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                revC.Text = c.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

                int totalRev = a + b + c;
                total.Text = totalRev.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputA.Text = string.Empty;
            inputB.Text = string.Empty;
            inputC.Text = string.Empty;
            revA.Text = string.Empty ;
            revB.Text = string.Empty;
            revC.Text = string.Empty ;
            revC.Text = string.Empty ;
            total.Text = string.Empty ;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputA_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputC_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputB_TextChanged(object sender, EventArgs e)
        {
        }

        private void inputC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}