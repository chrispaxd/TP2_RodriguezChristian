using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace TP2_RodriguezChristian
{
    public partial class frmDetalles : Form
    {
        private Articulo articulo = null;
        public frmDetalles()
        {
            InitializeComponent();
        }

     
        public frmDetalles(Articulo articulo)
           {
                InitializeComponent();
               this.articulo = articulo;
           }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            txtNombre.Text = articulo.Nombre;
            txtDesc.Text = articulo.Descripcion;
            txtCodigo.Text = articulo.Codigo;
            txtUrl.Text = articulo.linkurl;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
