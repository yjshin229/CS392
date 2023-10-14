using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
        //    //string ConnString = "Data Source = localhost, Initial Catalog = EnhancedBMI, Integrated Security = true";
        //    //con = new SqlConnection(ConnString);
        //    //cmd = new SqlCommand();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal weight = numericWeight.Value;
            decimal height = numericHeight.Value;

            if (weight == 0 || height == 0 || comboBoxGender.Text == null)
            {
                MessageBox.Show("Please enter a value into every box.");
                return;
            }
            decimal bmi = (weight * 703) / (height * height);
            textBoxBMI.Text = bmi.ToString();
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxBMI.Text == "")
            {
                MessageBox.Show("Please enter your name and calculate your BMI before adding to DB.");
                return;
            }
            string ConnString = "Data Source = LIVSLAPTOP\\SQLEXPRESS;" + "Initial Catalog = BMI Database;" + "Integrated Security = true";
            con = new SqlConnection();
            con.ConnectionString = ConnString;
            //cmd = new SqlCommand();
            string query = $"insert into EnhancedBMI values ('{textBoxName.Text}','{comboBoxGender.Text}','{numericWeight.Value.ToString()}','{numericHeight.Value.ToString()}','{textBoxBMI.Text}')";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
