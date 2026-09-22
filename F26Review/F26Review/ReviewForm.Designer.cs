namespace F26Review
{
    partial class ReviewForm
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
            DisplayPictureBox = new PictureBox();
            DrawButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(251, 365);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(97, 73);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Location = new Point(12, 21);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(336, 338);
            DisplayPictureBox.TabIndex = 1;
            DisplayPictureBox.TabStop = false;
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(148, 365);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(97, 73);
            DrawButton.TabIndex = 2;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += this.DrawButton_Click;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 450);
            Controls.Add(DrawButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ExitButton);
            Name = "ReviewForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private PictureBox DisplayPictureBox;
        private Button DrawButton;
    }
}
