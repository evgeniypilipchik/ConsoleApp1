namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите оператор (+ - * / %)");
            string oper = Console.ReadLine();
            if (oper == "+")
            {
                Console.WriteLine(numb1 + numb2);
            }
            else if (oper == "-")
            {
                Console.WriteLine(numb1 - numb2);
            }
            else if (oper == "*")
            {
                Console.WriteLine(numb1 * numb2);
            }
            else if (oper == "/")
            {
                Console.WriteLine(numb1 / numb2);
            }
            else if (oper == "%")
            {
                Console.WriteLine(numb1 % numb2);
            }
            else
            {
                Console.WriteLine("Ошибка, следуйте инструкции");
            }
        }
    }
}