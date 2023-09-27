using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funilaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funilaria fun = new Funilaria();
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            fun.adicionarServico(carro1);
            fun.adicionarServico(carro2);

            fun.fazerServico();
            fun.fazerServico();

            fun.entregarCarro(1);

            Console.ReadLine();

        }
    }
}
