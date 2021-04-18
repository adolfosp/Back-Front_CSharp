using CadastrarProduto.Connection;
using CadastrarProduto.Interface;
using CadastrarProduto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarProduto.DAO
{
    class ProdutoLayer : IProdutoLayer<Produto, int>
    {
        
        public bool Delete(Produto item)
        {
            throw new NotImplementedException();
        }

        public List<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(Produto item)
        {
            throw new NotImplementedException();
        }

        public bool Update(Produto item)
        {
            throw new NotImplementedException();
        }
    }
}
