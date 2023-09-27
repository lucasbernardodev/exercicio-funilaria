using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funilaria
{
    internal interface IFunilaria
    {
        void adicionarServico(Carro carro);
        void fazerServico();
        void entregarCarro(int id);
        int qtdeCarroEmServico();

    }
}