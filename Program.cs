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
casa.SetNome(nome);

//setto prezzo e iva
casa.SetPrezzo(200.20f);
casa.SetIva(12.2f);

//leggo il prezzo + iva
Console.WriteLine(casa.GetPrezzoIva());

//leggo il nome settato
Console.WriteLine (casa.GetNome());
Console.WriteLine(casa.GetNomeCompleto());


public class Prodotto
{
    //attributi della classe
    private int codice;
    private string nome;
    private string descrizione;
    private float prezzo;
    private float iva;

    //costruttore
    public Prodotto ()
    {
        Random rnd = new Random();
        codice = rnd.Next(100000000);
    }


    //setter
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void SetDescrizione(string descrizione)
    {
        this.descrizione = descrizione;
    }

    public void SetPrezzo(float prezzo)
    {
        this.prezzo = prezzo;
    }

    public void SetIva(float iva)
    {
        this.iva = iva;
    }

    //getter
    public int GetCodice()
    {
        return this.codice;
    }

    public string GetNome()
    {
        return this.nome;
    }

    public string GetNomeCompleto()
    {
        return this.codice + this.nome;
    }

    public string GetDescrizione()
    {
        return this.descrizione;

    }
    public float GetPrezzoBase ()
    {
        return this.prezzo;
    }

    public float GetIva()
    {
        return this.iva;
    }

    public float GetPrezzoIva()
    {
        return this.prezzo + this.iva;
    }
}
