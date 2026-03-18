namespace TipAndTaxCalculator
{
    public partial class TipAndTaxCalculatorForm : Form
    {
        public TipAndTaxCalculatorForm()
        {
            InitializeComponent();
            SetDefaults();
        }
        //custom methods-------------------------------------------------------
        void SetDefaults()
        {
            DollarAmountTextBox.Text = "";
            CustomTipTextBox.Text = "";
            SeniorCheckBox.Checked = false;
            StaffCheckBox.Checked = false;
            DisplayTotalLabel.Text = "";
            NoTipRadioButton.Checked = true;
            DollarAmountTextBox.Select();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="thisAmount"></param>
        /// <returns></returns>
        decimal CalculateTip(decimal thisAmount)
        {
            decimal subtotal = 0;
            switch (true)
            {
                case bool when NoTipRadioButton.Checked:
                    subtotal = thisAmount * 0m;
                    break;
                case bool when Tip15RadioButton.Checked:
                    subtotal = thisAmount * 0.15m;
                    break;
                case bool when Tip18RadioButton.Checked:
                    subtotal = thisAmount * 0.18m;
                    break;
                case bool when Tip20RadioButton.Checked:
                    subtotal = thisAmount * 0.20m;
                    break;
                case bool when TipCustomRadioButton.Checked:
                    break;
                default:
                    MessageBox.Show("Hello you FAILED");
                    break;
            }
            return 0.00m;
        }

        //Event Handlers-------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
    }
}
