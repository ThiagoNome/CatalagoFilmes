using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoFilmes.Model
{
    internal class Serie
    {
        private static int id;
        private static string nomeSerie;
        private static string estreiaSerie;
        private static string categoriaSerie;
        private static string temporadasSerie;

        public static int Id { get => id; set => id = value; }
        public static string NomeSerie { get => nomeSerie; set => nomeSerie = value; }
        public static string EstreiaSerie { get => estreiaSerie; set => estreiaSerie = value; }
        public static string CategoriaSerie { get => categoriaSerie; set => categoriaSerie = value; }
        public static string TemporadasSerie { get => temporadasSerie; set => temporadasSerie = value; }
    }
}
