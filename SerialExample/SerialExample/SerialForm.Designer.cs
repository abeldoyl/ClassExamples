namespace SerialExample
{
    partial class SerialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ExitButton = new Button();
            ConnectButton = new Button();
            StatusTimer = new System.Windows.Forms.Timer(components);
            StatusStrip = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            ReadButton = new Button();
            WriteButton = new Button();
            label1 = new Label();
            SerialTextBox = new TextBox();
            PortsComboBox = new ComboBox();
            ComListBox = new ListBox();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(658, 363);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(130, 75);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(522, 363);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(130, 75);
            ConnectButton.TabIndex = 1;
            ConnectButton.Text = "&Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // StatusTimer
            // 
            StatusTimer.Enabled = true;
            StatusTimer.Interval = 250;
            StatusTimer.Tick += StatusTimer_Tick;
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusLabel });
            StatusStrip.Location = new Point(0, 445);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 26);
            StatusStrip.TabIndex = 2;
            StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(85, 20);
            StatusLabel.Text = "StatusLabel";
            StatusLabel.Click += StatusLabel_Click;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(386, 363);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(130, 75);
            ReadButton.TabIndex = 3;
            ReadButton.Text = "&Read";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // WriteButton
            // 
            WriteButton.Location = new Point(250, 363);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(130, 75);
            WriteButton.TabIndex = 4;
            WriteButton.Text = "&Write";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 167);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // SerialTextBox
            // 
            SerialTextBox.Location = new Point(12, 46);
            SerialTextBox.Name = "SerialTextBox";
            SerialTextBox.Size = new Size(299, 27);
            SerialTextBox.TabIndex = 6;
            // 
            // PortsComboBox
            // 
            PortsComboBox.FormattingEnabled = true;
            PortsComboBox.Location = new Point(12, 12);
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(151, 28);
            PortsComboBox.TabIndex = 7;
            // 
            // ComListBox
            // 
            ComListBox.FormattingEnabled = true;
            ComListBox.Location = new Point(317, 12);
            ComListBox.Name = "ComListBox";
            ComListBox.Size = new Size(471, 344);
            ComListBox.TabIndex = 8;
            // 
            // SerialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 471);
            Controls.Add(ComListBox);
            Controls.Add(PortsComboBox);
            Controls.Add(SerialTextBox);
            Controls.Add(label1);
            Controls.Add(WriteButton);
            Controls.Add(ReadButton);
            Controls.Add(StatusStrip);
            Controls.Add(ConnectButton);
            Controls.Add(ExitButton);
            Name = "SerialForm";
            Text = "Form1";
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button ConnectButton;
        private System.Windows.Forms.Timer StatusTimer;
        private StatusStrip StatusStrip;
        private Button ReadButton;
        private Button WriteButton;
        private ToolStripStatusLabel StatusLabel;
        private Label label1;
        private TextBox SerialTextBox;
        private ComboBox PortsComboBox;
        private ListBox ComListBox;
    }
}
