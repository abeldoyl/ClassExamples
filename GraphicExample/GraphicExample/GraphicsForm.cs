namespace GraphicExample
{
    public partial class GraphicsForm : Form
    {
        //Custom Methods------------------------------------------------------
        public GraphicsForm()
        {
            ShowSplashForm();
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseMove;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseDown;
        }


        int oldX = 0, oldY = 0;
        void DrawLineSegment(int newX, int newY)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            thePen.Width = 2;
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);

            //free up resources
            g.Dispose();
            thePen.Dispose();

        }
        private void ShowSplashForm()
        {
            SplashForm splashForm = new SplashForm();
            splashForm.Show();
            System.Threading.Thread.Sleep(3000);
            splashForm.Close();
        }

        void DrawLine()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Purple);
            thePen.Width = 150;

            //draw the line here
            g.DrawLine(thePen, 0, 0, DisplayPictureBox.Width, DisplayPictureBox.Height);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        void DrawEllipse()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.PapayaWhip);
            thePen.Width = 5;

            //draw the line here
            g.DrawEllipse(thePen, 0, 0, 750, 500);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        //rectangle
        void DrawRectangle()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.CornflowerBlue);
            thePen.Width = 5;

            //draw the line here
            g.DrawRectangle(thePen, 100, 100, 200, 200);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        void DrawPie()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.CadetBlue);
            thePen.Width = 5;
            SolidBrush theBrush = new SolidBrush(Color.BurlyWood);
            SolidBrush theBrush2 = new SolidBrush(Color.Honeydew);
            SolidBrush theBrush3 = new SolidBrush(Color.HotPink);
            Rectangle bounds = new Rectangle(100, 100, 200, 200);

            //draw the line here
            g.DrawPie(thePen, bounds, 0, 45);
            g.FillPie(theBrush, bounds, 45, 135);
            g.FillPie(theBrush2, bounds, 180, 30);
            g.FillPie(theBrush3, bounds, 210, 150);

            //free up resources
            g.Dispose();
            thePen.Dispose();
            theBrush.Dispose();
            theBrush2.Dispose();
            theBrush3.Dispose();
        }

        void DrawString()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Gainsboro);
            Font theFont = new Font("Arial", 56);
            SolidBrush theBrush = new SolidBrush(Color.RebeccaPurple);


            //draw the line here
            g.DrawString("Hello!", theFont, theBrush, 0, DisplayPictureBox.Height / 2);
            //free up resources
            g.Dispose();
            thePen.Dispose();
            theBrush.Dispose();
            theFont.Dispose();
        }
        void DrawImage()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            Rectangle bounds = new Rectangle(500, 100, 400, 500);
            Image theImage = Image.FromFile("..\\..\\..\\Shadow.png");

            //draw the line here
            g.DrawImage(theImage, bounds);

            //free up resources
            g.Dispose();
            theImage.Dispose();
        }

        private Color PenColor = Color.Red;
        void UpdatePenColor()
        {
            PenColorDialog.ShowDialog();
            this.PenColor = PenColorDialog.Color;
        }

        void DrawSineWave()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.OrangeRed);
            thePen.Width = 2;
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360F;
            float scaleY = (DisplayPictureBox.Height / 200F) * -1;

            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)Math.Round(100 * Math.Sin((Math.PI / 180) * currentX));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;

            }

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        void DrawGrid()
        {
            DisplayPictureBox.Refresh();
            Color oldColor = this.PenColor;
            this.PenColor = Color.Gray;
            int xDiv = DisplayPictureBox.Width / 10;
            int yDiv = DisplayPictureBox.Height / 8;

            this.oldX = 0;
            this.oldY = 0;
            for (int x = 0; x < DisplayPictureBox.Width; x += xDiv)
            {
                oldX = x;
                DrawLineSegment(x, DisplayPictureBox.Height);
            }
            this.oldX = 0;
            this.oldY = 0;
            for (int y = 0; y < DisplayPictureBox.Height; y += yDiv)
            {
                oldY = y;
                DrawLineSegment(DisplayPictureBox.Width, y);
            }
            this.PenColor = oldColor;
        }


        //Event Handlers------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //DrawLine();
            //DrawEllipse();
            //DrawRectangle();
            //DrawPie();
            //DrawString();
            //DrawImage();
            DrawGrid();
            DrawSineWave();
        }
        private void DisplayPictureBox_MouseMove(object? sender, MouseEventArgs e)
        {
            this.Text = $"({e.X},{e.Y})";
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    //Save for context menu
                    break;
                case MouseButtons.Middle:
                    UpdatePenColor();
                    break;
                default:
                    //MessageBox.Show($"{e.Button}");
                    break;
            }
            this.oldX = e.X;
            this.oldY = e.Y;
        }
        private void DisplayPictureBox_MouseDown(object? sender, MouseEventArgs e)
        {
            this.Text += $"{e.Button}";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
