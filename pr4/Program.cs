using System;
using System.Collections.Generic;
namespace practic_4
{
    internal class Program
    {

        static void Main(string[] args)
        {

            day1();
        }
        static void day1()
        {
            List<string> one = new List<string> { "  1.День рождения", "  2.Сходить на пары" };
            Console.WriteLine("\tЗаметки 13.12.2022");
            Console.WriteLine(one[0]);
            Console.WriteLine(one[1]);
            string F = "Выполнить:";

            int position = 1;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo x = Console.ReadKey();

            while (x.Key != ConsoleKey.Enter)
            {
                if (x.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 23.09.2023");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                else if (x.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 22.09.2023");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                x = Console.ReadKey();

                if (x.Key == ConsoleKey.RightArrow) { Console.Clear(); day2(); }
                else if (x.Key == ConsoleKey.LeftArrow) { Console.Clear(); day3(); }
            }
            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine("Поздравить деда с днем рождения");
                Console.WriteLine();
                Console.WriteLine(F + ": 22.09.2023 - 12:00");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine(" Доехать до дома");
                Console.WriteLine();
                Console.WriteLine(F + ": 22.09.2023 - 09:00");
            }
            Console.ReadKey();
            Console.Clear();
            day1();

            static void day2()
            {

                List<string> two = new List<string> { "  1. Забрать ежедневки", "  2. Почистить компьютер" };

                Console.WriteLine("\tЗаметки 07.06.2023");
                Console.WriteLine(two[0]);
                Console.WriteLine(two[1]);
                string F = "Выполнить:";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();

                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 23.04.2023 ");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 11.12.2023 ");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    Console.SetCursorPosition(0,position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();
                    if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); day3(); }
                    else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day1(); }
                }
                if (position == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" Зайти в игру чтобы не потрять прогресс");
                    Console.WriteLine();
                    Console.WriteLine(F + ": 10.03.2023 - 12:30");
                }
                else if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Пересобрать комп для очистки");
                    Console.WriteLine();
                    Console.WriteLine(F + ": 20.08.2020 - 00:00");
                }
                Console.ReadKey();
                Console.Clear();
                day2();
            }
            static void day3()
            {
                List<string> three = new List<string> { "  1. За кастомить клавиатуру" };
                Console.WriteLine("\tЗаметки 21.03.2023");
                Console.WriteLine(three[0]);
                string F = "Выполнить";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();

                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();

                    if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); Console.WriteLine("Заметок больше нет."); day1(); }
                    else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day2(); }
                }
                Console.Clear();
                Console.WriteLine("Заказать нужные части");
                Console.WriteLine();
                Console.WriteLine(F + ": 05.02.2023 - 15:00");

            }
        }

    }
}