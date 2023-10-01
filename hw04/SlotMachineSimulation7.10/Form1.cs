using System.Globalization;

namespace SlotMachineSimulation7._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] Get_Three_Random()
        {
            int[] result = new int[3];
            Random rand = new Random();
            result[0] = rand.Next(4);
            result[1] = rand.Next(4);
            result[2] = rand.Next(4);
            return result;
        }

        private int Check_Win(int[] arr)
        {
            int result = 0;
            int current = 5;
            foreach (int i in arr)
            {
                if (i == 0)
                {
                    current = i;
                    result++;
                }
                else
                {
                    if (current == i)
                    {
                        result++;
                    }
                    else
                    {
                        current = i;
                        result = 1;
                    }
                }
            }
            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inserted_amount.Text))
            {
                MessageBox.Show("Put your bid to play", "Error");
                return;
            }
            int[] three_random_num = Get_Three_Random();
            int match = Check_Win(three_random_num);
            decimal inserted = decimal.Parse(inserted_amount.Text);
            pictureBox1.Image = imageList1.Images[three_random_num[0]];
            pictureBox2.Image = imageList1.Images[three_random_num[1]];
            pictureBox3.Image = imageList1.Images[three_random_num[2]];

            switch (match)
            {
                case 1:
                    won_text.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                    won_text.ForeColor = Color.Red;
                    break;
                case 2:
                    won_text.Text = (inserted*2).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                    won_text.ForeColor= Color.Yellow;
                    break;
                case 3:
                    won_text.Text = (inserted * 3).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                    won_text.ForeColor = Color.Yellow;
                    break;
                default:
                    break;

            }

        }   
    }
}