namespace RockPaperScissors_6._9
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private string computerChoice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            DetermineWinner("Rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            DetermineWinner("Paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            DetermineWinner("Scissors");
        }

        private string GetComputerChoice()
        {
            int choice = random.Next(1, 4);

            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                default:
                    return "Unknown";
            }
        }

        private void DetermineWinner(string userChoice)
        {
            computerChoice = GetComputerChoice();
            lblComputerChoice.Text = $"Computer Chose: {computerChoice}";

            if (userChoice == computerChoice)
            {
                lblResult.Text = "It's a tie. Play again!";
                return;
            }

            if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                (userChoice == "Scissors" && computerChoice == "Paper") ||
                (userChoice == "Paper" && computerChoice == "Rock"))
            {
                lblResult.Text = $"You Win! {userChoice} beats {computerChoice}.";
            }
            else
            {
                lblResult.Text = $"You Lose! {computerChoice} beats {userChoice}.";
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}