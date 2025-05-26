using System;

public class Dipendente
{
    //Campi privati nome e eta
    private string _nome;
    private int _eta;

    /// <summary>
    /// Proprietà del Nome
    /// </summary>
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            _nome = value;
        }
    }
    /// <summary>
    /// Proprietà dell'età che esegue il controllo
    /// </summary>
    public int Eta
    {
        get
        {
            return _eta;
        }
        set
        {
            if (value >= 18)
            {
                _eta = value;
            }
        }
    }

    /// <summary>
    /// Metodo virtual di esecuzione Compito con messaggio generale
    /// </summary>
    public virtual void EseguiCompito()
    {
        Console.WriteLine("Compito generico del dipendente.");
    }

    /// <summary>
    /// Costruttore classe base con Nome e età
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="eta"></param>
    public Dipendente(string nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }

    /// <summary>
    /// Override del ToString da object per stampare
    /// </summary>
    /// <returns>Descrizione con nome e età</returns>
    public override string ToString()
    {
        return $"Nome: {Nome} Età: {Eta}";
    }

}

//Classe derivata OpCentrale
public class OperatoreCentrale : Dipendente
{
    //Campo privato turno e Proprietà con Controllo su giorno e notte
    private string _turno;
    public string Turno
    {
        get
        {
            return _turno;
        }
        set
        {
            if (value.ToLower() == "giorno" || value.ToLower() == "notte")
            {
                _turno = value.ToLower();
            }
        }
    }
    /// <summary>
    /// Costruttore Operatore Centrale con aggiunta del turno oltre al costruttore base 
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="eta"></param>
    /// <param name="turno"></param>
    public OperatoreCentrale(string nome, int eta, string turno) : base(nome, eta)
    {
        Turno = turno;
    }
    /// <summary>
    /// Metodo Esegui Compito personalizzato per opCentrale
    /// </summary>
    public override void EseguiCompito()
    {
        Console.WriteLine($"{Nome} gestisce le comunicazioni in turno {Turno}");
    }

    /// <summary>
    /// Override personalizzato per opCentrale
    /// </summary>
    /// <returns>Descrizione base + turno</returns>
    public override string ToString()
    {
        return base.ToString() + $" Turno: {Turno}";
    }
}
//Classe Meccanico derivata da dipendente
public class Meccanico : Dipendente
{
    //Proprietà pubblica di specializzazione
    public string Specializzazione { get; set; }
    /// <summary>
    /// Costruttore classe Meccanico base + specializzazione
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="eta"></param>
    /// <param name="specializzazione"></param>
    public Meccanico(string nome, int eta, string specializzazione) : base(nome, eta)
    {
        Specializzazione = specializzazione;
    }
    /// <summary>
    /// Esegui compito personalizzato che spiega il compito del meccanico
    /// </summary>
    public override void EseguiCompito()
    {
        Console.WriteLine($"{Nome} ripara mezzi specializzati in {Specializzazione}");
    }
    /// <summary>
    /// Override del toString che sfrutta il metodo base
    /// </summary>
    /// <returns>Descrizione base + specializzazione</returns>
    public override string ToString()
    {
        return base.ToString() + $" Specializzazione: {Specializzazione}" ;
    }
}

//Classe Autista derivata da dipendente
public class Autista : Dipendente
{
    //Proprietà pubblica patente
    public string Patente { get; set; }
    /// <summary>
    /// Costruttore personalizzato che riceve in input patente nome e età per creare un autista
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="eta"></param>
    /// <param name="patente"></param>
    public Autista(string nome, int eta, string patente) : base(nome, eta)
    {
        Patente = patente;
    }
    /// <summary>
    /// Funzione esegui compito per gli autisti
    /// </summary>
    public override void EseguiCompito()
    {
        Console.WriteLine($"{Nome} guida il veicolo con patente {Patente}");
    }

    /// <summary>
    /// Override funzione tostring che riprende metodo base e patente
    /// </summary>
    /// <returns>Descrizione base + patente</returns>
    public override string ToString()
    {
        return base.ToString() + $" Patente: {Patente}";
    }
}

public class Program
{
    public static void Main()
    {
        //Crezione lista dipendenti
        List<Dipendente> insiemeDipendenti = new List<Dipendente>();
        bool x = true;//variabile booleana per controllare il menu

        do
        {
            //Visualizzazione Menu e richiesta di scelta
            Console.WriteLine("1.Aggiungi un dipendente\n2.Visualizza i dipendenti\n3.Esegui tutti i compiti\n0.Esci");
            int scelta = int.Parse(Console.ReadLine());

            //Switch scelta 
            switch (scelta)
            {
                case 1:
                    insiemeDipendenti.Add(InputDipendenti());
                    break;
                case 2:
                    Visualizza(insiemeDipendenti);
                    break;
                case 3:
                    EseguiCompiti(insiemeDipendenti);
                    break;
                case 0:
                    x = false;
                    break;
            }
        } while (x);
    }

    /// <summary>
    /// Funzione di tipo dipendente che prende in input tutti i valori necessari e ritorna un dipendente specificato aggiungendolo poi nel main alla lista
    /// </summary>
    /// <returns></returns>
    public static Dipendente InputDipendenti()
    {
        Console.WriteLine("Inserisci se il dipendente è un autista o un meccanico o un operatore centrale (1,2,3)");
        int sceltaDip = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Inserisci l'età: ");
        int eta = int.Parse(Console.ReadLine());

        switch (sceltaDip)
        {
            case 1:
                Console.WriteLine("Inserisci la patente: ");
                string patente = Console.ReadLine();

                return new Autista(nome, eta, patente);
            case 2:
                Console.WriteLine("Inserisci la specializzazione: ");
                string specializzazione = Console.ReadLine();

                return new Meccanico(nome, eta, specializzazione);
            case 3:
                Console.WriteLine("Inserisci il turno:");
                string turno = Console.ReadLine();

                return new OperatoreCentrale(nome, eta, turno);
            default:
                return null;
        }

    }

    /// <summary>
    /// Funzione VIsualizza scorre la lista per stampare le descrizioni
    /// </summary>
    /// <param name="insiemeDipendenti"></param>
    public static void Visualizza(List<Dipendente> insiemeDipendenti)
    {
        foreach (Dipendente d in insiemeDipendenti)
        {
            Console.WriteLine(d);
        }
    }

    /// <summary>
    /// Funzione Esegui che scorre la lisata e esegue il metodo di ogni dipendente
    /// </summary>
    /// <param name="insiemeDipendenti"></param>
    public static void EseguiCompiti(List<Dipendente> insiemeDipendenti)
    {
        foreach (Dipendente d in insiemeDipendenti)
        {
            d.EseguiCompito();
        }
    }

}
