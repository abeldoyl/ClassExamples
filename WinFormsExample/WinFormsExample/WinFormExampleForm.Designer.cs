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
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(395, 391);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(127, 47);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(661, 391);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(127, 47);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(64, 45);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(309, 27);
            NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(9, 52);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(9, 85);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Age";
            AgeLabel.Click += label1_Click;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(64, 78);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(309, 27);
            AgeTextBox.TabIndex = 1;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(9, 151);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 9;
            PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(64, 144);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(309, 27);
            PhoneTextBox.TabIndex = 3;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(9, 118);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 7;
            CityLabel.Text = "City";
            CityLabel.Click += CityLabel_Click;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(64, 111);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(309, 27);
            CityTextBox.TabIndex = 2;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(528, 391);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(127, 47);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(PhoneLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(CityLabel);
            Controls.Add(CityTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(ExitButton);
            Controls.Add(SubmitButton);
            Name = "WinFormExampleForm";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
