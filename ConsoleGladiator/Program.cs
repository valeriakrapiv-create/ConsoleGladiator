using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Описание локальных величин
            double health, armor, attack, damage;
            string temp;
            Random rnd = new Random();

            //Ввод данных с клавиатуры

            while (true)
            {
                Console.Write("Введите начальный уровень здоровья: ");
                temp = Console.ReadLine();

                try
                {
                    health = Convert.ToDouble(temp);
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число здоровья!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }

            // Ввод крепости брони
            while (true)
            {
                Console.Write("Введите крепость брони (%): ");
                temp = Console.ReadLine();

                try
                {
                    armor = Convert.ToDouble(temp);
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число брони!");
       
                }
            }

            attack = rnd.NextDouble() * armor;
            damage = attack * (1 - armor / 100);
            health = health - damage;

            Console.WriteLine($"Нанесен удар: {attack:F2}");
            Console.WriteLine($"Уровень здоровья после удара : {health:F2}");
        }
    }
}

