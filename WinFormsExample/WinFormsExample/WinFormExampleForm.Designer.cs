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
            components = new System.ComponentModel.Container();
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
            ReverseRadioButton = new RadioButton();
            LowerRadioButton = new RadioButton();
            UpperCaseRadioButton = new RadioButton();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            ToolTip = new ToolTip(components);
            DisplayLabel = new Label();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            SubmitTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            ControlGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            TopMenuStrip.SuspendLayout();
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
            ToolTip.SetToolTip(ExitButton, "To Exit (ALT + x)");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(70, 26);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(309, 27);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
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
            AgeTextBox.TextChanged += AgeTextBox_TextChanged;
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
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
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
            CityTextBox.TextChanged += CityTextBox_TextChanged;
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
            // DisplayLabel
            // 
            DisplayLabel.BackColor = Color.Gainsboro;
            DisplayLabel.Cursor = Cursors.No;
            DisplayLabel.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(443, 65);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(345, 288);
            DisplayLabel.TabIndex = 0;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 28);
            TopMenuStrip.TabIndex = 8;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SubmitTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(46, 24);
            FileTopMenuItem.Text = "&File";
            // 
            // SubmitTopMenuItem
            // 
            SubmitTopMenuItem.Name = "SubmitTopMenuItem";
            SubmitTopMenuItem.Size = new Size(224, 26);
            SubmitTopMenuItem.Text = "&Submit";
            SubmitTopMenuItem.Click += SubmitButton_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(224, 26);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(224, 26);
            ExitTopMenuItem.Text = "E&xit";
            ExitTopMenuItem.Click += ExitButton_Click;
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(55, 24);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopMenuItem
            // 
            AboutTopMenuItem.Name = "AboutTopMenuItem";
            AboutTopMenuItem.Size = new Size(224, 26);
            AboutTopMenuItem.Text = "&About";
            AboutTopMenuItem.Click += AboutTopMenuItem_Click;
            // 
            // WinFormExampleForm
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayLabel);
            Controls.Add(checkBox3);
            Controls.Add(ReverseRadioButton);
            Controls.Add(checkBox4);
            Controls.Add(LowerRadioButton);
            Controls.Add(UpperCaseRadioButton);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ControlGroupBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "WinFormExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Example Forum";
            Load += Form1_Load;
            ControlGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
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
        private RadioButton ReverseRadioButton;
        private RadioButton LowerRadioButton;
        private RadioButton UpperCaseRadioButton;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private ToolTip ToolTip;
        private Label DisplayLabel;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private ToolStripMenuItem SubmitTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
    }
}
