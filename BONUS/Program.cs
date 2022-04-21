using BONUS;

//Creo lista vuota
List<Appuntamento> listaAppuntamenti = new List<Appuntamento>();

Console.WriteLine("------------Benvenuto nella tua agenda personale--------------");
Console.WriteLine("------Inserisci il numero di eventi che vuoi aggiungere-------");
Console.WriteLine("--------------------------------------------------------------");
int numeroAppuntamentiDaInserire = int.Parse(Console.ReadLine());

//istanzio tanti oggetti quanti n numeri inserisce l'utente
for (int i = 0; i < numeroAppuntamentiDaInserire; i++)
{
    int numeroEvento = i + 1;
    Console.WriteLine("Dati evento numero: " + numeroEvento);

    //Inserimento dati
    Console.WriteLine("Inserisci data appuntamento");
    string dataAppuntamento = Console.ReadLine();

    DateTime dataUtente = DateTime.Parse(dataAppuntamento);

    Console.WriteLine("Inserisci nome appuntamento");
    string nomeAppuntamento = Console.ReadLine();

    Console.WriteLine("Inserisci luogo appuntamento");
    string luogoAppuntamento = Console.ReadLine();

    //Pulisco la console
    Console.Clear();

    //Istanzio oggetto
    Appuntamento nuovoAppuntamento = new Appuntamento(dataUtente, nomeAppuntamento, luogoAppuntamento);
    listaAppuntamenti.Add(nuovoAppuntamento);
}

//ciclo con il foreach la lista 
foreach (Appuntamento elementoListaAppuntamenti in listaAppuntamenti)
{

    elementoListaAppuntamenti.ToString();

}

//ciclo per cambiare data appuntamento
Console.WriteLine("-------------Questa è la lista dei tuoi appuntamenti-------------");
foreach (Appuntamento elementoAppuntamenti in listaAppuntamenti)
{
    int j = 0;
    Console.WriteLine("Appuntamento n° " + (j + 1) + " : " + elementoAppuntamenti.GetNomeAppuntamento());

}
Console.WriteLine("Vuoi cambiare la data dell'appuntamento?");
string risposta = Console.ReadLine();


//BONUS
switch (risposta)
{

    case "si":
        Console.WriteLine("Cosa vuoi modificare? nome , luogo o data?");
        string risposta2 = Console.ReadLine();
        switch (risposta2)
        {
            case "data":
                Console.WriteLine("Di quale appuntamento vuoi cambiare la data? inserisci il numero dell'appuntamento che vuoi cambiare");
                int numeroAppuntamentoDaCambiare = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci nuova data");
                try
                {
                    DateTime nuovaData = DateTime.Parse(Console.ReadLine());
                    for (int i = 0; i < listaAppuntamenti.Count; i++)
                    {

                        listaAppuntamenti[i].CambiaData(nuovaData);
                        listaAppuntamenti[i].ToString();
                    }

                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }


                break;

            case "luogo":
                Console.WriteLine("Di quale appuntamento vuoi cambiare il luogo? inserisci il numero dell'appuntamento che vuoi cambiare");
                string luogoDaCambiare = Console.ReadLine();
                Console.WriteLine("Inserisci nuova luogo");

                string nuovoLuogo = Console.ReadLine();
                for (int i = 0; i < listaAppuntamenti.Count; i++)
                {

                    listaAppuntamenti[i].CambiaLocalita(nuovoLuogo);
                    listaAppuntamenti[i].ToString();
                }
                break;
            case "nome":
                Console.WriteLine("Di quale appuntamento vuoi cambiare il nome? inserisci il numero dell'appuntamento che vuoi cambiare");
                string nomeDaCambiare = Console.ReadLine();
                Console.WriteLine("Inserisci nuova nome");

                string nuovoNome = Console.ReadLine();
                for (int i = 0; i < listaAppuntamenti.Count; i++)
                {

                    listaAppuntamenti[i].CambiaNome(nuovoNome);
                    listaAppuntamenti[i].ToString();
                }
                break;

        }
        break;

    case "no":
        Console.WriteLine("Arrivederci");
        break;

}

