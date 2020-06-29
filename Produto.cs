using System.IO;

namespace create_data_in_excel
{
    public class Produto
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        private const string PATH = "Database/produto.csv";
        private string LinePrepare(Produto p)
        {
            return $"codigo={p.Code}; nome={p.Name}; preço={p.Cost}";
        }
        public void Register(Produto prod)
        {
            var line = new string[] { LinePrepare(prod) };

            File.AppendAllLines(PATH, line);
        }

        public Produto ()
        {
            
            if (!Directory.Exists(PATH))
        {
            Directory.CreateDirectory(PATH);
            
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