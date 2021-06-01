using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ReajusteDeSalario
{
    class RepositorioFuncionario
    {
        private IList<Funcionario> funcionarios = new BindingList <Funcionario>();


        public void Inserir(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public IList<Funcionario> ObterTodos()
        {
            return this.funcionarios;
        }
    }
}
