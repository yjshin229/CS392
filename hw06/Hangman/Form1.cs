using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        string answer = "";
        string hint = "";
        List<string> lettersUsed = new List<string>();
        List<string> words_used = new List<string>();
        int maxTries = 6;
        int currentTries = 0;
        string underscoreWord = "";
        List<Button> usedButtons = new List<Button>();


        Dictionary<string, string[]> word_bank = new Dictionary<string, string[]>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fruit = { "apple", "banana", "kiwi", "grape", "orange" };
            string[] country = { "switzerland", "sweden", "china", "canada", "Italy" };
            string[] animal = { "gorilla", "sloth", "giraffe", "anteater", "eagle" };
            string[] color = { "purple", "skyblue", "babypink", "Turquoise", "Maroon" };
            string[] sports = { "basketball", "volleyball", "badminton", "gymnastics", "icehockey" };

            word_bank.Add("fruit", fruit);
            word_bank.Add("country", country);
            word_bank.Add("animal", animal);
            word_bank.Add("color", color);
            word_bank.Add("sports", sports);

        }

        private void Alphabet(object sender, EventArgs e )
        {
            Button btn = (Button)sender;
            guessLetter(btn.Text);
            
            btn.Visible = false;
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool newWord = false;

            while (!newWord) {
                Random rnd = new Random();
                int firstInt = rnd.Next(5);
                int secondInt = rnd.Next(5);

                hint = word_bank.ElementAt(firstInt).Key;
                answer = word_bank.ElementAt(firstInt).Value[secondInt];

                bool exists = false;
                foreach( string word in words_used){
                    if (word.Contains(answer)) {
                        exists = true;
                        break;
                    }
                }
                if (!exists) {
                    newWord = true;
                }
            }

            hintText.Text = hint;
            initialize_game();
        }

        private void generate_Underscores(string word)
        {
            var sb = new StringBuilder();
            foreach (var item in word)
            {
                sb.Append("-");
                
            }
            underscoreWord = sb.ToString();
        }

        private void initialize_game()
        {
            currentTries = 0;
            generate_Underscores(answer);
            underscoreText.Text = underscoreWord;
            hangmanPicture.Image = getHangmanImage();
            makeButtonsVisible(startButton);



        }

        private void makeButtonsVisible(object sender)
        {
            foreach(Button btn in usedButtons)
            {
                btn.Visible = true;
            }
        }

        private Bitmap getHangmanImage()
        {
            switch (currentTries)
            {
                case 0:
                    return Properties.Resources.hang0;
                case 1:
                    return Properties.Resources.hang1;
                case 2:
                    return Properties.Resources.hang2;
                case 3:
                    return Properties.Resources.hang3;
                case 4:
                     return Properties.Resources.hang4;
                case 5:
                    return Properties.Resources.hang5;
                case 6:
                    return Properties.Resources.hang6;
                default:
                    return Properties.Resources.hang6;
            }
        }

        private void guessLetter(string letter)
        {
            lettersUsed.Add(letter);
            List<int> indexes = new List<int>();

            foreach (var s in answer)
            {
                if (s.Equals(letter))
                {
                    indexes.Add(letter.IndexOf(s));
                }
            }

            var finalUnderscoreWord = underscoreWord;
            foreach (var index in indexes)
            {
                var sb = new StringBuilder(finalUnderscoreWord);
                sb[index] = char.Parse(letter);
            }
            if (indexes.Count == 0)
            {
                currentTries++;
                hangmanPicture.Image = getHangmanImage();
            }
            underscoreWord = finalUnderscoreWord;
            hangmanPicture.Image = getHangmanImage();

        }
    }
}
