using System;

namespace Banque.Entities;

public class CompteCourant : CompteBancaire
{
    public bool DecouvertPossible { get; set; } = false;
    public double DecouvertAutorise { get; set; }
    public double FraisMensuels { get; set;}


    public CompteCourant(string numero, string titulaire, double soldeInitial, double fraisMensuels, bool decouvertPossible) : base(numero, titulaire, soldeInitial)
    {
        DecouvertPossible = decouvertPossible;
        DecouvertAutorise = DecouvertPossible ? 100 : 0;
    }

public void Deposer(double montant)
{
    if (montant > 0)
    {
        solde += montant;
        Console.WriteLine("Montant déposé : " + montant);
    }
    else
    {
        Console.WriteLine("Montant invalide")
    }
}
public void Retirer(double montant)
{
    if (montant > 0 && montant <= solde)
    {
        solde -= montant;
        Console.WriteLine("Montant retiré : " + montant);
    }
    else
    {
        Console.WriteLine("Montant invalide ou solde insuffisant");
    }
}
public void AfficherSolde()
{
    Console.WriteLine("Solde actuel : " + solde);
}
public abstract class  CompteBancaire 
    public CompteBancaire(string titulaire, double soldeInicial , string numeroCompte)
    {
        this.titulaire = titulaire;
        this.solde = soldeInicial;
        this.numeroCompte = numeroCompte;
    }
    
}




}