using ListaAppuntamenti;

List<Appuntamento> listaAppuntamenti = new List<Appuntamento>();

Console.WriteLine("------------Benvenuto nella tua agenda personale--------------");
Console.WriteLine("------Inserisci il numero di eventi che vuoi aggiungere-------");
Console.WriteLine("--------------------------------------------------------------");
int numeroAppuntamentiDaInserire = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroAppuntamentiDaInserire; i++)
{
    int numeroEvento = i + 1;
    Console.WriteLine("Dati evento numero: " + numeroEvento);
    Console.WriteLine("Inserisci data appuntamento");
    string dataAppuntamento = Console.ReadLine();
    DateTime dataUtente = DateTime.Parse(dataAppuntamento);
    Console.WriteLine("Inserisci nome appuntamento");
    string nomeAppuntamento = Console.ReadLine();
    Console.WriteLine("Inserisci luogo appuntamento");
    string luogoAppuntamento= Console.ReadLine();
    Console.Clear();
    Appuntamento nuovoAppuntamento = new Appuntamento(dataUtente , nomeAppuntamento , luogoAppuntamento);
    listaAppuntamenti.Add(nuovoAppuntamento);
}

foreach (Appuntamento elementoListaAppuntamenti in listaAppuntamenti)
{

    elementoListaAppuntamenti.ToString();

}


