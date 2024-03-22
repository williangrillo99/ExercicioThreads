using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioThreads
{
    public class Esperta
    {
        private readonly ContaBancaria contaBancaria;
        private readonly Thread thread;

        public Esperta(ContaBancaria contaBancaria)
        {
            this.contaBancaria = contaBancaria;
            thread =  new Thread(MetodoEsperta);
        }

        void MetodoEsperta()
        {
            while (thread.IsAlive)
            {
                Thread.Sleep(6000);

                    contaBancaria.Saque(50, "Esperta");

            
            }
      
        }

        public void Start()
        {
            thread.Start(); 
        }
    }
}
