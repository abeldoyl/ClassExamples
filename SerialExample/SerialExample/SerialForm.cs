using System.IO.Ports;

namespace SerialExample
{
    public partial class SerialForm : Form
    {
        private SerialPort _serialPort;

        public SerialForm()
        {
            InitializeComponent();
        }

        void SerialPortSetup()
        {
            // Close and dispose any previous instance first
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();
                _serialPort.Dispose();
            }

            _serialPort = new SerialPort
            {
                PortName = "COM4",
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One   // None is invalid; One is the usual default
            };
        }

        void SerialConnect()
        {
            try
            {
                if (!_serialPort.IsOpen)
                    _serialPort.Open();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("COM4 is in use by another process.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open port: {ex.Message}");
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SerialPortSetup();
            SerialConnect();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}