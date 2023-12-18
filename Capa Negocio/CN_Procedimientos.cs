using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using  Capa_Dato;

namespace Capa_Negocio
{
    public class CN_Procedimientos
    {
        CD_Procedimiento Procedimiento = new CD_Procedimiento();

        public DataTable LlenarDataGridView(string Procesdure)
        {
            return Procedimiento.LlenarDataGridView(Procesdure);
        }
    }
}
