using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoFilmes.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thiago.pnascimento9\source\repos\CatalagoFilmes\CatalagoFilmes\Model\Filmesbd.mdf;Integrated Security=True";
        }
    }
}
