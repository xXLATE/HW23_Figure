using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormFigure
{
    public partial class Form1 : Form
    {
        protected int X1;
        protected int Y1;
        protected string Figure = "line";

        public Form1()
        {
            InitializeComponent();
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figure = "line";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figure = "rectangle";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Figure = "circle";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Figure = "triangle";
        }

        // CLEAR
        private void button5_Click(object sender, EventArgs e)
        {
            var graphics = panel1.CreateGraphics();
            graphics.Clear(Color.Black);
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            X1 = mouseDownLocation.X;
            Y1 = mouseDownLocation.Y;
        }

        private void panel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            var graphics = panel1.CreateGraphics();
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
