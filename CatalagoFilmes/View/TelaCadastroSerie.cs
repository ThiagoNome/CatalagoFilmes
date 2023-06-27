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
    public partial class TelaCadastroSerie : Form
    {
        public TelaCadastroSerie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serie.NomeSerie = txBoxSerie.Text;
            Serie.CategoriaSerie = cBoxCategoria.Text;
            Serie.EstreiaSerie = txBoxEstreia.Text;
            Serie.TemporadasSerie = txBoxTemporadas.Text;
            
            SerieController serie = new SerieController();
            serie.CadastrarSerie();
        }

        public void novoCadastroSerie()
        {
            this.Close();
        }

    }
}
