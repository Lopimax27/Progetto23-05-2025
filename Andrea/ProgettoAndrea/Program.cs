public class Autista : Dipendente 
{
    public string Patente { get; set; }
    public Autista(string nome, int eta, string patente) : base(nome, eta)
    {
        Patente = patente;
    }
    public virtual override EseguiCompito()
    {
        Console.Writeline($"Guida il veicolo con patente {Patente}");
    }
}