namespace SecondGradeFlashCard
{
    public partial class addition : Form
    {
        public addition()
        {
            InitializeComponent();
        }

        int[] answer_keys = new int[10];
        int[] first_numbers = new int[10];
        int[] second_numbers = new int[10];
        int[] submitted_answers = new int[10];
        int question_number = 0;

        private int[] Get_Two_Random(String operation)
        {
            int[] ints = new int[2];

            Random random = new Random();

            if (operation == "Add")
            {
                ints[0] = random.Next(10);
                ints[1] = random.Next(10);
            }
            else
            {
                ints[0] = random.Next(10);
                ints[1] = random.Next(10);
                while (ints[0] < ints[1])
                {
                    ints[1] = random.Next(10);   
                }
            }

            return ints;
        }

        private int Calculate_Answer(String operation, int[] arr)
        {
            if (operation == "Add")
            {
                return (arr[0] + arr[1]);
            }
            else
            {
                return (arr[0] - arr[1]);
            }
        }

        private void Generate_Questions(String operation)
        {
            for (int i = 0; i < 10; i++)
            {
                int[] ints = Get_Two_Random(operation);
                int answer = Calculate_Answer(operation, ints);
                first_numbers[i] = ints[0];
                second_numbers[i] = ints[1];
                answer_keys[i] = answer;
            }
        }

        private void Previous_Visible()
        {
            if (question_number != 0)
            {
                Previous_Button.Visible = true;
            }
            Answer_Textbox.Text = submitted_answers[question_number] == 100 ? "" : submitted_answers[question_number].ToString();

        }

        private void Next_Visible()
        {
            if (question_number == 9)
            {
                Next_Button.Text = "Finish";
            }
            else
            {
                Next_Button.Text = "Next";

            }

        }

        private int Get_Score()
        {
            int score = 0;
            for (int i = 0; i < 10; i++)
            {
                if (answer_keys[i] == submitted_answers[i])
                {
                    score++;
                }
            }
            return score;
        }

        private void Initialize_app()
        {
            Addition_Radio.Enabled = true;
            Subtraction_Radio.Enabled = true;
            question_number = 0;
            Question_Number_label.Text = (question_number + 1).ToString();
            Array.Clear(answer_keys);
            Array.Clear(submitted_answers);
            Array.Clear(first_numbers);
            Array.Clear(second_numbers);
            First_Number.Text = "";
            Second_Number.Text = "";
            Operator.Text = "";
            Previous_Visible();
            Next_Visible();
            Next_Button.Visible = false;
            Previous_Button.Visible = false;
            Answer_Textbox.Text = "";
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addition_Radio.Enabled = false;
            Subtraction_Radio.Enabled = false;
            Array.Fill(submitted_answers, 100);
            Next_Button.Visible = true;
            Answer_Textbox.Text = "";

            if (Addition_Radio.Checked)
            {
                Generate_Questions("Add");
                Operator.Text = "+";
                First_Number.Text = first_numbers[question_number].ToString();
                Second_Number.Text = second_numbers[question_number].ToString();

            }
            else
            {
                Generate_Questions("Sub");
                Operator.Text = "-";
                First_Number.Text = first_numbers[question_number].ToString();
                Second_Number.Text = second_numbers[question_number].ToString();
            }
        }


        private void Next_Button_Click(object sender, EventArgs e)
        {

            if (question_number == 9)
            {
                int score = Get_Score();
                MessageBox.Show(String.Format("Your Score: {0}/ 10", score), "Result");
                question_number = 0;
                Previous_Visible();
                Next_Visible();
                Question_Number_label.Text = (question_number + 1).ToString();
                Initialize_app();
            }
            else
            {
                question_number++;
                Previous_Visible();
                Next_Visible();
                Question_Number_label.Text = (question_number + 1).ToString();
                First_Number.Text = first_numbers[question_number].ToString();
                Second_Number.Text = second_numbers[question_number].ToString();
                Answer_Textbox.Text = submitted_answers[question_number] == 100 ? "" : submitted_answers[question_number].ToString();

            }

        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            question_number--;
            Previous_Visible();
            Next_Visible();
            Question_Number_label.Text = (question_number + 1).ToString();
            First_Number.Text = first_numbers[question_number].ToString();
            Second_Number.Text = second_numbers[question_number].ToString();
            Answer_Textbox.Text = submitted_answers[question_number] == 100 ? "" : submitted_answers[question_number].ToString();

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            submitted_answers[question_number] = Int32.Parse(Answer_Textbox.Text);
        }
    }
}