using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioThreads
{
    public class ContaBancaria
    {
        public int Numero {  get; set; }    
        public string Nome { get; set; }
        public int Saldo { get; set; }


        public ContaBancaria(int numero, string nome, int saldo) { 
           Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public void Deposito(int valor, string nome)
        {
            Saldo = Saldo + valor;
            Console.WriteLine($"{nome} sacou R${valor}. Saldo atual: R${Saldo}");

        }

        public void Saque (int valor, string nome)
        {
            Saldo = Saldo - valor;
            Console.WriteLine($"{nome} sacou R${valor}. Saldo atual: R${Saldo}");

        }

    }   

}
