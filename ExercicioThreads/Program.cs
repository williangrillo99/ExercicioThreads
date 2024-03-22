
using ExercicioThreads;


//var processo = new ProcessoSequencial();
//var processoParalelo = new ProcessoParalelo();
//var semaforo = new Semaforo();

//processo.FuncaoSequencial();
//processoParalelo.FuncaoParalela();
//semaforo.FuncaoSemaofo();


ContaBancaria conta = new(123456, "Willian", 1000);
Gastadora Gastadora = new Gastadora(conta);
Esperta Esperta = new(conta);
Economica Economica = new(conta);

Gastadora.Start();
Esperta.Start();
Economica.Start();