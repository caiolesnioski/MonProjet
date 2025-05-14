namespace Banque.Entities;
public abstract class CompteBancaire
{
    public string Numero { get; set; }
    public string Titulaire { get; set; }

    protected double solde;

    public double Solde { get { return solde; } protected set { solde = value;} }

    // Historique des opérations
    protected List<Operation> historique;

    // Ctor : donne en valeur a un atribut
    public CompteBancaire(string numero, string titulaire, double soldeInitial = 0)
    {
        this.Numero = numero;
        Titulaire = titulaire;
        if (soldeInitial >= 0)
            solde = soldeInitial;
         else 
            solde = 0;

        historique = new List<Operation>();
        historique.Add(new Operation("Création du compte", solde));
    }
}