using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerProject
{
    class FornecedorController
    {

        private Repository repository = new Repository();
        public FornecedorController Insert(FornecedorController fornecedor)
        {
            return this.repository.InsertFornecedor(fornecedor);
        }

        public void Remove(FornecedorController fornecedor)
        {
            this.repository.RemoveFornecedor(fornecedor);
        }

        public IList<Fornecedor> GetAll()
        {
            return this.repository.GetAllFornecedores();

        }            

        public FornecedorController Update(Fornecedor fornecedor)
        {
            return this.repository.UpdateFornecedor(fornecedor);
        }
    }
}
