using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDatos
{
    public class Autenticacion:Conexion
    {
        public bool IniciarSesion(string usuario, string contrasena)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "SELECT * FROM UsuariosMuoqa;";
                    using(MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                    }
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }
}
