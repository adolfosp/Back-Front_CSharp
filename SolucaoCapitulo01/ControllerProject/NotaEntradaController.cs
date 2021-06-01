using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerProject
{
    class NotaEntradaController
    {
        private Repository repository = new Repository();
        public NotaEntradaController Insert(NotaEntrada notaEntrada)
        {
            return this.repository.InsertNotaEntrada(notaEntrada);
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
