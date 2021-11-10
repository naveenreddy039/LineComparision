using System;

namespace FanOfGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            label: Console.WriteLine("1.Geometry \n 2.EqualsMethod \n 3.Prime Number\n 4.Reverse number \n 5.Coupen Numbers \n 6.Stop Watch");
            Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Geometry geo = new Geometry();
                    geo.printLength();
                    break;
                case 2:
                    EqualsMethod em = new EqualsMethod();
                    em.printEquality();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine("Do you want to continue...y/n");
            if (Console.ReadKey().KeyChar.ToString() == "n")
            {
                goto label;
            }
            Console.ReadKey();

        }
    }
}
