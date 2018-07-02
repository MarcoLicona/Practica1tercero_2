using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Base.DAO
{
    class conexion
    {
        MySqlConnection conex;
        string cadenaconex;

        public MySqlConnection Conexion()
        {
            cadenaconex = "server=localhost; Database = tiendita; uid = root; pwd =";
            conex = new MySqlConnection(cadenaconex);

            return conex;
        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void CerrarConexion()
        {
            conex.Close();
        }











    }
}
