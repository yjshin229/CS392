using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms.VisualStyles;

namespace AdultBMICalculator
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

        private void metric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            english.Enabled = true;
            metric.Enabled = false;
            h1.Text = "Meters";
            h2.Text = "Centimeters";
            w.Text = "Kilograms";
        }

        private void english_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            english.Enabled = false;
            metric.Enabled = true;
            h1.Text = "Feet";
            h2.Text = "Inches";
            w.Text = "Pounds";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message;
            if (!english.Enabled)
            {
                int height = Int32.Parse(textBox1.Text) * 12 + Int32.Parse(textBox2.Text);
                message = calculate_BMI(height, Int32.Parse(textBox3.Text));

            }
            else
            {
                double height = double.Parse(textBox1.Text)  + double.Parse(textBox2.Text) / 100;
                message = calculate_BMI(height, Int32.Parse(textBox3.Text));
            }
            MessageBox.Show(message);
        }

        private String calculate_BMI(double height, int weight)
        {
            double BMI;
            string retVal = "";
            if (!english.Enabled)
            {
                BMI = 703 * weight / Math.Pow(height, 2);
            }
            else
            {
                BMI = weight / Math.Pow(height, 2);
            }

            switch (BMI)
            {
                case < 18.5:
                    retVal = "Underweight";
                    break;
                case < 24.9:
                    retVal = "Healthyweight";
                    break;
                case < 29.9:
                    retVal = "Overweight";
                    break;
                case > 30:
                    retVal = "Obesity";
                    break;
            }

            return retVal;
        }

    
    }
}