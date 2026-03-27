using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using MySqlConnector;

namespace Proyecto1_Unidad2
{
    internal class Datos
    {
        string cadenaConexion = "server=localhost;user=root;pwd=joseluis;Database=Asistencia";
        MySqlConnection conexion;

        private void Conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Desconectar()
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DataSet ejecutar(string comando)
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Desconectar();
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Desconectar();
                return null;
            }
        }

        public DataTable ejecutarConsulta(string comando)
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Desconectar();
                return null;
            }
        }

        public bool ejecutarComando(string comando)
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Desconectar();
                return false;
            }
        }
    }
}
