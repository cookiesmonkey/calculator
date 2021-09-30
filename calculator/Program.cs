using System;

namespace calculator

{
    struct Calculator
    {
        public double x;
        public double y;
        public void Addition()
        {
            x = x + y;
            Console.WriteLine("Равно:" + x);
        }
        public void Subtraction()
        {
            x = x - y;
            Console.WriteLine("Равно:" + x);
        }
        public void Multiplication()
        {
            x = x * y;
            Console.WriteLine("Равно:" + x);
        }
        public void Dividing ()
        {
            x = x / y;
            Console.WriteLine("Равно:" + x);
        }

        class Program
        {
            static void Main(string[] args)
            { Calculator h = new Calculator();
                Console.WriteLine("Введите число 1:");
                string inputx = Console.ReadLine();
                h.x = Convert.ToInt32(inputx);
                Console.WriteLine("Введите число 2:");
                string inputy = Console.ReadLine();
                h.y = Convert.ToInt32(inputy);
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Что вы хотите сделать с числами? " + "\n" + "1.Сложить" + "\n" + "2.Вычесть" + "\n" + "3.Умножить" + "\n" + "4.Разделить" + "\n" + "5.Закончить действия");
                    string deystv = Console.ReadLine();
                    if (deystv == "1")
                    {
                        h.Addition();
                    }
                    if (deystv == "2")
                    {
                        h.Subtraction();
                    }
                    if (deystv == "3")
                    {
                        h.Multiplication();
                    }
                    if (deystv == "4")
                    {
                        h.Dividing();
                    }
                    if (deystv == "5")
                    {
                        return;
                    }
                    Console.WriteLine("Введите новое число:");
                        string inputy1 = Console.ReadLine();
                        h.y = Convert.ToInt32(inputy1);
                }
            }
        }
    }
}
