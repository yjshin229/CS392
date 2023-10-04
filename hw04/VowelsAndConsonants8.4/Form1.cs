namespace VowelsAndConsonants8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private int vowelCounter(String word)
        {
            int counter = 0;
            int len = word.Length;

            for (int i = 0; i < len; i++)
            {

                if ((word[i] >= 'a' && word[i] <= 'z') ||
                 (word[i] >= 'A' && word[i] <= 'Z'))
                {

                    if (word[i] == 'a' || word[i] == 'e' ||
                        word[i] == 'i' || word[i] == 'o' ||
                        word[i] == 'u' || word[i] == 'A' ||
                        word[i] == 'E' || word[i] == 'I' ||
                        word[i] == 'O' || word[i] == 'U')
                    {
                        counter++;
                    }

                }

            }
            return counter;
        }

        private int consonantCounter(String word)
        {
            int counter = 0;
            int len = word.Length;

            for (int i = 0; i < len; i++)
            {

                if ((word[i] >= 'a' && word[i] <= 'z') ||
                 (word[i] >= 'A' && word[i] <= 'Z'))
                {

                    if (word[i] != 'a' && word[i] != 'e' &&
                        word[i] != 'i' && word[i] != 'o' &&
                        word[i] != 'u' && word[i] != 'A' &&
                        word[i] != 'E' && word[i] != 'I' &&
                        word[i] != 'O' && word[i] != 'U')
                    {
                        counter++;
                    }

                }

            }
            return counter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String wordToBeCounted = textBox1.Text;
            int vowels = vowelCounter(wordToBeCounted);
            int consonants = consonantCounter(wordToBeCounted);

            label2.Text = "Your String has this many consonants: " + consonants.ToString();
            label3.Text = "Your String has this many vowels: " + vowels.ToString();

        }
    }
}