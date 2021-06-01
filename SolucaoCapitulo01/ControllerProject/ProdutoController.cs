using PersistenceProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerProject
{
    class ProdutoController
    {

        private Repository repository = new Repository();
        public ProdutoController Insert(ProdutoController produto)
        {
            return this.repository.InsertProduto(produto);
        }

        public void Remove(ProdutoController produto)
        {
            this.repository.RemoveProduto(produto);
        }

        public IList<Produto> GetAll()
        {
            return this.repository.GetAllProdutos();

        }

        public FornecedorController Update(Produto produto)
        {
            return this.repository.UpdateProduto(produto);
        }
    }
}
