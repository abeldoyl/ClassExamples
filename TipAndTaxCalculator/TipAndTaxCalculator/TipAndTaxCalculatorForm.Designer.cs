namespace TipAndTaxCalculator
{
    partial class TipAndTaxCalculatorForm
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
            CalculateButton = new Button();
            NoTipRadioButton = new RadioButton();
            Tip15RadioButton = new RadioButton();
            Tip18RadioButton = new RadioButton();
            ClearButton = new Button();
            ExitButton = new Button();
            SubmitGroupBox = new GroupBox();
            SeniorCheckBox = new CheckBox();
            StaffCheckBox = new CheckBox();
            Tip20RadioButton = new RadioButton();
            ControlGroupBox = new GroupBox();
            CustomTipTextBox = new TextBox();
            DiscountLabel = new Label();
            TipAmountLabel = new Label();
            TipCustomRadioButton = new RadioButton();
            DollarAmountTextBox = new TextBox();
            DollarAmountLabel = new Label();
            DisplayTotalLabel = new Label();
            SubmitGroupBox.SuspendLayout();
            ControlGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(18, 24);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(94, 53);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "&Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            // 
            // NoTipRadioButton
            // 
            NoTipRadioButton.AutoSize = true;
            NoTipRadioButton.Location = new Point(6, 48);
            NoTipRadioButton.Name = "NoTipRadioButton";
            NoTipRadioButton.Size = new Size(75, 24);
            NoTipRadioButton.TabIndex = 1;
            NoTipRadioButton.TabStop = true;
            NoTipRadioButton.Text = "No Tip";
            NoTipRadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip15RadioButton
            // 
            Tip15RadioButton.AutoSize = true;
            Tip15RadioButton.Location = new Point(6, 78);
            Tip15RadioButton.Name = "Tip15RadioButton";
            Tip15RadioButton.Size = new Size(58, 24);
            Tip15RadioButton.TabIndex = 2;
            Tip15RadioButton.TabStop = true;
            Tip15RadioButton.Text = "15%";
            Tip15RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip18RadioButton
            // 
            Tip18RadioButton.AutoSize = true;
            Tip18RadioButton.Location = new Point(6, 108);
            Tip18RadioButton.Name = "Tip18RadioButton";
            Tip18RadioButton.Size = new Size(58, 24);
            Tip18RadioButton.TabIndex = 3;
            Tip18RadioButton.TabStop = true;
            Tip18RadioButton.Text = "18%";
            Tip18RadioButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(118, 24);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 53);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "C&lear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(218, 24);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 53);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitGroupBox
            // 
            SubmitGroupBox.Controls.Add(ExitButton);
            SubmitGroupBox.Controls.Add(CalculateButton);
            SubmitGroupBox.Controls.Add(ClearButton);
            SubmitGroupBox.Location = new Point(462, 349);
            SubmitGroupBox.Name = "SubmitGroupBox";
            SubmitGroupBox.Size = new Size(326, 89);
            SubmitGroupBox.TabIndex = 6;
            SubmitGroupBox.TabStop = false;
            // 
            // SeniorCheckBox
            // 
            SeniorCheckBox.AutoSize = true;
            SeniorCheckBox.Location = new Point(223, 78);
            SeniorCheckBox.Name = "SeniorCheckBox";
            SeniorCheckBox.Size = new Size(73, 24);
            SeniorCheckBox.TabIndex = 7;
            SeniorCheckBox.Text = "Senior";
            SeniorCheckBox.UseVisualStyleBackColor = true;
            // 
            // StaffCheckBox
            // 
            StaffCheckBox.AutoSize = true;
            StaffCheckBox.Location = new Point(223, 108);
            StaffCheckBox.Name = "StaffCheckBox";
            StaffCheckBox.Size = new Size(62, 24);
            StaffCheckBox.TabIndex = 8;
            StaffCheckBox.Text = "Staff";
            StaffCheckBox.UseVisualStyleBackColor = true;
            // 
            // Tip20RadioButton
            // 
            Tip20RadioButton.AutoSize = true;
            Tip20RadioButton.Location = new Point(6, 138);
            Tip20RadioButton.Name = "Tip20RadioButton";
            Tip20RadioButton.Size = new Size(58, 24);
            Tip20RadioButton.TabIndex = 9;
            Tip20RadioButton.TabStop = true;
            Tip20RadioButton.Text = "20%";
            Tip20RadioButton.UseVisualStyleBackColor = true;
            // 
            // ControlGroupBox
            // 
            ControlGroupBox.Controls.Add(CustomTipTextBox);
            ControlGroupBox.Controls.Add(DiscountLabel);
            ControlGroupBox.Controls.Add(TipAmountLabel);
            ControlGroupBox.Controls.Add(TipCustomRadioButton);
            ControlGroupBox.Controls.Add(Tip18RadioButton);
            ControlGroupBox.Controls.Add(Tip20RadioButton);
            ControlGroupBox.Controls.Add(NoTipRadioButton);
            ControlGroupBox.Controls.Add(StaffCheckBox);
            ControlGroupBox.Controls.Add(Tip15RadioButton);
            ControlGroupBox.Controls.Add(SeniorCheckBox);
            ControlGroupBox.Location = new Point(25, 225);
            ControlGroupBox.Name = "ControlGroupBox";
            ControlGroupBox.Size = new Size(330, 201);
            ControlGroupBox.TabIndex = 10;
            ControlGroupBox.TabStop = false;
            // 
            // CustomTipTextBox
            // 
            CustomTipTextBox.Location = new Point(92, 168);
            CustomTipTextBox.Name = "CustomTipTextBox";
            CustomTipTextBox.Size = new Size(125, 27);
            CustomTipTextBox.TabIndex = 14;
            CustomTipTextBox.TabStop = false;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(223, 23);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(67, 20);
            DiscountLabel.TabIndex = 12;
            DiscountLabel.Text = "Discount";
            // 
            // TipAmountLabel
            // 
            TipAmountLabel.AutoSize = true;
            TipAmountLabel.Location = new Point(14, 23);
            TipAmountLabel.Name = "TipAmountLabel";
            TipAmountLabel.Size = new Size(87, 20);
            TipAmountLabel.TabIndex = 11;
            TipAmountLabel.Text = "Tip Amount";
            // 
            // TipCustomRadioButton
            // 
            TipCustomRadioButton.AutoSize = true;
            TipCustomRadioButton.Location = new Point(6, 168);
            TipCustomRadioButton.Name = "TipCustomRadioButton";
            TipCustomRadioButton.Size = new Size(80, 24);
            TipCustomRadioButton.TabIndex = 10;
            TipCustomRadioButton.TabStop = true;
            TipCustomRadioButton.Text = "Custom";
            TipCustomRadioButton.UseVisualStyleBackColor = true;
            // 
            // DollarAmountTextBox
            // 
            DollarAmountTextBox.Location = new Point(138, 127);
            DollarAmountTextBox.Name = "DollarAmountTextBox";
            DollarAmountTextBox.Size = new Size(125, 27);
            DollarAmountTextBox.TabIndex = 11;
            // 
            // DollarAmountLabel
            // 
            DollarAmountLabel.AutoSize = true;
            DollarAmountLabel.Location = new Point(25, 130);
            DollarAmountLabel.Name = "DollarAmountLabel";
            DollarAmountLabel.Size = new Size(107, 20);
            DollarAmountLabel.TabIndex = 12;
            DollarAmountLabel.Text = "Dollar Amount";
            // 
            // DisplayTotalLabel
            // 
            DisplayTotalLabel.AutoSize = true;
            DisplayTotalLabel.Location = new Point(462, 75);
            DisplayTotalLabel.Name = "DisplayTotalLabel";
            DisplayTotalLabel.Size = new Size(50, 20);
            DisplayTotalLabel.TabIndex = 13;
            DisplayTotalLabel.Text = "label2";
            // 
            // TipAndTaxCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayTotalLabel);
            Controls.Add(DollarAmountLabel);
            Controls.Add(DollarAmountTextBox);
            Controls.Add(ControlGroupBox);
            Controls.Add(SubmitGroupBox);
            Name = "TipAndTaxCalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tip & Tax";
            SubmitGroupBox.ResumeLayout(false);
            ControlGroupBox.ResumeLayout(false);
            ControlGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private RadioButton NoTipRadioButton;
        private RadioButton Tip15RadioButton;
        private RadioButton Tip18RadioButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox SubmitGroupBox;
        private CheckBox SeniorCheckBox;
        private CheckBox StaffCheckBox;
        private RadioButton Tip20RadioButton;
        private GroupBox ControlGroupBox;
        private TextBox DollarAmountTextBox;
        private Label DollarAmountLabel;
        private Label DisplayTotalLabel;
        private Label TipAmountLabel;
        private RadioButton TipCustomRadioButton;
        private Label DiscountLabel;
        private TextBox CustomTipTextBox;
    }
}
