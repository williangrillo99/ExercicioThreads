using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioThreads
{
    public class Economica
    {
        private readonly ContaBancaria contaBancaria;
        private readonly Thread thread;
        public Economica(ContaBancaria contaBancaria)
        {
            this.contaBancaria = contaBancaria;
            thread = new Thread(MetodoEconomico);
        }

        void MetodoEconomico()
        {
            while(thread.IsAlive)
            {
                Thread.Sleep(1200);

                contaBancaria.Saque(50, "Esperta");

            }
        }
        public void Start()
        {
            thread.Start();
        }
    }
}
