using ExercicioThreads;

public class Gastadora
{
    private readonly ContaBancaria conta;
    private readonly Thread thread;

    public Gastadora(ContaBancaria conta)
    {
        this.conta = conta;
        thread =  new Thread(MetodoGastadora);
    }

    public void MetodoGastadora()
    {
        while (true)
        {
            Thread.Sleep(3000);
            conta.Saque(10, "Gastadora");
        }

    }

    public void Start()
    {
        thread.Start();
    }
 
}