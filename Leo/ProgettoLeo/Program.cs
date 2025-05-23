using System;

public class OperatoreCentrale : Dipendente
{
    public string Turno
    {
        get { return turno; }
        set
        {
            if (value.ToLower() == "giorno" || value.ToLower() == "notte")
            {
                turno = value.ToLower();
            }
        }
    }
    public OperatoreCentrale(string nome, int eta, string turno) : base(nome, eta)
    {
        Turno = turno;
    }
    public virtual override EseguiCompito()
    {
        Console.Writeline($"Gestisce le comunicazioni in turno {Turno}")
    }
}
public class Meccanico : Dipendente 
{
    public string Specializzazione { get; set; }
    public Meccanico(string nome, int eta, string specializzazione) : base(nome, eta)
    {
        Specializzazione = specializzazione;
    }
    public virtual override EseguiCompito()
    {
        Console.Writeline($"Ripara mezzi specializzati in {Specializzazione}")
    }
}