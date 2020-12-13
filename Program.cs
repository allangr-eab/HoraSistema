using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("---Data e hora atual do sistema");
            DateTime HoraSistema = DateTime.Now;
            Console.WriteLine( "Data e hora atual do sistema {HoraSistema}");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();


        }
    }
}
