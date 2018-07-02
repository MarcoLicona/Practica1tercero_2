using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Base.DAO
{
    class MarcaTabla:conexion
    {
        string instruccion;

        public DataTable VistaTabla()
        {
            instruccion = "select * from compra";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, Conexion());
            DataTable Consulta = new DataTable();
            adp.Fill(Consulta);
            return Consulta;
        }
    }
}
