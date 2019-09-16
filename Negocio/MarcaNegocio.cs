using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            SqlDataReader lector;
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            Marca aux;
            List<Marca> lista = new List<Marca>();
            try
            {
                cn.ConnectionString = "data source=DESKTOP-TSKML30\\SQLEXPRESS ; initial catalog=Articulos_DB_RodriguezChristian; integrated security=sspi";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "Select Id, Descripcion From Marcas";
                cm.Connection = cn;
                cn.Open();
                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Marca((int)lector["Id"], (string)lector["Descripcion"]);
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
