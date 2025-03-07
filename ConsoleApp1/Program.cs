using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое целое число");
                double numb1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе целое число");
                double numb2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите оператор (+ - * / %)");
                string oper = Console.ReadLine();
                double result = 0;
                switch (oper)
                {
                    case "+":
                        result = numb1 + numb2;
                        break;

                    case "-":
                        result = numb1 - numb2;
                        break;

                    case "*":
                        result = numb1 * numb2;
                        break;

                    case "/":
                        result = numb1 / numb2;
                        break;

                    case "%":
                        result = numb1 % numb2;
                        break;

                    default:
                        Console.WriteLine("Ошибка, следуйте инструкции");
                        break;
                }
                Console.WriteLine("Результат: " + result);
            }

        }
    }
}
