namespace GraphicExample
{
    public partial class GraphicsForm : Form
    {
        //Custom Methods------------------------------------------------------
        public GraphicsForm()
        {
            InitializeComponent();
        }

        void DrawLine()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Purple);
            thePen.Width = 100;

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



        //Event Handlers------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine();
            DrawEllipse();
            DrawRectangle();
            DrawPie();
            DrawString();
        }
    }
}
