using System;
using System.Globalization;
using System.Threading;

namespace JoesAutomative_6._4
{
    public partial class Form1 : Form
    {
        private const decimal OIL_CHANGE = 50.00m;
        private const decimal LUBE_JOB = 40.00m;
        private const decimal RADIATOR_FLUSH = 100.00m;
        private const decimal TRANSMISSION_FLUSH = 120.00m;
        private const decimal INSPECTION = 35.00m;
        private const decimal MUFFLER_REPLACEMENT = 150.00m;
        private const decimal TIRE_ROTATION = 25.00m;
        private const decimal LABOR_COST = 75.00m;
        private const decimal TAX_RATE_ON_PARTS = 0.07m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private decimal OilChangeCharges()
        {
            return cbOilChange.Checked ? OIL_CHANGE : 0m;
        }

        private decimal LubeCharges()
        {
            return cbLubeJob.Checked ? LUBE_JOB : 0m;
        }

        private decimal RadiatorFlushCharges()
        {
            return cbRadFlush.Checked ? RADIATOR_FLUSH : 0m;
        }

        private decimal TransmissionFlushCharges()
        {
            return cbTransFlush.Checked ? TRANSMISSION_FLUSH : 0m;
        }

        private decimal InspectionCharges()
        {
            return cbInspection.Checked ? INSPECTION : 0m;
        }

        private decimal MufflerCharges()
        {
            return cbRepMuff.Checked ? MUFFLER_REPLACEMENT : 0m;
        }

        private decimal TireRotationCharges()
        {
            return cbTireRot.Checked ? TIRE_ROTATION : 0m;
        }

        private decimal PartsCharges()
        {
            return string.IsNullOrEmpty(tbParts.Text) ? 0m : decimal.Parse(tbParts.Text);
        }

        private decimal LaborCharges()
        {
            return string.IsNullOrEmpty(tbLabor.Text) ? 0m : LABOR_COST * decimal.Parse(tbLabor.Text);
        }


        private decimal TaxCharges()
        {
            return PartsCharges() * TAX_RATE_ON_PARTS;
        }

        private decimal TotalCharges()
        {
            return OilChangeCharges() + LubeCharges() + RadiatorFlushCharges() +
                   TransmissionFlushCharges() + InspectionCharges() + MufflerCharges() +
                   TireRotationCharges() + PartsCharges() + LaborCharges() + TaxCharges();
        }
        private decimal ServiceCharges()
        {
            return OilChangeCharges() + LubeCharges() + RadiatorFlushCharges() +
                   TransmissionFlushCharges() + InspectionCharges() + MufflerCharges() +
                   TireRotationCharges() + LaborCharges();
        }
        private bool ValidateInput()
        {
            return (string.IsNullOrEmpty(tbParts.Text) || int.TryParse(tbParts.Text, out _)) &&
                   (string.IsNullOrEmpty(tbLabor.Text) || int.TryParse(tbLabor.Text, out _));
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Please enter valid integer values.");
                btnClear_Click(sender, e);
                return;
            }

            tbServSum.Text = ServiceCharges().ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            tbPartsSum.Text = PartsCharges().ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            tbTax.Text = TaxCharges().ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            tbTotal.Text = TotalCharges().ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
  
            cbOilChange.Checked = false;
            cbLubeJob.Checked = false;
            cbRadFlush.Checked = false;
            cbTransFlush.Checked = false;
            cbInspection.Checked = false;
            cbRepMuff.Checked = false;
            cbTireRot.Checked = false;

            tbLabor.Clear();
            tbParts.Clear();
            tbTax.Clear();
            tbPartsSum.Clear();
            tbServSum.Clear();
            tbTotal.Clear();  
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}