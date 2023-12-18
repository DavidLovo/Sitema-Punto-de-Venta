using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Dato
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-0QAFIUM;Initial Catalog=Sistema_de_Venta_131223;Integrated Security=True");

        public SqlConnection Abrir()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }


        public SqlConnection Cerrar()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }



    }
}
