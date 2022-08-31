Console.Write("введите число а ");
try
{
    int max = Int32.Parse(Console.ReadLine());
    Console.Write("введите число b ");
    int b = Int32.Parse(Console.ReadLine());
    if (max > b)
    {
    Console.WriteLine("max = "+max);
    }
    else 
    {
    Console.WriteLine("max = "+b);
    }
}

catch 
{
    Console.Write("число... ");
}