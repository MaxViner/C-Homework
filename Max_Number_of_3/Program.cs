Console.Write("введите число а ");
try
{
    int max = Int32.Parse(Console.ReadLine());
    Console.Write("введите число b ");
    int b = Int32.Parse(Console.ReadLine());
    Console.Write("введите число c ");
    int c = Int32.Parse(Console.ReadLine());
    if (max < b)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    Console.WriteLine("max = "+max);
}

catch 
{
    Console.Write("число... ");
}