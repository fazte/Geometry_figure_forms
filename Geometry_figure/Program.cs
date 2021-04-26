// gafarov and barteniev 221
using System;

class Program
{
    static void Main()
    {
        GeometryFig Line = new GeometryFig(2, 6, blue, 7, 5);
        GeometryFig Circle = new GeometryFig(5, 6, green, 5, 9);
        GeometryFig Triangle = new GeometryFig(2, 6, red);
        GeometryFig Rectangle = new GeometryFig(5, 8, purple);
    }
}

class GeometryFig
{
    public string color;
    protected int x;
    protected int y;

    public GeometryFig(int newX, int newY)
    {
        x = newX;
        y = newY;
        Console.WriteLine("GeometryFig Constructor");
    }

    public virtual void Draw(int newX, int newY, string newColor, int newCircleLength, int newCircleLineThickness, int newRadius, int newLength, int newThickness)
    {
        return Draw();
    }

}


class Line : GeometryFig
{
    private int thickness;
    private int length;

    public Line(int newX, int newY, string newColor, int newLength, int newThickness) : base(newX, newY)
    {
        x = newX;
        y = newY;
        color = newColor;
        thickness = newThickness;
        length = newLength;
    }
    public override void Draw(int newX, int newY, string newColor, int newLength, int newThickness)
    {
        Console.WriteLine($"Значение1 {newX},Значение2 {newY}, Цвет {newColor}, Длина линии{newLength}, Толщина линии{newThickness}");
    }
}


class Circle : GeometryFig
{
    private int CircleLength;
    private int CircleLineThickness;
    private int Radius;

    public Circle(int newX, int newY, string newColor, int newCircleLength, int newCircleLineThickness, int newRadius) : base(newX, newY)
    {
        x = newX;
        y = newY;
        Radius = newRadius;
        color = newColor;
        CircleLength = newCircleLength;
        CircleLineThickness = newCircleLineThickness;
    }
    public override void Draw(int newX, int newY, string newColor, int newCircleLength, int newCircleLineThickness, int newRadius)
    {
        Console.WriteLine($"Значение1 {newX},Значение2 {newY}, Цвет {newColor},Длина окружности {newCircleLength}, Тольщина линии окружности {newCircleLineThickness}, Радиус окружности{newRadius}");
    }
}

class Triangle : GeometryFig
{

    public Triangle(int newX, int newY, string newColor) : base(newX, newY)
    {
        x = newX;
        y = newY;
        color = newColor;
    }
    public override void Draw(int newX, int newY, string newColor)
    {
        Console.WriteLine($"Значение1 {newX},Значение2 {newY}, Цвет {newColor}");
    }

}

class Rectangle : GeometryFig
{
    public Rectangle(int newX, int newY, string newColor) : base(newX, newY)
    {
        x = newX;
        y = newY;
        color = newColor;
    }
    public override void Draw(int newX, int newY, string newColor)
    {
        Console.WriteLine($"Значение1 {newX},Значение2 {newY}, Цвет {newColor}");
    }


}