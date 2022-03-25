using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class DAUsuario
    {

        readonly string cadena = "Server=localhost; Port=3306; Database=examen2 ; Uid=root; Pwd=13@Eliezer31";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string nombreUsuario, string contrasenia)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM loginusuario WHERE NombreUsuario = @NombreUsuario AND Contrasenia = @Contrasenia;";

                conn = new MySqlConnection(cadena);
                conn.Open();  

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.NombreUsuario = reader[0].ToString();
                    user.Contrasenia = reader[1].ToString();
                   


                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

                
            }
            return user;
        }
    }
}
