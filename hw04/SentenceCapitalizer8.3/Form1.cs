namespace SentenceCapitalizer8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Capitalize(string s)
        {
            string formattedString = "";

            List<string> endingPunctuation = new List<string>();

            foreach (char value in s)
            {
                if (value == '.' || value == '!' || value == '?')
                {
                    endingPunctuation.Add(value.ToString());
                }
            }

            char[] puncts = { '.', '?', '!' };

            string[] tokens = s.Trim().Split(puncts, StringSplitOptions.RemoveEmptyEntries);

            for (int index = 0; index < tokens.Length; index++)
            {
                tokens[index] = tokens[index].Trim();
                string firstLetter = tokens[index].Substring(0, 1);
                string restOfLetters = tokens[index].Substring(1, tokens[index].Length - 1);

                if (!char.IsUpper(firstLetter[0]))
                {
                    firstLetter = firstLetter.ToUpper();
                    tokens[index] = firstLetter + restOfLetters;
                }
            }

            for (int i = 0; i < tokens.Length; i++)
            {
                formattedString = formattedString + tokens[i] + endingPunctuation[i] + " ";
            }

            formattedString = formattedString.Trim();

            return formattedString;
        }
        private void buttonCapitalize_Click(object sender, EventArgs e)
        {
            string sentence = textBoxInput.Text;
            bool trueSentence = true;
            foreach (char c in sentence)
            {
                if (!(char.IsLetter(c)) && !(char.IsPunctuation(c)) && !(char.IsWhiteSpace(c)))
                {
                    trueSentence = false;
                    break;
                }
            }
            if (sentence.Length >= 1 && sentence != null && trueSentence == true && (sentence.Contains('.') || sentence.Contains('?') || sentence.Contains('!')))
            {

                string newSentence = Capitalize(sentence);
                MessageBox.Show($"Your capitalized sentence:\n{newSentence}");
            }
            else
            {
                MessageBox.Show("Please enter a valid sentence containing only characters, punctuation, and spaces.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
        }
    }
}