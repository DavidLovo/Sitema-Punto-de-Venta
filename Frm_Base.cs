using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema_Punto_de_Venta
{
    public partial class Frm_Base : Form
    {
        public Frm_Base()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Base_Load(object sender, EventArgs e)
        {

        }

        public virtual Boolean Guardar()
        {
            return false;
        }

        public virtual void Editar()
        {

        }

        public virtual void Eliminar()
        {

        }

        public virtual void Buscar()
        {

        }
    }
}
