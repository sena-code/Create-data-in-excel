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
            p2.Code = 2;
            p2.Name = "Things";
            p2.Cost = 598.8f;

            p2.Register(p2);

            
       
            Produto p = new Produto();
            List<Produto> list = p.Read();
            List<Produto> pp = p.Filtre("Keyboard & Mouse");
            
        

              foreach(Produto iten in list)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                p.Remove("Things");
                Console.WriteLine($"R$ {iten.Cost} - {iten.Name}");
                Console.ResetColor();
                

            }

            

            foreach(Produto iten in pp)
            {
                Console.WriteLine($"R$ {iten.Cost} - {iten.Name}");

            }
        }
    }
}
