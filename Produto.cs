using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace create_data_in_excel
{
    public class Produto
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        private const string PATH = "Database/produto.csv";
        private const string PATHDIRECTORY = "Database";

        /// <summary>
        /// Preparing the lines
        /// </summary>
        /// <param name="p">for put itens on console</param>
        /// <returns>itens</returns>
        private string LinePrepare(Produto p)
        {
            return $"code={p.Code}; name={p.Name}; cost={p.Cost}";
        }
        /// <summary>
        /// Registre product 
        /// </summary>
        /// <param name="prod">to register a product</param>
        public void Register(Produto prod)
        {
            var line = new string[] { LinePrepare(prod) };

            File.AppendAllLines(PATH, line);
        }

        /// <summary>
        /// Read products 
        /// </summary>
        /// <returns>products with spaces</returns>

        public List<Produto> Read()
        {
            //create the list for get the return 
            List<Produto> prod = new List<Produto>();
            //Read the .csv and add a array lines
            string[] lines = File.ReadAllLines(PATH);

            //sweep our lines 
            foreach(string line in lines )
            {
                //code=1;name=Keybord and Mouse;cost=579.8
                string[] data = line.Split(";"); 

                Produto p = new Produto();
                p.Code = Int32.Parse(Separate(data[0]));
                p.Name = Separate(data[1]);
                p.Cost = float.Parse( Separate(data[2]));

                prod.Add(p);
                
            } return prod;

            

        }

        /// <summary>
        /// To separate itens after "="
        /// </summary>
        /// <param name="data">csv colum has been separate</param>
        /// <returns>string only with column's value</returns>
    
         public string Separate(string data)
            {
                return data.Split("=")[1];
            }
            /// <summary>
            /// To create a Directory or a File if they doesnt exist
            /// </summary>

        public Produto ()
        {
            
            if (!Directory.Exists(PATHDIRECTORY))
        {
            Directory.CreateDirectory(PATHDIRECTORY);
            
        }
        
            
            //the file is create if does not exist
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();

            }
        }
        public Produto (int _code, string _name, float _cost)
        {
            this.Code = _code;
            this.Name = _name;
            this.Cost = _cost;
        }
    }
}