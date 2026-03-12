
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
            SubmitButton = new Button();
            ClearButton = new Button();
            InfoGroupBox = new GroupBox();
            CompanyLabel = new Label();
            CompanyTextBox = new TextBox();
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            OutputGroupBox = new GroupBox();
            DisplayListBox = new ListBox();
            SelectionComboBox = new ComboBox();
            InfoGroupBox.SuspendLayout();
            OutputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(541, 297);
            ExitButton.Margin = new Padding(2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(90, 54);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(352, 297);
            SubmitButton.Margin = new Padding(2);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(90, 54);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(446, 297);
            ClearButton.Margin = new Padding(2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(90, 54);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // InfoGroupBox
            // 
            InfoGroupBox.Controls.Add(CompanyLabel);
            InfoGroupBox.Controls.Add(CompanyTextBox);
            InfoGroupBox.Controls.Add(LastNameLabel);
            InfoGroupBox.Controls.Add(LastNameTextBox);
            InfoGroupBox.Controls.Add(FirstNameLabel);
            InfoGroupBox.Controls.Add(FirstNameTextBox);
            InfoGroupBox.Location = new Point(10, 22);
            InfoGroupBox.Margin = new Padding(2);
            InfoGroupBox.Name = "InfoGroupBox";
            InfoGroupBox.Padding = new Padding(2);
            InfoGroupBox.Size = new Size(240, 129);
            InfoGroupBox.TabIndex = 0;
            InfoGroupBox.TabStop = false;
            // 
            // CompanyLabel
            // 
            CompanyLabel.AutoSize = true;
            CompanyLabel.Location = new Point(5, 81);
            CompanyLabel.Margin = new Padding(2, 0, 2, 0);
            CompanyLabel.Name = "CompanyLabel";
            CompanyLabel.Size = new Size(72, 20);
            CompanyLabel.TabIndex = 5;
            CompanyLabel.Text = "Company";
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(81, 78);
            CompanyTextBox.Margin = new Padding(2);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(134, 27);
            CompanyTextBox.TabIndex = 4;
            CompanyTextBox.TextChanged += CompanyTextBox_TextChanged;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(5, 51);
            LastNameLabel.Margin = new Padding(2, 0, 2, 0);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(35, 20);
            LastNameLabel.TabIndex = 3;
            LastNameLabel.Text = "Last";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(81, 46);
            LastNameTextBox.Margin = new Padding(2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(134, 27);
            LastNameTextBox.TabIndex = 2;
            LastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(5, 22);
            FirstNameLabel.Margin = new Padding(2, 0, 2, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(36, 20);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(81, 17);
            FirstNameTextBox.Margin = new Padding(2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(134, 27);
            FirstNameTextBox.TabIndex = 0;
            FirstNameTextBox.TextChanged += FirstNameTextBox_TextChanged;
            // 
            // OutputGroupBox
            // 
            OutputGroupBox.Controls.Add(DisplayListBox);
            OutputGroupBox.Controls.Add(SelectionComboBox);
            OutputGroupBox.Location = new Point(254, 22);
            OutputGroupBox.Margin = new Padding(2);
            OutputGroupBox.Name = "OutputGroupBox";
            OutputGroupBox.Padding = new Padding(2);
            OutputGroupBox.Size = new Size(376, 270);
            OutputGroupBox.TabIndex = 4;
            OutputGroupBox.TabStop = false;
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(5, 42);
            DisplayListBox.Margin = new Padding(2);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(361, 224);
            DisplayListBox.TabIndex = 1;
            DisplayListBox.SelectedIndexChanged += DisplayListBox_SelectedIndexChanged;
            // 
            // SelectionComboBox
            // 
            SelectionComboBox.FormattingEnabled = true;
            SelectionComboBox.Location = new Point(5, 15);
            SelectionComboBox.Margin = new Padding(2);
            SelectionComboBox.Name = "SelectionComboBox";
            SelectionComboBox.Size = new Size(146, 28);
            SelectionComboBox.TabIndex = 0;
            SelectionComboBox.SelectedIndexChanged += SelectionComboBox_SelectedIndexChanged;
            // 
            // ListExamplesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(OutputGroupBox);
            Controls.Add(InfoGroupBox);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Margin = new Padding(2);
            Name = "ListExamplesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Examples";
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
            OutputGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Button ClearButton;
        private GroupBox InfoGroupBox;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private Label CompanyLabel;
        private TextBox CompanyTextBox;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
        private GroupBox OutputGroupBox;
        private ListBox DisplayListBox;
        private ComboBox SelectionComboBox;
    }
}
