using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TP2_RodriguezChristian
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> lista;
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cargarDatos();   
        }

        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                lista = negocio.listar();
                dgvListadoArticulos.DataSource = lista;
                dgvListadoArticulos.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarDatos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificar;
            if (dgvListadoArticulos.CurrentRow != null)
            {
                modificar = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                frmAltaArticulo frmModificar = new frmAltaArticulo(modificar);
                frmModificar.ShowDialog();
                cargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if (dgvListadoArticulos.CurrentRow != null)
            {
                try
                {
                    int id = ((Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem).Id;
                    negocio.eliminar(id);
                    cargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            try
            {
                if (txtBusqueda.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower()));
                }
                dgvListadoArticulos.DataSource = listaFiltrada;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
