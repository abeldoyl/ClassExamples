namespace F26Review
{
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        int GetNumberFrom(int max, int min =0)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }
        Color PenColor = Color.Black;

        void DrawLineSegment(int x, int y)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.FromArgb(255, GetNumberFrom(255), GetNumberFrom(255), GetNumberFrom(255))); // Black pen
            thePen.Width = 3;
            //draw the line here
            g.DrawLine(thePen, 0, 0, x, y);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        void Spiral()
        {
            double x = 100 * Math.Cos(45 *Math.PI / 180);
            double y = 100 * Math.Sin(45 * Math.PI / 180);

                for(int i = 0; i < 360; i++)
            {
                x = GetNumberFrom(2000) * Math.Cos(i * Math.PI / 180);
                y = GetNumberFrom(2000) * Math.Sin(i * Math.PI / 180);
                DrawDart((int)x + DisplayPictureBox.Width / 2, (int)y + DisplayPictureBox.Height / 2);
                DrawDart((int)x + DisplayPictureBox.Width / 2, (int)y + DisplayPictureBox.Height / 2);
                DrawDart((int)x + DisplayPictureBox.Width / 2, (int)y + DisplayPictureBox.Height / 2);
            }
        }

        void DrawDart(int x, int y)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.FromArgb(255,GetNumberFrom(255), GetNumberFrom(255), GetNumberFrom(255)));
            thePen.Width = GetNumberFrom(20);
            int size = GetNumberFrom(400);
            //draw the line here
            g.DrawEllipse(thePen, x - size/2, y - size/2, size, size);
            g.DrawLine(thePen, x, y -10, x, y + 10);
            g.DrawLine(thePen, x - 10, y, x + 10, y);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        //Event handlers below this point
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DrawButton_Click(object sender, EventArgs e)
        {
            int x = GetNumberFrom(DisplayPictureBox.Width);
            int y = GetNumberFrom(DisplayPictureBox.Height);
            
            //DrawDart(x, y);
            Spiral();
        }
    }
}
