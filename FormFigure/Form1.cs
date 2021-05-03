using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            if (Figure == "line")
            {
                graphics.DrawLine(pen, X1, Y1, mouseDownLocation.X, mouseDownLocation.Y);
            }

            else if (Figure == "rectangle")
            {
                if (X1 < mouseDownLocation.X)
                {
                    if (Y1 < mouseDownLocation.Y)
                        graphics.DrawRectangle(pen, X1, Y1, Math.Abs(mouseDownLocation.X - X1), Math.Abs(mouseDownLocation.Y - Y1));
                    else if (Y1 > mouseDownLocation.Y)
                        graphics.DrawRectangle(pen, X1, mouseDownLocation.Y, Math.Abs(mouseDownLocation.X - X1), Math.Abs(mouseDownLocation.Y - Y1));
                }
                else if (X1 > mouseDownLocation.X)
                {
                    if (Y1 > mouseDownLocation.Y)
                        graphics.DrawRectangle(pen, mouseDownLocation.X, mouseDownLocation.Y, Math.Abs(mouseDownLocation.X - X1), Math.Abs(mouseDownLocation.Y - Y1));
                    else if (Y1 < mouseDownLocation.Y)
                        graphics.DrawRectangle(pen, mouseDownLocation.X, Y1, Math.Abs(mouseDownLocation.X - X1), Math.Abs(mouseDownLocation.Y - Y1));
                }
            }

            else if (Figure == "circle")
            {
                if (X1 < mouseDownLocation.X)
                {
                    if (Y1 < mouseDownLocation.Y)
                        graphics.DrawEllipse(pen, X1, Y1, Math.Abs(mouseDownLocation.X - X1), Math.Abs(mouseDownLocation.Y - Y1));
                    else if (Y1 > mouseDownLocation.Y)
                        graphics.DrawEllipse(pen, X1, mouseDownLocation.Y, Math.Abs(mouseDownLocation.X - X1), Math.Abs(mouseDownLocation.Y - Y1));
                }
                else if (X1 > mouseDownLocation.X)
                {
                    if (Y1 > mouseDownLocation.Y)
                        graphics.DrawEllipse(pen, mouseDownLocation.X, mouseDownLocation.Y, Math.Abs(mouseDownLocation.X - X1), Math.Abs(mouseDownLocation.Y - Y1));
                    else if (Y1 < mouseDownLocation.Y)
                        graphics.DrawEllipse(pen, mouseDownLocation.X, Y1, Math.Abs(mouseDownLocation.X - X1), Math.Abs(mouseDownLocation.Y - Y1));
                }
            }

            else if (Figure == "triangle")
            {
                if (X1 < mouseDownLocation.X)
                {
                    if (Y1 < mouseDownLocation.Y)
                    {
                        Point point1 = new Point(Math.Abs(mouseDownLocation.X + X1) / 2, Y1);
                        Point point2 = new Point(X1, mouseDownLocation.Y);
                        Point point3 = new Point(mouseDownLocation.X, mouseDownLocation.Y);

                        Point[] curvePoints =
                        {
                             point1,
                             point2,
                             point3
                        };

                        graphics.DrawPolygon(pen, curvePoints);
                    }

                    else if (Y1 > mouseDownLocation.Y)
                    {
                        Point point1 = new Point(Math.Abs(mouseDownLocation.X + X1) / 2, mouseDownLocation.Y);
                        Point point2 = new Point(X1, Y1);
                        Point point3 = new Point(mouseDownLocation.X, Y1);

                        Point[] curvePoints =
                        {
                             point1,
                             point2,
                             point3
                        };

                        graphics.DrawPolygon(pen, curvePoints);
                    }
                }

                else
                {
                    if (Y1 > mouseDownLocation.Y)
                    {
                        Point point1 = new Point(Math.Abs(mouseDownLocation.X + X1) / 2, mouseDownLocation.Y);
                        Point point2 = new Point(mouseDownLocation.X, Y1);
                        Point point3 = new Point(X1, Y1);

                        Point[] curvePoints =
                        {
                             point1,
                             point2,
                             point3
                        };

                        graphics.DrawPolygon(pen, curvePoints);
                    }

                    else if (Y1 < mouseDownLocation.Y)
                    {
                        Point point1 = new Point(Math.Abs(mouseDownLocation.X + X1) / 2, Y1);
                        Point point2 = new Point(mouseDownLocation.X, mouseDownLocation.Y);
                        Point point3 = new Point(X1, mouseDownLocation.Y);

                        Point[] curvePoints =
                        {
                             point1,
                             point2,
                             point3
                        };

                        graphics.DrawPolygon(pen, curvePoints);
                    }
                }
            }
        }
    }
}
