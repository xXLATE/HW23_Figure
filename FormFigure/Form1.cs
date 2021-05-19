using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormFigure
{
    public partial class DarkPaint : Form
    {
        protected int X1;
        protected int Y1;
        protected string Figure = "line";

        public DarkPaint()
        {
            InitializeComponent();
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
        }

        private void controlPanel_Enter(object sender, EventArgs e)
        { }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            Figure = "line";
        }

        private void rectangleBtn_Click(object sender, EventArgs e)
        {
            Figure = "rectangle";
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            Figure = "circle";
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            Figure = "triangle";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            var graphics = canvas.CreateGraphics();
            graphics.Clear(Color.Black);
        }

        private void canvas_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            X1 = mouseDownLocation.X;
            Y1 = mouseDownLocation.Y;
        }

        private void canvas_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            var graphics = canvas.CreateGraphics();
            var pen = new Pen(Color.White, 10);

            int X2 = mouseDownLocation.X;
            int Y2 = mouseDownLocation.Y;

            if (Figure == "line")
            {
                Figure line = new Segment(graphics, pen, X1, Y1, X2, Y2);
                line.Draw(graphics, pen, X1, Y1, X2, Y2);
            }

            else if (Figure == "rectangle")
            {
                Figure rectangle = new Rectangle(graphics, pen, X1, Y1, X2, Y2);
                rectangle.Draw(graphics, pen, X1, Y1, X2, Y2);
            }

            else if (Figure == "circle")
            {
                Figure circle = new Circle(graphics, pen, X1, Y1, X2, Y2);
                circle.Draw(graphics, pen, X1, Y1, X2, Y2);
            }

            else if (Figure == "triangle")
            {
                Figure triangle = new Triangle(graphics, pen, X1, Y1, X2, Y2);
                triangle.Draw(graphics, pen, X1, Y1, X2, Y2);
            }
        }
    }
}
