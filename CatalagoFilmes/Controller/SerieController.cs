using CatalagoFilmes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoFilmes.Controller
{
    internal class SerieController
    {
        public void CadastrarSerie()
        {
            SqlConnection cn = new SqlConnection(ConexaoSerie.ConectarSerie());
            SqlCommand cmd = new SqlCommand("InserirSerieP", cn);

            try
            {
                cmd.Parameters.AddWithValue("@nome", Serie.NomeSerie);
                cmd.Parameters.AddWithValue("@estreia", Serie.EstreiaSerie);
                cmd.Parameters.AddWithValue("@categoria", Serie.CategoriaSerie);
                cmd.Parameters.AddWithValue("@temporadas", Serie.TemporadasSerie);

                SqlParameter nv = cmd.Parameters.Add("@Id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("")

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
