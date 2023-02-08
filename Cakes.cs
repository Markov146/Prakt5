using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortiki
{
    internal class Cakes
    {
    public string[] Menu(int cenai, string chek, int cenada)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Кондитерская 'Сладкая мечта'. Заказ: ");
            string cena = "0";
            int cen = 9;
            Console.SetCursorPosition(0, cen);
            Console.WriteLine(cenada);
            Console.SetCursorPosition(0, cen - 1);
            Console.WriteLine("----------------------");
            Console.SetCursorPosition(0, cen+1);
            string b = Texti();
            int p = 1;
            int d = Strelki(p, b, cenai, chek, cenada, cen);
            Console.Clear();
            string cenaci = "";
            if (d == 1)
            {
                b = Forma();
                p = 1;
                cen = 7;
                int ce =Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();
                
                if (ce == 1)
                {
                    cenaci = "Круглый - 200; ";
                    cena = "200";
                    
                }
                if (ce == 2)
                {
                    cenaci = "Квадратный - 300; ";
                    cena = "300";
                }
                if (ce == 3)
                {
                    cenaci = "Прямоугольный - 400; ";
                    cena = "400";
                }
               
            }
            if (d == 2)
            {
                b = Razmer();
                p = 1;
                cen = 6;
                int ce = Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();

                if (ce == 1)
                {
                    cenaci = "Маленький (10 см) - 100; ";
                    cena = "100";

                }
                if (ce == 2)
                {
                    cenaci = "Средний (20 см) - 200; ";
                    cena = "200";
                }
                if (ce == 3)
                {
                    cenaci = "Большой (30 см) - 300; ";
                    cena = "300";
                }
              
            }
            if (d == 3)
            {
                b = Vkus();
                p = 1;
                cen = 7;
                int ce = Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();
                int cenak = 0;
                if (ce == 1)
                {
                    cenaci = "Молочный - 100 ";
                    cenak = 100;

                }
                if (ce == 2)
                {
                    cenaci = "Шоколадный - 200 ";
                    cenak = 200;
                }
                if (ce == 3)
                {
                    cenaci = "Клубничный - 300 ";
                    cenak = 300;
                }                             
            }
            if (d == 4)
            {
                b = Glazur();
                p = 1;
                cen = 6;
                int ce = Strelki(p, b, cenai, chek, cenada, cen);
                Console.Clear();

                if (ce == 1)
                {
                    cenaci = "Молочная глазурь - 100; ";
                    cena = "100";

                }
                if (ce == 2)
                {
                    cenaci = "Шоколадная глазурь - 100; ";
                    cena = "100";
                }
                if (ce == 3)
                {
                    cenaci = "Клубничная глазурь - 100; ";
                    cena = "100";
                }               
            }            
            if (d == 5)
            {
                cena = "123";
                cenaci = "";
            }
            string[] cenac = new string[] { cenaci, cena };
            return cenac;

        }
        private string Texti()
        {
            
            Console.SetCursorPosition(2, 1);
            return "Форма коржа \n  Размер коржа  \n  Вкус коржа  \n  Глазурь \n  Закончить заказ";
        }
        private string Forma()
        {
            Console.SetCursorPosition(0, 0);
            return "Круг - 200 \n  Квадрат - 300  \n  Прямоугольник - 400 ";
        }
        private string Razmer()
        {
            Console.SetCursorPosition(0, 0);
            return "Маленький (10 см) - 100 \n  Средний (20 см) - 200  \n  Большой (30 см) - 300 ";
        }
        private string Vkus()
        {
            Console.SetCursorPosition(0, 0);
            return "Молочный - 100 \n  Шоколадный - 200  \n  Клубничный - 300 ";
        }
        
        private string Glazur()
        {
            Console.SetCursorPosition(0, 0);
            return "Молочная глазурь - 100 \n  Шоколадная глазурь - 100  \n  Клубничная глазурь - 100";
        }
        
        public int Strelki(int p, string b, int cenai, string chek, int cenada, int cen)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(" Заказ тортов: ");
            int pi = 1;
            Console.SetCursorPosition(2, 1);
            Console.WriteLine(b);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            Console.SetCursorPosition(0, cen + 1);
            Console.WriteLine(chek);
            Console.SetCursorPosition(0, cen);
            Console.WriteLine("Цена: "+cenada);
            Console.SetCursorPosition(0, cen - 1);
            Console.WriteLine("----------------------");
            while (pi == 1)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    p = p - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    p = p + 1;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    pi = 0;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    pi = 0;
                    p = 100;
                }
                if (p < 1)
                {
                    p = 1;
                }
                Console.SetCursorPosition(2, 1);
                Console.WriteLine(b);
                Console.SetCursorPosition(0, p);
                Console.WriteLine("->");
                Console.SetCursorPosition(0, cen + 1);
                Console.WriteLine(chek);
                Console.SetCursorPosition(0, cen);
                Console.WriteLine("Цена: " + cenada);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Заказ тортов: ");
                Console.SetCursorPosition(0, cen - 1);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine(p);
            return p;
        }
    }
}
    
  
