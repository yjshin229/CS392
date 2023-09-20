using AngouriMath;
using AngouriMath.Extensions;
using System.Data;
using System.Xml.Serialization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool res = false;

        private void button1_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button0.Text;
        }
        private void button_dot_Click(object sender, EventArgs e)
        {
            checkResult();
            if(input.Text.Length == 0)
            {
                input.Text = input.Text + "0" + button_dot.Text;
            }
            else
            {
            input.Text = input.Text + button_dot.Text;
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            checkResult();
            if (input.Text.Length != 0)
            {
                input.Text = input.Text + button_add.Text;
            }
            
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            checkResult();
            if (input.Text.Length != 0)
            {
                input.Text = input.Text + button_mul.Text;
            }
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            checkResult();
            input.Text = input.Text + button_sub.Text;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            checkResult();
            if (input.Text.Length != 0)
            {
                input.Text = input.Text + button_div.Text;
            }
        }

        private void button_clr_Click(object sender, EventArgs e)
        {
            input.Clear();
        }

        private void button_equ_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            if (res || input.Text.Length == 0)
            {
                input.Clear();
                res = false;
            }
            else
            {
                DataTable dt = new DataTable();
                double result = Convert.ToDouble(dt.Compute(input.Text, ""));
                input.Text = result.ToString();

                res = true;
            }
            
        }

        private void checkResult()
        {
            if (res)
            {
                input.Clear();
                res = false;   
            }

        }


        
    }
}