using CatalagoFilmes.Controller;
using CatalagoFilmes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalagoFilmes.View
{
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filme.NomeFilme = txBoxFilme.Text;
            Filme.DuracaoFilme = txBoxDuracao.Text;
            Filme.EstreiaFilme = txBoxEstreia.Text;
            Filme.CategoriaFilme = cBoxCategoria.Text;

            FilmeController filme = new FilmeController();
            filme.CadastrarFilme();
        }

        public void novoCadastroFilme()
        {
            this.Close();
        }
    }
}
