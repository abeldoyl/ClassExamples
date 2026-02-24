namespace WinFormsExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            CityTextBox.Text = "";
            PhoneTextBox.Text = "";

            UpperCaseRadioButton.Checked = true;

        }

        //Event Handelers Below
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Text = NameTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CityLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpperCaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
    }
}
