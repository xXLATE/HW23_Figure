using System;
using System.Drawing;

namespace FormFigure
{
    public class Figure
    {
        protected int startX;
        protected int startY;

        public Figure(int newX, int newY)
        { }

        public virtual void Draw(Graphics graphics, Pen pen, int X1, int Y1, int X2, int Y2)
        { }
    }

    public class Circle : Figure
    {
        public Circle(Graphics graphics, Pen pen, int newX, int newY, int X2, int Y2) : base(newX, newY)
        { }

        public override void Draw(Graphics graphics, Pen pen, int X1, int Y1, int X2, int Y2)
        {
            if (X1 < X2)
            {
                if (Y1 < Y2)
                    graphics.DrawEllipse(pen, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
                else if (Y1 > Y2)
                    graphics.DrawEllipse(pen, X1, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }
            else if (X1 > X2)
            {
                if (Y1 > Y2)
                    graphics.DrawEllipse(pen, X2, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
                else if (Y1 < Y2)
                    graphics.DrawEllipse(pen, X2, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }
        }
    }

    public class Segment : Figure
    {
        public Segment(Graphics graphics, Pen pen, int newX, int newY, int X2, int Y2) : base(newX, newY)
        { }

        public override void Draw(Graphics graphics, Pen pen, int X1, int Y1, int X2, int Y2)
        {
            graphics.DrawLine(pen, X1, Y1, X2, Y2);
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(Graphics graphics, Pen pen, int newX, int newY, int X2, int Y2) : base(newX, newY)
        { }

        public override void Draw(Graphics graphics, Pen pen, int X1, int Y1, int X2, int Y2)
        {
            if (X1 < X2)
            {
                if (Y1 < Y2)
                    graphics.DrawRectangle(pen, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
                else if (Y1 > Y2)
                    graphics.DrawRectangle(pen, X1, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }
            else if (X1 > X2)
            {
                if (Y1 > Y2)
                    graphics.DrawRectangle(pen, X2, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
                else if (Y1 < Y2)
                    graphics.DrawRectangle(pen, X2, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }
        }
    }

    public class Triangle : Figure
    {
        public Triangle(Graphics graphics, Pen pen, int newX, int newY, int X2, int Y2) : base(newX, newY)
        { }

        public override void Draw(Graphics graphics, Pen pen, int X1, int Y1, int X2, int Y2)
        {
            if (X1 < X2)
            {
                if (Y1 < Y2)
                {
                    Point point1 = new Point(Math.Abs(X2 + X1) / 2, Y1);
                    Point point2 = new Point(X1, Y2);
                    Point point3 = new Point(X2, Y2);

                    Point[] curvePoints =
                    {
                             point1,
                             point2,
                             point3
                    };

                    graphics.DrawPolygon(pen, curvePoints);
                }

                else if (Y1 > Y2)
                {
                    Point point1 = new Point(Math.Abs(X2 + X1) / 2, Y2);
                    Point point2 = new Point(X1, Y1);
                    Point point3 = new Point(X2, Y1);

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
                if (Y1 > Y2)
                {
                    Point point1 = new Point(Math.Abs(X2 + X1) / 2, Y2);
                    Point point2 = new Point(X2, Y1);
                    Point point3 = new Point(X1, Y1);

                    Point[] curvePoints =
                    {
                             point1,
                             point2,
                             point3
                    };

                    graphics.DrawPolygon(pen, curvePoints);
                }

                else if (Y1 < Y2)
                {
                    Point point1 = new Point(Math.Abs(X2 + X1) / 2, Y1);
                    Point point2 = new Point(X2, Y2);
                    Point point3 = new Point(X1, Y2);

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