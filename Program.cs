namespace Tortiki
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string file = "C:\\Users\\user\\Downloads\\tort.txt";
            if (File.Exists(file))
            {
                Console.WriteLine(" Заказ тортов: ");
                int p = 1;
                int a = 0;
                string[] chek = Order(p);
                File.AppendAllText(file, "\n" + "Цена: " + chek[0] + "\n");
                File.AppendAllText(file, chek[1] + "Спасибо за заказ!" + "\n -----------------------------------\n");
                Console.WriteLine("Если хотите  сделать ещё заказ нажмите на любую кнопку");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
            }
            else
            {
                 File.Create(file); 
            }
        }
        static string[] Order(int p)
        {
            Cakes menu = new Cakes();
            int b = 0;
            Console.SetCursorPosition(0, p);
            Console.WriteLine("->");
            int price = 0;
            string chek = "Ваш заказ: \n";
            int cenada = 0;
            while (b == 0)
            {

                string[] itog = menu.Menu(price, chek, cenada);
                string itogs = itog[0];
                int itogcena = Convert.ToInt32(itog[1]);
                if (itogcena != 123)
                {
                    if (itogs != "")
                    {
                        chek = chek + itogs + "\n";
                    }
                    cenada = cenada + itogcena;
                }
                else
                {
                    b++;
                }
                
            }
            string cenadaStr = Convert.ToString(cenada);
            string[] itogok = new string[] { cenadaStr, chek };
            return itogok;
        }

    }
}
        
        
    
