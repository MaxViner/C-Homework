Console.Write("введите число / выведем все четные числа от 1 до него ");
try
{   int i = 2;
    int N = Int32.Parse(Console.ReadLine());
    while (i <= N)
    {
        if (i % 2 == 0)
        {
        Console.Write(i+", ");
        }
        i++;
    }
}
catch 
{
    Console.Write("число... ");
}