while (true)
{
    Console.WriteLine("Введите x");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите  y");
    double y = Convert.ToDouble(Console.ReadLine());
    int r = 1;

    if ((x >= 0) && (y <= 0) && (x * x + y * y <= r * r))
    {
        Console.WriteLine("Попадание");
    }
    else
    {
        Console.WriteLine("Промах");
    }

}