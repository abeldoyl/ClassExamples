namespace GraphicExample
{
    partial class GraphicsForm
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
            DisplayPictureBox = new PictureBox();
            ExitButton = new Button();
            DrawButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = Color.WhiteSmoke;
            DisplayPictureBox.Location = new Point(12, 39);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(1458, 808);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1340, 881);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(130, 60);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(1204, 881);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(130, 60);
            DrawButton.TabIndex = 2;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(DrawButton);
            Controls.Add(ExitButton);
            Controls.Add(DisplayPictureBox);
            MinimumSize = new Size(500, 500);
            Name = "GraphicsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphics Example";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button ExitButton;
        private Button DrawButton;
    }
}
