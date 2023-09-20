namespace HeadsOrTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void head_button_Click(object sender, EventArgs e)
        {
            head_picture.Visible = true;
            tail_picture.Visible = false;
        }
        private void tail_button_Click(object sender, EventArgs e)
        {
            head_picture.Visible = false;
            tail_picture.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}