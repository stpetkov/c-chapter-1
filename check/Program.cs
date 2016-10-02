using System;



    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Добър ден");
        int a = 45;
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(Math.Sqrt(12345));
        for(int i = 2; i < 101; i++)
        {
            if (i % 2 != 0) { Console.WriteLine("-" + i); }
            else { Console.WriteLine(i); }
        }
        int age= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(age);
        Console.WriteLine("After 10 years you will be "+(age+10)+" years old");
        uint g=12;
        }
    }

