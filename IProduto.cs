using System.Collections.Generic;

namespace create_data_in_excel
{
    public interface IProduto
    {
        string LinePrepare(Produto p);
        void Register(Produto prod);
        List<Produto> Read();
        void Change(Produto _changedprod);
        void Remove(string _termo);

    }
}