
using System;

namespace GladiatorBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Описание локальных величин
            double health1, armor1, attack1, damage1;
            double health2, armor2, attack2, damage2;
            string temp;
            int count = 0;
            Random rnd = new Random();

            //Оформление консоли
            Console.Title = "Гладиаторный бой";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //Ввод здоровья первого бойца
            while (true)
            {
                Console.Write("Введите начальный уровень здоровья первого бойца: ");
                temp = Console.ReadLine();

                try
                {
                    health1 = Convert.ToDouble(temp);

                    if (health1 > 0)
                        break;
                    else
                        Console.WriteLine("Здоровье должно быть положительным!");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число здоровья!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }

            //Ввод здоровья второго бойца
            while (true)
            {
                Console.Write("Введите начальный уровень здоровья второго бойца: ");
                temp = Console.ReadLine();

                try
                {
                    health2 = Convert.ToDouble(temp);

                    if (health2 > 0)
                        break;
                    else
                        Console.WriteLine("Здоровье должно быть положительным!");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число здоровья!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }

            //Ввод крепости брони первого бойца
            while (true)
            {
                Console.Write("Введите крепость брони первого бойца (%): ");
                temp = Console.ReadLine();

                try
                {
                    armor1 = Convert.ToDouble(temp);

                    if (armor1 >= 0 && armor1 <= 100)
                        break;
                    else
                        Console.WriteLine("Броня должна быть от 0 до 100!");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число брони!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }

            //Ввод крепости брони второго бойца
            while (true)
            {
                Console.Write("Введите крепость брони второго бойца (%): ");
                temp = Console.ReadLine();

                try
                {
                    armor2 = Convert.ToDouble(temp);

                    if (armor2 >= 0 && armor2 <= 100)
                        break;
                    else
                        Console.WriteLine("Броня должна быть от 0 до 100!");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число брони!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }

            //Начало боя
            while (health1 > 0 && health2 > 0)
            {
                //Атака первого бойца
                attack1 = rnd.Next(10, 50);
                damage2 = attack1 * (1 - armor2 / 100);
                health2 = health2 - damage2;
                count++;

                Console.WriteLine($"==Нанесен удар: {attack1:F2}==");
                Console.WriteLine($"Уровень здоровья второго бойца: {health2:F2}");

                //Проверка здоровья второго бойца
                if (health2 > 0)
                {
                    //Атака второго бойца
                    attack2 = rnd.Next(10, 50);
                    damage1 = attack2 * (1 - armor1 / 100);
                    health1 = health1 - damage1;
                    count++;

                    Console.WriteLine($"==Нанесен удар: {attack2:F2}==");
                    Console.WriteLine($"Уровень здоровья первого бойца: {health1:F2}");
                }
            }

            //Определение победителя
            if (health1 > 0)
            {
                Console.WriteLine("Победил первый гладиатор");
            }
            else if (health2 > 0)
            {
                Console.WriteLine("Победил второй гладиатор");
            }
            else
            {
                Console.WriteLine("Ничья");
            }

            //Вывод количества ударов
            Console.WriteLine($"Количество ударов: {count}");
        }
    }
}
