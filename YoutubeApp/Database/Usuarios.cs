using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//requerido
using System.Data;
using System.Data.SqlClient;

namespace YoutubeApp.Database
{
    public class Usuarios : Conexion
    {

        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Clave { get; set; }


        public DataTable ObtenerUsuarios()
        {
            //db = conexion
            var db = GetConnection();
            db.Open();

            SqlCommand query = new SqlCommand("select * from Usuarios",db);

            DataTable datos = new DataTable();

            //select
            SqlDataReader reader = query.ExecuteReader();

            datos.Load(reader);
            // insert,update,delete
            //query.ExecuteNonQuery();


            db.Close();
            return datos;
        }

        public DataTable GetUsuarios()
        {
            //db = conexion
            var db = GetConnection();
            db.Open();

            SqlCommand query = new SqlCommand("sp_getUsuarios", db);
            query.CommandType = CommandType.StoredProcedure;


            DataTable datos = new DataTable();

            //select
            SqlDataReader reader = query.ExecuteReader();

            datos.Load(reader);
            // insert,update,delete
            //query.ExecuteNonQuery();


            db.Close();
            return datos;
        }

        public DataTable GetUsuario( string NombreUsuario)
        {
            //db = conexion
            var db = GetConnection();
            db.Open();

            SqlCommand query = new SqlCommand("sp_getUsuario", db);
            
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("@NombreUsuario",NombreUsuario);

            DataTable datos = new DataTable();

            //select
            SqlDataReader reader = query.ExecuteReader();

            datos.Load(reader);
            // insert,update,delete
            //query.ExecuteNonQuery();


            db.Close();
            return datos;
        }

        public bool InsertUsuario()
        {

            //db = conexion
            var db = GetConnection();
            db.Open();

            SqlCommand query = new SqlCommand("sp_insertUsuario", db);

            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            query.Parameters.AddWithValue("@Nombre", Nombre);
            query.Parameters.AddWithValue("@Apellido", Apellido);
            query.Parameters.AddWithValue("@Edad", Edad);
            query.Parameters.AddWithValue("@Clave", Clave);



            // insert,update,delete
            //query.ExecuteNonQuery();
            int filasAfectadas = query.ExecuteNonQuery();

           


            db.Close();
            /*
            if (filasAfectadas > 0)
            {
                return true;

            } else
            {

                return false;
            }
            */

            return filasAfectadas > 0;

        }
    }
}
