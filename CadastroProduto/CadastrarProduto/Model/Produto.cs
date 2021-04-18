using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarProduto.Model
{
   public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public double Quantidade { get; set; }
        public string Fabricante { get; set; }

        public Produto(int id, string nomeProduto, double quantidade, string fabricante)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            Fabricante = fabricante;
        }

        public Produto(string fabricante)
        {
            Fabricante = fabricante;
        }
    }
}
