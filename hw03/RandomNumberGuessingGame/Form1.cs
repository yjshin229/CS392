namespace RandomNumberGuessingGame
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int counter = 0;
        int randomNumber = 0;
        public Form1()
        {
            InitializeComponent();
            get_random_number();

        }

        private void get_random_number()
        {
            randomNumber = rand.Next(500);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void guess_Click(object sender, EventArgs e)
        {
            counter += 1;
            if (Int32.Parse(textBox1.Text) > randomNumber)
            {
                hint.Visible = true;
                hint.ForeColor = Color.Red;
                hint.Text = "Too high!";
            }
            else if (Int32.Parse(textBox1.Text) < randomNumber)
            {
                hint.Visible = true;
                hint.ForeColor = Color.Blue;
                hint.Text = "Too low!";
            }
            else
            {
                congrats.Visible = true;
                numGuess.Visible = true;
                numGuess.Text= counter.ToString() + " guesses!";
                again.Visible = true;
                guess.Enabled = false;
            }
        }

        private void again_Click(object sender, EventArgs e)
        {
            get_random_number();
            congrats.Visible = false;
            guess.Enabled = true;
            again.Visible = false;
            numGuess.Visible= false;
            numGuess.Text = string.Empty;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}