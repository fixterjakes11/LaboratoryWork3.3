using System;

namespace LaboratoryWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите 1 для вывода списка бабочек или любую другую кнопку для выхода\n ");
                string view = Console.ReadLine();
                if(view == "1")
                {
                    Print();
                }
                else if(view == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Символ не распозднан");
                }
            }
        }

        public static void Print()
        {
            while (true)
            {
                Urticae urticae = new Urticae();
                Console.WriteLine(urticae.PrintValues());
                Console.WriteLine("\nНажмите 1 для вывода места обитания или любую кнопку для выхода\n");
                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.WriteLine(Urticae.LivingEnvironment());
                    break;
                }
                else
                {
                    break;
                }
            }

        }
    }

    
}
