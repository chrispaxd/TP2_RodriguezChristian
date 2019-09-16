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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.SelectedIndex = -1;

                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.SelectedIndex = -1;

                if (articulo != null)
                {
                    
                    Text = "Modificar Articulo";
                    txtNombre.Text = articulo.Nombre;
                    txtDesc.Text = articulo.Descripcion;
             
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
          
            try
            {
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDesc.Text;
                articulo.Codigo = Int32.Parse(txtPrecio.Text);
                articulo.Precio = Int32.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;

                if (articulo == null)
                    articulo = new Articulo();
                
                if (articulo.Id != 0)
                    articuloNegocio.modificar(articulo);
                else
                 
                articuloNegocio.agregar(articulo);

            
                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
