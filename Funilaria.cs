using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funilaria
{
    internal class Funilaria : IFunilaria
    {

        private Queue<Carro> filaDeServico;
        private List<Carro> listaDeEntrega;

        public Funilaria()
        {
            this.filaDeServico = new Queue<Carro>();
            this.listaDeEntrega = new List<Carro>();
        }

        public void adicionarServico(Carro carro) 
        {
            filaDeServico.Enqueue(carro);
        }
        public void fazerServico() 
        {
            Carro carro = filaDeServico.Dequeue();
            listaDeEntrega.Add(carro);
        }
        public void entregarCarro(int id) 
        {
            foreach (var carro in listaDeEntrega) 
            {
                if (carro.Id == id)
                {
                    listaDeEntrega.Remove(carro);
                    break;
                }
                else Console.WriteLine("Esse carro não está na lista para entrega");
            };
            
        }

        public int qtdeCarroEmServico() 
        {
            return filaDeServico.Count();
        }


    }
}