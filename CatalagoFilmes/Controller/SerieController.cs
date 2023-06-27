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
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("InserirSerieP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Serie.NomeSerie);
                cmd.Parameters.AddWithValue("@estreia", Serie.EstreiaSerie);
                cmd.Parameters.AddWithValue("@categoria", Serie.CategoriaSerie);
                cmd.Parameters.AddWithValue("@temporadas", Serie.TemporadasSerie);

                SqlParameter nv = cmd.Parameters.Add("@id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Série Cadastrado com Sucesso, " + "Deseja Cadastrar outro Filme?", "Novo Registro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    Serie.NomeSerie = string.Empty;
                    Serie.EstreiaSerie = string.Empty;
                    Serie.CategoriaSerie = string.Empty;
                    Serie.TemporadasSerie = string.Empty;
                    Serie.RetornoSerie = string.Empty;
                }
                else
                {
                    Serie.RetornoSerie = "f";
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
