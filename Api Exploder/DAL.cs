using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;

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
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS tb_logs(id INT(20) NOT NULL AUTO_INCREMENT," +
                    " request VARCHAR(8000) DEFAULT NULL, response VARCHAR(8000) DEFAULT NULL, PRIMARY KEY ('id') )";
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
            return new DataTable();
        }


    }
}
