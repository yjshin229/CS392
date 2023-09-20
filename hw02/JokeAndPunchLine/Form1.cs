namespace JokeAndPunchLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            joke.Visible = true;
        }
    }
}