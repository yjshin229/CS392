using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMICalculatorDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        decimal db_height;
        decimal db_weight;
        private void Form1_Load(object sender, EventArgs e)
        {
            //change datasource to your server name
            string ConnString = "Data Source = DESKTOP-1OAACRD;Initial Catalog = BMI Database;Integrated Security = true";
            conn = new SqlConnection(ConnString);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
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
            textBoxBMI.Text = bmi.ToString("F");
            db_height = height;
            db_weight = weight;
            numericWeight.Value = 0;
            numericHeight.Value = 0;
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            if (textBoxName.Text == "" || textBoxBMI.Text == "")
            {
                MessageBox.Show("Please enter your name and calculate your BMI before adding to DB.");
                return;
            }
           
            string query = $"INSERT INTO EnhancedBMI(Name,Gender,Weight,Height,EnhancedBMI,DateTimeStamp) VALUES ('{textBoxName.Text}','{comboBoxGender.Text}','{db_weight}','{db_height}','{textBoxBMI.Text}','{currentDateTime.ToString(format)}')";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added to Database");
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Error in Connection {0}", ex.Message));
                conn.Close();
            }
            finally
            {
                db_height = 0;
                db_weight = 0;
            }
        }

    }
}
