using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LabWork1
{
    Program
    {


        public static double Input(string[] args, int i)
    {
        double a;
        try
        {
            if (args.Length != 3)
                a = Convert.ToDouble(Console.ReadLine());
            else
            {
                a = Convert.ToDouble(args[i]);

            }
        }
        catch
        {
            Console.WriteLine("Повторите ввод double числа ");
            a = Input(args, i);
        }
        return a;
    }
    public static  Solution(string[] args)
    {
        double a, b, c, D, x1, x2;
        Console.WriteLine("Введите коэффиценты квадратного уравнения a,b,c");

        Console.WriteLine("Введите a: ");
        a = Input(args, 0);

        Console.WriteLine("Введите b: ");
        b = Input(args, 1);

        Console.WriteLine("Введите c: ");
        c = Input(args, 2);

        D = Math.Pow(b, 2) - 4 * a * c;
        Console.Write("D = ");
        Console.WriteLine(D);

        if (a == 0 && b == 0)
        {
            Console.WriteLine("Корней нет");
            Console.ReadKey();
        }

        else if (a == 0)
        {
            x1 = -1 * c / b;
            Console.WriteLine("x = ", x1);
            Console.ReadKey();
        }

        else if (b == 0)
        {
            x1 = Math.Sqrt(-1 * c / a);
            x2 = -1 * Math.Sqrt(-1 * c / a);
            Console.WriteLine("x1 = {0} \n x2 = {1}", x1, x2);
            Console.ReadKey();
        }

        else if (D > 0 || D == 0)
        {
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1 = {0} \n x2 = {1}", x1, x2);
            Console.ReadKey();
        }

        else
        {
            Console.WriteLine("Корней нет");
            Console.ReadKey();
        }

    }
    static void Main(string[] args)
    {
        Solution(args);
    }


    }
}
