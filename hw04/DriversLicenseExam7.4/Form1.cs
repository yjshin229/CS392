namespace DriversLicenseExam7._4
{
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly String[] answer = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
        String[] submitted_txt = new string[20];
        String file_path;

        private Boolean Validate_File(String path)
        {
            int count = 0;
            using StreamReader sr = new StreamReader(path);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, @"^[a-zA-Z]+$"))
                {
                    count++;
                }
                else
                {
                    MessageBox.Show("The text file should only contain alphabets.");
                    return false;
                }

            }
            sr.Close();
            if (count != 20)
            {
                MessageBox.Show("Invalid number of answers!\nPlease try again.");
                return false;
            }
            else
            {
                return true;

            }
        }

        private void Store_Value(String path)
        {
            int index = 0;
            using StreamReader sr = new StreamReader(path);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                submitted_txt[index] = (line.ToUpper());
                index++;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            correct_count.Visible = false;
            incorrect_count.Visible = false;
            incorrect_answers.Visible = false;
            incorrect_questions.Visible = false;
            result_text.ForeColor = Color.Black;
            result_text.Text = "Upload A Text File Please.";
            Array.Clear(submitted_txt);
            file_path = "";
            path_text.Text = "";

            //open text file
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Text Documents | *.txt",
                Multiselect = false,
                Title = "Textfiles only!"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                file_path = openFile.FileName;
                if (Validate_File(file_path))
                {
                    path_text.Text = Path.GetFileName(file_path);
                    Store_Value(file_path);
                }
                else
                {

                }
            }
        }

        private void result_button_Click(object sender, EventArgs e)
        {

            if (submitted_txt == null)
            {
                MessageBox.Show("Upload your text file please!");
                return;
            }
            int c_count = 0;
            int ic_count = 0;
            List<String> incorrect_list = new List<String>(); ;

            for (int i = 0; i < 20; i++)
            {
                if (answer[i].Equals(submitted_txt[i]))
                {
                    c_count++;
                }
                else
                {
                    ic_count++;
                    incorrect_list.Add(i.ToString());
                }
            }

            for (var i = 0; i < incorrect_list.Count; i++)
            {
                if (i != incorrect_list.Count - 1)
                {
                    incorrect_answers.Text += incorrect_list[i] + ", ";
                }
                else
                {
                    incorrect_answers.Text += incorrect_list[i];
                }
            }
            correct_count.Text = c_count.ToString();
            incorrect_count.Text = ic_count.ToString();
            result_text.Text = c_count >= 15 ? "PASSED!" : "FAILED";
            result_text.ForeColor = c_count >= 15 ? Color.Green : Color.Red;
            correct_count.Visible = true;
            incorrect_count.Visible = true;
            incorrect_answers.Visible = ic_count > 0;
            incorrect_questions.Visible = ic_count > 0;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incorrect_answers_Click(object sender, EventArgs e)
        {

        }
    }
}