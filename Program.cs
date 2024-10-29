using System;

abstract class Shape
{
    // Конструктор абстрактного класу Shape
    public Shape()
    {
        Console.WriteLine("Об'єкт створено");
    }

    // Абстрактний метод для обчислення площі
    public abstract double CalculateArea();

    // Метод для виведення повідомлення про площу
    public void DisplayArea()
    {
        Console.WriteLine($"Площа фігури: {CalculateArea()}");
    }
}

class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double CalculateArea()
    {
        return side * side;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateArea()
    {
        return length * width;
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main()
    {
        // Створення та виведення площі квадрата
        Shape square = new Square(4);
        square.DisplayArea();

        // Створення та виведення площі прямокутника
        Shape rectangle = new Rectangle(4, 6);
        rectangle.DisplayArea();

        // Створення та виведення площі круга
        Shape circle = new Circle(5);
        circle.DisplayArea();
    }
}