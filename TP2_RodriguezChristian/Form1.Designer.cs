namespace TP2_RodriguezChristian
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Location = new System.Drawing.Point(49, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 33);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(49, 344);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 33);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(49, 22);
            this.dgvListadoArticulos.MultiSelect = false;
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoArticulos.Size = new System.Drawing.Size(644, 246);
            this.dgvListadoArticulos.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(49, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(483, 296);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(210, 20);
            this.txtBusqueda.TabIndex = 4;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(386, 299);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(91, 13);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtrar por nombre:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmPrincipal";
            this.Text = "Menu Articulos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblFiltro;
    }
}

