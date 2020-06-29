using System;

namespace create_data_in_excel
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Code = 1;
            p1.Name = "Keyboard & Mouse";
            p1.Cost = 597.8f;

            p1.Register(p1);
        }
    }
}
