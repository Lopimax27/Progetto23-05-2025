using System;

public class Dipendente
{
    private string _nome;
    private int _eta;

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

    public virtual void EseguiCompito()
    {
        Console.WriteLine("Compito generico del dipendente.");
    }

    public Dipendente(string nome, int eta)
    {
        _nome = nome;
        _eta = eta;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} Età: {Eta}";
    }

}

public class OperatoreCentrale : Dipendente
{
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
    public OperatoreCentrale(string nome, int eta, string turno) : base(nome, eta)
    {
        Turno = turno;
    }
    public override void EseguiCompito()
    {
        Console.WriteLine($"{Nome} gestisce le comunicazioni in turno {Turno}");
    }

    public override string ToString()
    {
        return base.ToString() + $" Turno: {Turno}" ;
    }
}
public class Meccanico : Dipendente
{
    public string Specializzazione { get; set; }
    public Meccanico(string nome, int eta, string specializzazione) : base(nome, eta)
    {
        Specializzazione = specializzazione;
    }
    public override void EseguiCompito()
    {
        Console.WriteLine($"{Nome} ripara mezzi specializzati in {Specializzazione}");
    }

    public override string ToString()
    {
        return base.ToString() + $" Specializzazione: {Specializzazione}" ;
    }
}

public class Autista : Dipendente
{
    public string Patente { get; set; }
    public Autista(string nome, int eta, string patente) : base(nome, eta)
    {
        Patente = patente;
    }
    public override void EseguiCompito()
    {
        Console.WriteLine($"{Nome} guida il veicolo con patente {Patente}");
    }

    public override string ToString()
    {
        return base.ToString() + $" Patente: {Patente}" ;
    }
}

public class Program
{
    public static void Main()
    {
        List<Dipendente> insiemeDipendenti = new List<Dipendente>();
        bool x = true;

        do
        {
            Console.WriteLine("1.Aggiungi un dipendente\n2.Visualizza i dipendenti\n3.Esegui tutti i compiti\n0.Esci");
            int scelta = int.Parse(Console.ReadLine());

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

    public static void Visualizza(List<Dipendente> insiemeDipendenti)
    {
        foreach (Dipendente d in insiemeDipendenti)
        {
            Console.WriteLine(d);
        }
    }

    public static void EseguiCompiti(List<Dipendente> insiemeDipendenti)
    {
        foreach (Dipendente d in insiemeDipendenti)
        {
            d.EseguiCompito();
        }
    }

}
