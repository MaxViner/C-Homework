Console.Write("введите число / посмотрим четное ли оно ");
try
{
    int number = Int32.Parse(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.Write("четное! ");
    }
    else
    {
        Console.Write("не четное ");
    }
}
catch 
{
    Console.Write("число... ");
}