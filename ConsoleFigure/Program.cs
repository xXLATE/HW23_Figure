/*Bundik Ilya, group 221
Figure #1, 21.04.2021*/

using System;

class Program
{
    static void Main()
    {
        Circle f1 = new Circle(1, 1, 3);
        Console.WriteLine(f1.Draw());

        Segment f2 = new Segment(1, 1, 4, 4);
        Console.WriteLine(f2.Draw());

        Rectangle f3 = new Rectangle(1, 1, 4, 4);
        Console.WriteLine(f3.Draw());

        Triangle f4 = new Triangle(1, 1, 4, 4, 5, 5);
        Console.WriteLine(f4.Draw());
    }
}

class Figure
{
    protected int startX;
    protected int startY;

    public Figure(int newX, int newY)
    {
        startX = newX;
        startY = newY;
    }

    public virtual string Draw()
    {
        return null;
    }
}

class Circle : Figure
{
    int radius;

    public Circle(int newX, int newY, int R) : base(newX, newY)
    {
        radius = R;
    }

    public override string Draw()
    {
        return $"Circle:\nradius = {radius}\nstarting point = ({startX}, {startY})\n";
    }
}

class Segment : Figure
{
    int x2;
    int y2;

    public Segment(int newX, int newY, int X2, int Y2) : base(newX, newY)
    {
        x2 = X2;
        y2 = Y2;
    }

    public override string Draw()
    {
        return $"Segment:\nstarting point = ({startX}, {startY})\nending point = ({x2}, {y2})\n";
    }
}

class Rectangle : Figure
{
    int width;
    int height;

    public Rectangle(int newX, int newY, int newW, int newH) : base(newX, newY)
    {
        width = newW;
        height = newH;
    }

    public override string Draw()
    {
        return $"Rectangle:\nwidth = {width}\nheight = {height}\nstarting point = ({startX}, {startY})\n";
    }
}

class Triangle : Figure
{
    int x2, x3;
    int y2, y3;

    public Triangle(int newX, int newY, int X2, int Y2, int X3, int Y3) : base(newX, newY)
    {
        x2 = X2;
        y2 = Y2;
        x3 = X3;
        y3 = Y3;
    }

    public override string Draw()
    {
        return $"Triangle:\nvertex 1 = ({startX}, {startY})\nvertex 2 = ({x2}, {y2})\nvertex 3 = ({x3}, {y3})\n";
    }
}