using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using Microsoft.VisualBasic.Logging;

namespace Api_Exploder
{
    public class DALapi_exploder
    {


        public static string path = Directory.GetCurrentDirectory() + "\\banco.sqlite"; //armazenar o local onde vamos guardar o bd
        private static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + path);
            sqliteConnection.Open();
            return sqliteConnection;

        }

        public static void CriarBancoSQLite()
        {
            try
            {
                if(File.Exists(path) == false) 
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch (Exception ex) 
            {
                throw ex;   
            }
        }

        public static void CriarTabelasSQLite()
        {
            try
            {
                using (var cmd= DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS tb_logs(id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    " request VARCHAR(8000) DEFAULT NULL, response VARCHAR(8000) DEFAULT NULL)";
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable GetLogs()
        {

         

            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_logs";
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                    
                }
            }
            catch (Exception)
            {
                throw;

            }


        }


        public static void InsertLogs(Logs log)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO tb_logs (request, response) VALUES (@request,@response)";
                
                    cmd.Parameters.AddWithValue("@request", log.request);
                    cmd.Parameters.AddWithValue("@response", log.response);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;

            }
        }


    }
}
