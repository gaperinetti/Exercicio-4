using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new StreamReader("marcas_carros.txt");
            //TextReader tr = new StreamReader(@"C:\Users\...\Desktop\Test.txt"); 
            String linha = reader.ReadLine();
            while (linha != null)
            {

                int pos =linha.ToString().IndexOf('@');
              
                
                Console.WriteLine(linha.ToString().Substring(0,pos));
                linha = reader.ReadLine();

            }

            Console.ReadKey();
        }
    }
}
