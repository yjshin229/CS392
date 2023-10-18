using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListManipulator_14._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();

            string[] lines = File.ReadAllLines("random.txt");
            foreach (string line in lines)
            {
                if (int.TryParse(line, out int number))
                {
                    numbers.Add(number);
                }
            }
            numbers.RemoveAll(n => n < 0);
            List<int> filteredNumbers = numbers.FindAll(n => n >= 1 && n <= 10);
            ListBoxNumbers.DataSource = filteredNumbers;
        }
    }
}
