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
            NameTextBox.BackColor = Color.LightYellow;
            AgeTextBox.Text = "";
            AgeTextBox.BackColor = Color.LightYellow;
            CityTextBox.Text = "";
            CityTextBox.BackColor = Color.LightYellow;
            PhoneTextBox.Text = "";
            PhoneTextBox.BackColor = Color.LightYellow;

            UpperCaseRadioButton.Checked = true;
            SubmitButton.Enabled = false;

        }

        private bool ValidateFields()
        {
            bool valid = true;
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
                valid = false;
                MessageBox.Show(message);
            }
            return true;
        }

        private void Uppercase()
        {
            if (UpperCaseRadioButton.Checked)
            {
                NameTextBox.Text = NameTextBox.Text.ToUpper();
            }
        }

        private void Reverse()
        {
            if (ReverseRadioButton.Checked)
            {
                NameTextBox.Text = new String (NameTextBox.Text.Reverse().ToArray());
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
            if (ValidateFields())
            {
                //this.Text = NameTextBox.Text;
                Uppercase();
                Reverse();
            }
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
                NameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
            }

        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AgeTextBox.Text != "")
            {
                AgeTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
            }
            else
            {
                AgeTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
            }

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextBox.Text != "")
            {
                CityTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
            }
            else
            {
                CityTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
            }

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text != "")
            {
                PhoneTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
            }
            else
            {
                PhoneTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
            }

        }
    }
}
