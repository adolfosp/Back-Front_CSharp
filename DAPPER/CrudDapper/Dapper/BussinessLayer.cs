using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dapper
{
    public class BussinessLayer : IBussinessLayer<Employee, int>
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-J05SIF8\SQLEXPRESS; initial Catalog=DapperDB;uid=sa;password=adrvsc");
        public bool Delete(Employee item)
        {
            try
            {
                sqlOpen();
                sqlCon.Query<Employee>(@"DELETE FROM [dbo].[Employee] WHERE Id = @Id", item);

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível deletar o registro "+ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

       

        public List<Employee> GetAll()
        {
            try
            {
                sqlOpen();
                List<Employee> list = sqlCon.Query<Employee>("SELECT ID,NAME,SURNAME,ADDRESS FROM EMPLOYEE ").ToList() ;
                return null;
            }catch(Exception ex)
            {
                throw new Exception("Não foi possível buscar os registros " + ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

        public bool Save(Employee item)
        {
            try
            {
                sqlOpen();

                sqlCon.Query<Employee>(@"INSERT INTO [dbo].[Employee]([Name] ,[Surname] ,[Address]) VALUES (@NAME, @SURNAME, @ADDRESS)",item);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível gravar o registro" + ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

        public bool Update(Employee item)
        {
            try
            {
                sqlOpen();
                sqlCon.Query<Employee>("@UPDATE [dbo].[Employee] SET [Name] = @NAME ,[Surname] = @SURNAME ,[Address] = @ADDRESS",item);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o registro " + ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }



        private void sqlOpen()
        {
            if(sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        private void sqlClose()
        {

            if(sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
    }
}
