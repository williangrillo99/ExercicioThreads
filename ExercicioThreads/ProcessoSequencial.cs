using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioThreads
{
    public class ProcessoSequencial
    {

        public void FuncaoSequencial()
        {
            Console.WriteLine("Inicio Processamento Sequencial");

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            Processo1();
            Processo2();
            Processo3();
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
