namespace ListExamples
{
    partial class ListExamplesForm
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
            ExitButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            MainGroupBox = new GroupBox();
            CompanyLabel = new Label();
            CompanyTextBox = new TextBox();
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            ButtonGroupBox = new GroupBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            ListGroupBox = new GroupBox();
            MainGroupBox.SuspendLayout();
            ButtonGroupBox.SuspendLayout();
            ListGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(242, 35);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 64);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(124, 35);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 64);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(6, 35);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 64);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // MainGroupBox
            // 
            MainGroupBox.Controls.Add(CompanyLabel);
            MainGroupBox.Controls.Add(CompanyTextBox);
            MainGroupBox.Controls.Add(LastNameLabel);
            MainGroupBox.Controls.Add(LastNameTextBox);
            MainGroupBox.Controls.Add(FirstNameLabel);
            MainGroupBox.Controls.Add(FirstNameTextBox);
            MainGroupBox.Location = new Point(12, 12);
            MainGroupBox.Name = "MainGroupBox";
            MainGroupBox.Size = new Size(334, 426);
            MainGroupBox.TabIndex = 3;
            MainGroupBox.TabStop = false;
            // 
            // CompanyLabel
            // 
            CompanyLabel.AutoSize = true;
            CompanyLabel.Location = new Point(17, 114);
            CompanyLabel.Name = "CompanyLabel";
            CompanyLabel.Size = new Size(72, 20);
            CompanyLabel.TabIndex = 5;
            CompanyLabel.Text = "Company";
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(91, 111);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(224, 27);
            CompanyTextBox.TabIndex = 4;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(17, 81);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(35, 20);
            LastNameLabel.TabIndex = 3;
            LastNameLabel.Text = "Last";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(91, 78);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(224, 27);
            LastNameTextBox.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(17, 48);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(36, 20);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(91, 45);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(224, 27);
            FirstNameTextBox.TabIndex = 0;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Location = new Point(426, 313);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(362, 125);
            ButtonGroupBox.TabIndex = 4;
            ButtonGroupBox.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(24, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 224);
            listBox1.TabIndex = 6;
            // 
            // ListGroupBox
            // 
            ListGroupBox.Controls.Add(comboBox1);
            ListGroupBox.Controls.Add(listBox1);
            ListGroupBox.Location = new Point(352, 12);
            ListGroupBox.Name = "ListGroupBox";
            ListGroupBox.Size = new Size(436, 295);
            ListGroupBox.TabIndex = 7;
            ListGroupBox.TabStop = false;
            // 
            // ListExamplesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListGroupBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(MainGroupBox);
            Name = "ListExamplesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Examples";
            MainGroupBox.ResumeLayout(false);
            MainGroupBox.PerformLayout();
            ButtonGroupBox.ResumeLayout(false);
            ListGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Button SubmitButton;
        private GroupBox MainGroupBox;
        private GroupBox ButtonGroupBox;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private Label CompanyLabel;
        private TextBox CompanyTextBox;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private GroupBox ListGroupBox;
    }
}
