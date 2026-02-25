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
            NameTextBox.BackColor = Color.LightGray;
            AgeTextBox.Text = "";
            CityTextBox.Text = "";
            PhoneTextBox.Text = "";

            UpperCaseRadioButton.Checked = true;
            SubmitButton.Enabled = false;

        }

        private void ValidateFields()
        {
            string message = "";
            if (PhoneTextBox.Text == "")
            {
                message = ("Phone is required\n") + message;
                PhoneTextBox.Focus();
            }

            if (CityTextBox.Text == "")
            {
                message = ("City is required\n") + message;
                CityTextBox.Focus();
            }

            if (AgeTextBox.Text =="")
            {
                message = ("Age is required\n") + message;
                AgeTextBox.Focus();
            }

            if (NameTextBox.Text == "")
            {
                message = ("Name is required\n") + message;
                NameTextBox.Focus();
            }

            if (message != "")
            {
                MessageBox.Show(message);
            }
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
            ValidateFields();
            //this.Text = NameTextBox.Text;
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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(NameTextBox.Text != "")
            {
                NameTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
            }
            else
            {
                NameTextBox.BackColor = Color.LightGray;
                SubmitButton.Enabled = false;
            }

        }
    }
}
