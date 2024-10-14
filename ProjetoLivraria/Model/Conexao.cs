using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Model
{
    internal class Conexao
    {
        public static string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mateus.apavani\source\repos\ProjetoLivraria\ProjetoLivraria\Dados\bdlivraria.mdf;Integrated Security=True";
        }
    }
}
