void tabl()
{
    for(int i = 1; i < 10; i++) 
    {
        for(int res = 1; res < 10; res++)
        {
            int result = res * i;
            Console.WriteLine($"{i} * {res} = {result}");
        }
        Console.WriteLine();
    }
}

tabl();