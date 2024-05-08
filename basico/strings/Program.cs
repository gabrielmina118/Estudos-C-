using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           var texto = new StringBuilder();
           texto.Append("Adicionando o texto aleatório");
           texto.Append("Novo texto");
           Console.WriteLine(texto);
        }
    }
}