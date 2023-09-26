namespace SentenceBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_word_to_text_box(string s)
        {
            textBox.Text += s ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text= string.Empty;
        }

        private void ACap_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(ACap.Text);
        }

        private void ALow_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(ALow.Text);

        }

        private void AnCap_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(AnCap.Text);

        }

        private void bicycle_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(bicycle.Text);
        }

        private void dot_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(dot.Text);
        }

        private void drove_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(drove.Text);

        }

        private void laughedAt_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(laughedAt.Text);

        }

        private void spokeTo_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(spokeTo.Text);

        }

        private void exec_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(exec.Text);

        }

        private void small_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(small.Text);

        }

        private void strange_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(strange.Text);

        }

        private void car_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(car.Text);

        }

        private void cat_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(cat.Text);

        }

        private void theLow_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(theLow.Text);

        }

        private void TheCap_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(TheCap.Text);

        }

        private void anLow_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(anLow.Text);

        }

        private void big_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(big.Text);

        }

        private void beautiful_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(beautiful.Text);

        }

        private void dog_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(dog.Text);

        }

        private void woman_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(woman.Text);

        }

        private void man_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(man.Text);

        }

        private void rode_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(rode.Text);

        }

        private void space_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(" ");

        }

        private void lookedAt_Click(object sender, EventArgs e)
        {
            add_word_to_text_box(lookedAt.Text);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}