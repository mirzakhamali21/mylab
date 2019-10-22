using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program conprogram = new Program();
            conprogram.getid("1");
        }

        public string getid(string id)
        {
            var connection = new SqlConnection();
            try
            {
                connection.ConnectionString = "test db";
                connection.Open();
                var selectsql = string.Format("select * from test where id='{0}';", id);
                var selectcommand = new SqlCommand(selectsql, connection);
                var datareader = selectcommand.ExecuteReader();
                return datareader.GetString(0);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                connection.Close();
                
            }
            
        }
    }
}
