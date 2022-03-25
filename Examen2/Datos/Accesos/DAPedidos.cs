using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class DAPedidos
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2 ; Uid=root; Pwd=13@Eliezer31";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarPedidos()
        {
            DataTable listaPedido = new DataTable();

            try
            {
                string sql = "SELECT * FROM factura;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaPedido.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaPedido;
        }
        public bool HacerPedido(Pedidos pedidos)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO factura VALUES(@Id, @NombreCliente, @NombreProducto,@SubTotal, @Cantidad,@Total);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", pedidos.Id);
                cmd.Parameters.AddWithValue("@NombreCliente", pedidos.NombreCliente);
                cmd.Parameters.AddWithValue("@NombreProducto", pedidos.NombreProducto);
                cmd.Parameters.AddWithValue("@SubTotal", pedidos.SubTotal);
                cmd.Parameters.AddWithValue("@Cantidad", pedidos.Cantidad);
                cmd.Parameters.AddWithValue("@Total", pedidos.Total);


                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {

            }
            return inserto;
        }

    }
}
