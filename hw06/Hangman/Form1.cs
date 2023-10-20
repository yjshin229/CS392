using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        int maxTries = 6;
        int currentTries = 0;

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

        private void Alphabet(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
        }
    }
}
