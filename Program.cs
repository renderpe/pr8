using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задача 1
            //Console.Write("Введите номер дня недели (от 1 до 7): ");
            //int n = int.Parse(Console.ReadLine());

            //switch (n)
            //{
            //    case 1: Console.WriteLine("Понедельник"); break;
            //    case 2: Console.WriteLine("Вторник"); break;
            //    case 3: Console.WriteLine("Среда"); break;
            //    case 4: Console.WriteLine("Четверг"); break;
            //    case 5: Console.WriteLine("Пятница"); break;
            //    case 6: Console.WriteLine("Суббота"); break;
            //    case 7: Console.WriteLine("Воскресенье"); break;
            //    default: Console.WriteLine("Неверный номер дня недели!"); break;
            //}

            //Console.WriteLine("Нажмите Enter для закрытия");
            //Console.ReadLine(); 

            //Задача 2
            //Console.Write("Введите номер месяца (от 1 до 12): ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Зима");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Весна");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Лето");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Осень");
            //        break;
            //    default:
            //        Console.WriteLine("Неверный номер месяца!");
            //        break;
            //}

            //Console.WriteLine("Нажмите Enter для закрытия");
            //Console.ReadLine(); 

            //Задача 3
            //Console.Write("Введите транспортное средство (a – автомобиль, в – велосипед, м – мотоцикл, с – самолет, п – поезд): ");
            //char transport = char.Parse(Console.ReadLine());

            //switch (transport)
            //{
            //    case 'a':
            //        Console.WriteLine("Максимальная скорость: 150 км/ч");
            //        break;
            //    case 'в':
            //        Console.WriteLine("Максимальная скорость: 30 км/ч");
            //        break;
            //    case 'м':
            //        Console.WriteLine("Максимальная скорость: 100 км/ч");
            //        break;
            //    case 'с':
            //        Console.WriteLine("Максимальная скорость: 900 км/ч");
            //        break;
            //    case 'п':
            //        Console.WriteLine("Максимальная скорость: 200 км/ч");
            //        break;
            //    default:
            //        Console.WriteLine("Неверный тип транспортного средства!");
            //        break;
            //}

            //Console.WriteLine("Нажмите Enter закрытия");
            //Console.ReadLine(); 

            //Задача 4
            Console.Write("Введите первую букву предмета (ф – физика, м – математика, и – история, г – география, б – биология): ");
            char subject = char.Parse(Console.ReadLine());

            switch (subject)
            {
                case 'ф':
                    Console.WriteLine("Физика");
                    break;
                case 'м':
                    Console.WriteLine("Математика");
                    break;
                case 'и':
                    Console.WriteLine("История");
                    break;
                case 'г':
                    Console.WriteLine("География");
                    break;
                case 'б':
                    Console.WriteLine("Биология");
                    break;
                default:
                    Console.WriteLine("Неверная буква предмета!");
                    break;
            }

            Console.WriteLine("Нажмите Enter для закрытия");
            Console.ReadLine(); 
        }
    }
}

