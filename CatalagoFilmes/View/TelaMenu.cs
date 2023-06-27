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
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCadastroSerie serie1 = new TelaCadastroSerie();
            serie1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastroFilme filme1 = new TelaCadastroFilme();
            filme1.Show();
        }
    }
}
