using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] listaCompras = {"maçã", "batata", "cenoura", "laranja", "mexirica"};
            double[] precos = {2.5, 4.3, 2.8};

            string[] mercados = new string[5];

          //  Console.WriteLine(listaCompras[1]); 

            Console.WriteLine("Trocar maçã por qual item?");
            
            string item = Console.ReadLine();

            listaCompras[0] = Console.ReadLine();

          //  Console.WriteLine(listaCompras[0]);

            for(int i = 0; i < listaCompras.Length; i++){
                Console.WriteLine(listaCompras[i]);
            }

           
        }
    }
}
