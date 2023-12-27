using System;

public class Circle
{
    protected double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public virtual double Area()
    {
        return Math.PI * radius * radius;
    }

    public virtual void Increase(double factor)
    {
        radius *= factor;
    }

    public string Information()
    {
        return $"Радиус: {radius}, Площадь: {Area()}";
    }
}

public class OperationProcessor : Circle
{
    private double operationDuration;

    public OperationProcessor(double r, double duration) : base(r)
    {
        operationDuration = duration;
    }

    public int ProcessData(double time)
    {
        double totalDuration = time * 60; // переводим время в секунды
        int operations = (int)(totalDuration / operationDuration); // округляем вниз до целого числа операций
        return operations;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        OperationProcessor processor = new OperationProcessor(5, 0.5);

        double totalTime = 10; // время в минутах

        int totalOperations = processor.ProcessData(totalTime);

        Console.WriteLine($"За {totalTime} минут(ы) можно выполнить {totalOperations} операций");
    }
}