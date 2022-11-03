//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva

//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091,
//mentre codice 123445567 resta come è)

//creo un nuovo oggetto
Prodotto casa = new Prodotto ();

//setto il nome
string nome = Console.ReadLine ();
casa.Nome = nome;

//setto prezzo e iva
casa.Prezzo = 200.20f;
casa.Iva = 12.2f;

//leggo il prezzo + iva
Console.WriteLine("prezzo + iva: " + casa.GetPrezzoIva());

//leggo il nome settato
Console.WriteLine("codice: " + casa.Codice);

Console.WriteLine("nome completo: " + casa.GetNomeCompleto());

Console.WriteLine("codice con pad left: " + casa.PadLeft());


public class Prodotto
{
    //attributi della classe
    private int codice;

    //costruttore
    public Prodotto ()
    {
        Random rnd = new Random();
        Codice = rnd.Next(10000000);
    }

    //properties
    public int Codice { get; }

    public string Nome { get; set; }

    public string Descrizione { get; set; }

    public float Prezzo { get; set; }

    public float Iva { get; set; }

    //getter

    public string GetNomeCompleto()
    {
        return Codice + Nome;
    }

    public float GetPrezzoIva()
    {
        return Prezzo + Iva;
    }

    public string PadLeft ()
    {
        //se codice.Length < 8 aggiungere zeri a sx con un ciclo for che cicli per un numero di volte inferiore a 8-codice.Length e ad ognuno aggiunga 0,
        //poi somma gli 0 al codice

        string codice = Convert.ToString(this.Codice);
        if (codice.Length <= 8)
        {
            for (int i = 0; codice.Length < 8; i++)
            {
                codice = 0 + codice;
            }
        }
        return codice;
    }
}
