using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
   public class Employee
    {
        public int ID { get; set; }
        public string Nome {get;set;}
        public double Salario { get;private set; }

        public Employee(int iD, string nome, double salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
        }


        public void CalcularAumentoSalario(int porcentagem)
        {
           
                this.Salario += ((this.Salario * 30) / 100);
         
           
        }
    }
}
