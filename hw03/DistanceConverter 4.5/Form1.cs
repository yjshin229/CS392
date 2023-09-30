namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void fromList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fromList.SelectedIndex == 0)
            {
                if (toList.SelectedIndex == 1)
                {
                    result.Text = (decimal.Parse(inputDis.Text) / 12).ToString();
                }
                else if (toList.SelectedIndex == 2)
                {
                    result.Text = (decimal.Parse(inputDis.Text) / 36).ToString();
                }
                else
                {
                    result.Text = inputDis.Text;
                }

            }
            else if (fromList.SelectedIndex == 1)
            {
                if (toList.SelectedIndex == 0)
                {
                    result.Text = (decimal.Parse(inputDis.Text) * 12).ToString();
                }
                else if (toList.SelectedIndex == 2)
                {
                    result.Text = (decimal.Parse(inputDis.Text) / 3).ToString();
                }
                else
                {
                    result.Text = inputDis.Text;
                }
            }
            else
            {
                if (toList.SelectedIndex == 0)
                {
                    result.Text = (decimal.Parse(inputDis.Text) * 36).ToString();
                }
                else if (toList.SelectedIndex == 1)
                {
                    result.Text = (decimal.Parse(inputDis.Text) * 3).ToString();
                }
                else
                {
                    result.Text = inputDis.Text;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}