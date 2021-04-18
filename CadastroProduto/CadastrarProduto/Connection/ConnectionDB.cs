using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarProduto.Connection
{
   public  class ConnectionDB
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-J05SIF8\SQLEXPRESS; initial Catalog=DapperDB;uid=sa;password=adrvsc");

        private void sqlOpen()
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        private void sqlClose()
        {

            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

    }
}
