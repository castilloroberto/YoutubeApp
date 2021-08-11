using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YoutubeApp.Database
{
    public class Conexion
    {

        // obtener conexion
        protected SqlConnection GetConnection()
        {
            //SqlConnection connection2 = new SqlConnection("");
            var connection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=youtubeDB;Trusted_Connection=True;");


            return connection;
        }




    }
}
