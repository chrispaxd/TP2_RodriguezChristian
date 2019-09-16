using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            SqlDataReader lector;
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            Categoria aux;
            List<Categoria> lista = new List<Categoria>();
            try
            {
                cn.ConnectionString = "data source=DESKTOP-TSKML30\\SQLEXPRESS ; initial catalog=Articulos_DB_RodriguezChristian; integrated security=sspi";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "Select Id, Descripcion From Categorias";
                cm.Connection = cn;
                cn.Open();
                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Categoria((int)lector["Id"], (string)lector["Descripcion"]);
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
