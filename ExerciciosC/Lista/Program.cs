using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> list = new List<string>();
            ////adiciona no final da lista
            //list.Add("Adolfo");
            //list.Add("Alek");
            //list.Add("Bob");
            //list.Add("Ana");

            //list.Insert(1, "adolfo lek brabo");
            ////passa a posição na onde eu quero inserir

            ////contar quantas posição tem 
            //Console.WriteLine("Quantidade "+list.Count());
            //foreach(string valor in list)
            //{
            //    Console.WriteLine(valor);

            //}
            //                        //expressao lambda
            //string s1 = list.Find(x => x[0] == 'A');
            //string s2 = list.FindLast(x => x[0] == 'k');

            //Console.WriteLine("Primeira pessoa que comeca com a letra A"+s1);
            //Console.WriteLine("Primeira pessoa que comeca com a letra B" + s2);

            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First position begin with letter A " + pos1);


            //int pos2 = list.FindLastIndex(x => x[0] == 'o');
            //Console.WriteLine("First position begin with letter o " + pos2);


            //List<string> list2 = list.FindAll(x => x.Length>=5);


            //foreach(string obj in list2)
            //{
            //    Console.WriteLine("Nomes maiores que 5 letras " + obj);
            //}

            ////passando o elemento pra remover
            //list.Remove("Alex");

            ////remove todos que comecam com a letra A
            //list.RemoveAll(x => x[0] == 'A');

            ////passa a posição na lista pra remover
            //list.RemoveAt(2);

            //// espera uma posição pra contar e depois uma contagem
            //list.RemoveRange(2,2);

           
            Console.WriteLine("How manu employees will be registered ?");
            int quantidadeDeFuncionario = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i= 0; i < quantidadeDeFuncionario; i++)
            {
                Console.Write("Id: ");
                int idFuncionario = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nomeFuncionario = Console.ReadLine();
                Console.Write("Salario: ");
                double salarioFuncionario = double.Parse(Console.ReadLine());


                list.Add(new Employee(idFuncionario, nomeFuncionario, salarioFuncionario));



            }

            Console.WriteLine("Entre com o ID que receberá o aumento");
            int idTeraAumento = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a porcentagem ");
            int porcentagemAumento = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.ID == idTeraAumento);

            if(emp != null)
            {
                emp.CalcularAumentoSalario(porcentagemAumento);
            }
            else
            {
                Console.WriteLine("Id not found");
            }

            foreach (Employee p in list)
            {
                Console.WriteLine("Id: "+(p.ID).ToString()+" Nome: "+p.Nome+" Salario: "+p.Salario);
            }




            Console.ReadKey();
        }

    }
}
