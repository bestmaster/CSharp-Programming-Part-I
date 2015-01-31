using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine(@"Please choose a type:
        1 --> int
        2 --> double
        3 --> string");
        int choose = int.Parse(Console.ReadLine());
        if (choose == 1)
        {
            Console.Write("Please enter a int: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(++a);
        }
        else if (choose == 2)
        {
            Console.Write("Please enter a double: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(++a);
        }
        else
        {
            Console.Write("Please enter a string: ");
            string a = Console.ReadLine();
            Console.WriteLine(a + "*");
        }
    }
}