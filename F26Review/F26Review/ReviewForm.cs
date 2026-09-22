namespace F26Review
{
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int oldX = 0, oldY = 0;
        Color PenColor = Color.Black;


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

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLineSegment(300, 250);
        }
    }
}
