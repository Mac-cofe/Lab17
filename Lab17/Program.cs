using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Check<int> check1 = new Check<int>();
            check1.Number = 100;
            check1.Name = "Иванов Иван Иванович";
            check1.Balance = 10000;
            check1.Output();
            Console.WriteLine();

            Check<string> check2 = new Check<string>
            {
                Number = "GR-1100",
                Name = "Сидоров Сергей Петрович",
                Balance = 12345
            };
            check2.Output();
            Console.WriteLine();

            Check<float> check3 = new Check<float>();
            check3.Number = 100.54f;
            check3.Name = "Николаев Петр Викторович";
            check3.Balance = 99999;
            check3.Output();
            Console.WriteLine();

            Check<int> check4 = new Check<int>();
            check4.Number = 55241;
            check4.InputFioBalance();
            check4.Output();
            Console.WriteLine();

            Console.ReadKey();
        }

        public class Check<T>
        {
            public T Number { get; set; }
            public double Balance { get; set; }
            public string Name { get; set; }


            //public void Input<T>()                                       // метод ввода не работает, можно ли заполнять с клавиатуры переменную Number (номер счета)?
            //{
            //    Console.WriteLine("Введите номер счета");
            //    value = Console.ReadLine();
            //    Console.WriteLine("Введите Ф.И.О. владельца");
            //    Name = Console.ReadLine();
            //    Console.WriteLine("Введите баланс");
            //    Balance = Convert.ToDouble(Console.ReadLine());
            //}

            public void InputFioBalance()
            {
                Console.WriteLine("Введите Ф.И.О. владельца");
                Name = Console.ReadLine();
                Console.WriteLine("Введите баланс");
                Balance = Convert.ToDouble(Console.ReadLine());
            }

            public void Output()
            {
                Console.WriteLine($"Владелец счета: {Name}, Счет {Number}, Баланс счета {Balance,3:n}");
            }

        }
    }
}

