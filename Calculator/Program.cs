using System.Diagnostics.CodeAnalysis;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        { calculator();  
        }
        static int calculator()
        {
            Console.WriteLine("Calculator by Huseyn Ahadzada");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.Write("Eded daxil edin(1-4):");
            int operator_num = Int32.Parse(Console.ReadLine());
            int a, b;
            int c = 0;
            switch (operator_num)
            {
                case 1:
                    Console.Write("1-ci ededi daxil edin: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2-ci ededi daxil edin: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Netice: "+ c);
                    Console.WriteLine("------Cixmaq ucun herhansisa bir duymeye basin------");
                    break;
                case 2:
                    Console.Write("1-ci ededi daxil edin: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2-ci ededi daxil edin: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Netice: "+ c);
                    Console.WriteLine("------Cixmaq ucun herhansisa bir duymeye basin------");
                    break;
                case 3:
                    Console.Write("1-ci ededi daxil edin: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2-ci ededi daxil edin: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Netice: "+ c);
                    Console.WriteLine("------Cixmaq ucun herhansisa bir duymeye basin------");
                    break;
                case 4:
                    Console.Write("1-ci ededi daxil edin: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2-ci ededi daxil edin: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Netice: "+ c);
                    Console.WriteLine("------Cixmaq ucun herhansisa bir duymeye basin------");
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa duzgun deyer daxil edin.");
                    break;
            } 
                return c;
        }
    }
}