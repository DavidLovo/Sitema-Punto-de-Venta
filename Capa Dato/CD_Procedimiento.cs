using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dato
{
   public class CD_Procedimiento
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd = new SqlCommand();
        DataTable Dt = new DataTable();
        SqlDataReader Dr;


        public DataTable LlenarDataGridView(string Procesdure)
        {
            DataTable Dt = new DataTable();

            Cmd = new SqlCommand(Procesdure, Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            return Dt;
        }


    }
}
