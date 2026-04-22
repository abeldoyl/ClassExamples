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
            DisplayLabel.Text = "";

            UpperCaseRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SubmitTopMenuItem.Enabled = false;

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

            if (AgeTextBox.Text == "")
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
        static int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }
        static string[,] FileToArray(string filePath)
        {
            string[,] customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    if (temp.Length == 5)
                    {
                        temp[0] = temp[0].Replace("\"$$", "");
                        temp[3] = temp[3].Replace("\"", "");
                        customerData[0, counter] = temp[0];
                        customerData[1, counter] = temp[1];
                        customerData[2, counter] = temp[2];
                        customerData[3, counter] = temp[3];
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }
            return customerData;
        }

        static void DisplayData(string[,] data)
        {
            string formattedRow = "";
            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null)
                    {
                        formattedRow += data[column, row].PadRight(14);
                    }
                }
                if (formattedRow != "")
                {
                    Console.WriteLine(formattedRow);
                }
                formattedRow = "";
            }
        }

        private string LowerCase(string toLower)
        {
            if (LowerRadioButton.Checked)
            {
                return toLower.ToLower();
            }
            else
            {
                return toLower;
            }
        }
        private string UpperCase(string toUpper)
        {
            if (UpperCaseRadioButton.Checked)
            {
                return toUpper.ToUpper();
            }
            else
            {
                return toUpper;
            }
        }
        private string Reverse(string reverseThis)
        {
            if (ReverseRadioButton.Checked)
            {
                return new string(reverseThis.Reverse().ToArray());
            }
            else
            {
                return reverseThis;
            }
        }

        //Event Hrandelers Below
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
                //Uppercase();
                //Reverse();
                DisplayLabel.Text = UpperCase(LowerCase(Reverse(NameTextBox.Text +
                    "\n" + AgeTextBox.Text +
                    "\n" + CityTextBox.Text +
                    "\n" + PhoneTextBox.Text)));
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
            if (NameTextBox.Text != "")
            {
                NameTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
                SubmitTopMenuItem.Enabled = true;
            }
            else
            {
                NameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
                SubmitTopMenuItem.Enabled = false;
            }

        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AgeTextBox.Text != "")
            {
                AgeTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
                SubmitTopMenuItem.Enabled = true;
            }
            else
            {
                AgeTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
                SubmitTopMenuItem.Enabled = false;
            }

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextBox.Text != "")
            {
                CityTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
                SubmitTopMenuItem.Enabled = true;
            }
            else
            {
                CityTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
                SubmitTopMenuItem.Enabled = false;
            }

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text != "")
            {
                PhoneTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
                SubmitTopMenuItem.Enabled = true;
            }
            else
            {
                PhoneTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
                SubmitTopMenuItem.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AboutTopMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No help available");
        }

        private void UpperContextMenuItem_Click(object sender, EventArgs e)
        {
            UpperCaseRadioButton.Checked = true;
        }

        private void LowerContextMenuItem_Click(object sender, EventArgs e)
        {
            LowerRadioButton.Checked = true;
        }

        private void ReverseContextMenuItem_Click(object sender, EventArgs e)
        {
            ReverseRadioButton.Checked = true;
        }

        private void OpenTopMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string[,] fileData;
            MainOpenFileDialog.FileName = "";
            MainOpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            MainOpenFileDialog.ShowDialog();
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = MainOpenFileDialog.FileName;

                //Get the path of specified file
                filePath = MainOpenFileDialog.FileName;
                fileData = FileToArray(filePath);
                DisplayData(fileData);
            }
        }
    }
}
