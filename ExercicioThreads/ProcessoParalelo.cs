using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioThreads
{
    public class ProcessoParalelo
    {
        public void FuncaoParalela()
        {

            var processo1 = new Action(Processo1);
            var processo2 = new Action(Processo2);
            var processo3 = new Action(Processo3);


            Console.WriteLine("Inicio Processamento Paralelo");

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            Parallel.Invoke(processo1, processo2, processo3);
            stopWatch.Stop();

            Console.WriteLine($"Tempo de processamento {stopWatch.ElapsedMilliseconds} ms");
        }

        private void Processo1()
        {
            Console.WriteLine($"Processo 1, Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }
        private void Processo2()
        {
            Console.WriteLine($"Processo 2, Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);

        }
        private void Processo3()
        {
            Console.WriteLine($"Processo 3, Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }
    }
}
