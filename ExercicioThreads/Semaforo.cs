using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioThreads
{
    public class Semaforo
    {
        private static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(2);
        public void FuncaoSemaofo()
        {
            for (int i = 0; i <= 10; i++)
            {
                string threadName = $"Thread {i}";
                var t = new Thread(() =>  Salvar(threadName));

                t.Start();
            }
        }
        private static void Salvar(string nome )
        {
            Console.WriteLine($"{nome}: Aguardando");
            semaphoreSlim.Wait();

            Console.WriteLine($"{nome}: Salvando");
            Thread.Sleep(2000);

            Console.WriteLine($"{nome}: Concluida");
            semaphoreSlim.Release();
        }
    }
}
