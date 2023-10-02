namespace _6._4JoesAutomative
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
            try
            {
                return decimal.Parse(tbParts.Text);
            }
            catch
            {
                return 0m;
            }
        }

        private decimal LaborCharges()
        {
            try
            {
                return LABOR_COST * decimal.Parse(tbLabor.Text);
            }
            catch
            {
                return 0m;
            }
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            tbServSum.Text = ServiceCharges().ToString("c");
            tbPartsSum.Text = PartsCharges().ToString("c");
            tbTax.Text = TaxCharges().ToString("c");
            tbTotal.Text = TotalCharges().ToString("c");
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