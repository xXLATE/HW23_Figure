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
        protected int thickness;
        protected Color figureColor = Color.White;
        protected Bitmap draw;
        protected Graphics graphics;

        public DarkPaint()
        {
            InitializeComponent();
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            draw = new Bitmap(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width,
                System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            graphics = Graphics.FromImage(draw);
            graphics.Clear(Color.Black);
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
            var graphics = Graphics.FromImage(draw);
            graphics.Clear(Color.Black);
            canvas.Refresh();
        }

        private void thickBar_Scroll(object sender, EventArgs e)
        {
            thickness = thickBar.Value;
        }

        private void chooseColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                chooseColorBtn.BackColor = colorDialog.Color;
                figureColor = colorDialog.Color;
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(draw, new Point(0, 0));
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

            var pen = new Pen(figureColor, thickness);

            int X2 = mouseDownLocation.X;
            int Y2 = mouseDownLocation.Y;

            if (Figure == "line")
            {
                Figure line = new Segment(graphics, pen, X1, Y1, X2, Y2);
                line.Draw(graphics, pen, X1, Y1, X2, Y2);
                canvas.Refresh();
            }

            else if (Figure == "rectangle")
            {
                Figure rectangle = new Rectangle(graphics, pen, X1, Y1, X2, Y2);
                rectangle.Draw(graphics, pen, X1, Y1, X2, Y2);
                canvas.Refresh();
            }

            else if (Figure == "circle")
            {
                Figure circle = new Circle(graphics, pen, X1, Y1, X2, Y2);
                circle.Draw(graphics, pen, X1, Y1, X2, Y2);
                canvas.Refresh();
            }

            else if (Figure == "triangle")
            {
                Figure triangle = new Triangle(graphics, pen, X1, Y1, X2, Y2);
                triangle.Draw(graphics, pen, X1, Y1, X2, Y2);
                canvas.Refresh();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw.Save("c:\\test.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var img = new Bitmap("c:\\test.png");
            draw.Dispose();
            draw = new Bitmap(img);
            graphics = Graphics.FromImage(draw);
            canvas.Refresh();
            img.Dispose();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var graphics = Graphics.FromImage(draw);
            graphics.Clear(Color.Black);
            canvas.Refresh();
        }
    }
}
