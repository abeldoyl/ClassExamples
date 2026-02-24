namespace WinFormsExample
{
    partial class WinFormExampleForm
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
            SubmitButton = new Button();
            ExitButton = new Button();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            AgeLabel = new Label();
            AgeTextBox = new TextBox();
            PhoneLabel = new Label();
            PhoneTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            ClearButton = new Button();
            ControlGroupBox = new GroupBox();
            UserInfoGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            checkBox2 = new CheckBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            ReverseRadioButton = new RadioButton();
            LowerRadioButton = new RadioButton();
            UpperCaseRadioButton = new RadioButton();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            ControlGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(6, 19);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(127, 47);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(272, 19);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(127, 47);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(70, 26);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(309, 27);
            NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(15, 33);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(15, 66);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Age";
            AgeLabel.Click += label1_Click;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(70, 59);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(309, 27);
            AgeTextBox.TabIndex = 1;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(15, 132);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 9;
            PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(70, 125);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(309, 27);
            PhoneTextBox.TabIndex = 3;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(15, 99);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 7;
            CityLabel.Text = "City";
            CityLabel.Click += CityLabel_Click;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(70, 92);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(309, 27);
            CityTextBox.TabIndex = 2;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(139, 19);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(127, 47);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ControlGroupBox
            // 
            ControlGroupBox.Controls.Add(SubmitButton);
            ControlGroupBox.Controls.Add(ClearButton);
            ControlGroupBox.Controls.Add(ExitButton);
            ControlGroupBox.Location = new Point(381, 356);
            ControlGroupBox.Name = "ControlGroupBox";
            ControlGroupBox.Size = new Size(407, 82);
            ControlGroupBox.TabIndex = 7;
            ControlGroupBox.TabStop = false;
            // 
            // UserInfoGroupBox
            // 
            UserInfoGroupBox.Controls.Add(AgeTextBox);
            UserInfoGroupBox.Controls.Add(NameTextBox);
            UserInfoGroupBox.Controls.Add(PhoneLabel);
            UserInfoGroupBox.Controls.Add(NameLabel);
            UserInfoGroupBox.Controls.Add(PhoneTextBox);
            UserInfoGroupBox.Controls.Add(AgeLabel);
            UserInfoGroupBox.Controls.Add(CityLabel);
            UserInfoGroupBox.Controls.Add(CityTextBox);
            UserInfoGroupBox.Location = new Point(12, 65);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Size = new Size(425, 173);
            UserInfoGroupBox.TabIndex = 1;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(507, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 208);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(7, 160);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 59);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 130);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 100);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(28, 362);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new Size(81, 24);
            ReverseRadioButton.TabIndex = 2;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerRadioButton
            // 
            LowerRadioButton.AutoSize = true;
            LowerRadioButton.Location = new Point(27, 332);
            LowerRadioButton.Name = "LowerRadioButton";
            LowerRadioButton.Size = new Size(70, 24);
            LowerRadioButton.TabIndex = 1;
            LowerRadioButton.TabStop = true;
            LowerRadioButton.Text = "Lower";
            LowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(28, 302);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(71, 24);
            UpperCaseRadioButton.TabIndex = 0;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper";
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            UpperCaseRadioButton.CheckedChanged += UpperCaseRadioButton_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(210, 362);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(210, 332);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox3);
            Controls.Add(ReverseRadioButton);
            Controls.Add(checkBox4);
            Controls.Add(groupBox1);
            Controls.Add(LowerRadioButton);
            Controls.Add(UpperCaseRadioButton);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ControlGroupBox);
            Name = "WinFormExampleForm";
            Text = "Form1";
            Load += Form1_Load;
            ControlGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ExitButton;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Label AgeLabel;
        private TextBox AgeTextBox;
        private Label PhoneLabel;
        private TextBox PhoneTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Button ClearButton;
        private GroupBox ControlGroupBox;
        private GroupBox UserInfoGroupBox;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton ReverseRadioButton;
        private RadioButton LowerRadioButton;
        private RadioButton UpperCaseRadioButton;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
