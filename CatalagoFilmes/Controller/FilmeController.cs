using CatalagoFilmes.Model;
using CatalagoFilmes.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoFilmes.Controller
{
    internal class FilmeController
    {
        public void CadastrarFilme() 
        { 
            SqlConnection cn = new SqlConnection (Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("InserirFilmeP",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Filme.NomeFilme);
                cmd.Parameters.AddWithValue("@estreia", Filme.EstreiaFilme);
                cmd.Parameters.AddWithValue("@categoria", Filme.CategoriaFilme);
                cmd.Parameters.AddWithValue("@duracao", Filme.DuracaoFilme);

                SqlParameter nv = cmd.Parameters.Add("@Id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Filme Cadastrado com sucesso, " + "Deseja Cadastrar outro Filme?", "Novo Registro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(resposta == DialogResult.Yes)
                {
                    TelaCadastroFilme TelaFilme = new TelaCadastroFilme();
                    TelaFilme.Show();
                }
                else
                {
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
