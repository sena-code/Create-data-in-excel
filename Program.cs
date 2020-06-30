using System;
using System.Collections.Generic;

namespace create_data_in_excel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Produto p1 = new Produto();
            p1.Code = 1;
            p1.Name = "Keyboard & Mouse";
            p1.Cost = 597.8f;

            p1.Register(p1);

             Produto p2 = new Produto();
            p1.Code = 2;
            p1.Name = "Things";
            p1.Cost = 598.8f;

            p1.Register(p1);

            List<Produto> list = p1.Read();

            foreach(Produto iten in list)
            {
                Console.WriteLine($"R$ {iten.Cost} - {iten.Name}");
            }

            

            var name = list.Find(x => x.Name == "Things");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name.Cost);
            Console.ResetColor();
            var key = list.Find(x => x.Name == "Keyboard & Mouse");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(key.Name);
            Console.ResetColor();
                


             
        }
    }
}
