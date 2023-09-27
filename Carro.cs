using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funilaria
{
    internal class Carro : ICarro
    {
        public string Nome { get; set; }
        public int Id { get; }
        private static int proximoId = 1;

        public Carro()
        {
            this.Id = proximoId;
            proximoId++;
            this.Nome = "Carro";
        }
    }

}