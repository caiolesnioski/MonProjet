public class Banque()
{ 

    private List<banque> listBanque = new List<banque>();  


    public Debut()
    {
        // Initialisation de la liste des comptes
        listBanque = new List<banque>();
    }


    public void inicialisation()
    {  
            while(true)
            {
                //afficher le menu
                AfficherMenu();
            }
        {
        //afficher le menu
        Console.WriteLine("Menu :");
        Console.WriteLine("1. Créer un compte");
        Console.WriteLine("2. Suppression d'un compte");
        Console.WriteLine("3. Trouver un compte");
        Console.WriteLine("4. Effectuer un virement");
        Console.WriteLine("5. Sortir");
    
        string choix = Console.ReadLine();

        switch (choix)
        {
            case "1";
                CreerCompte();
                break;
            case "2";
                SupprimerCompte();
                break;
            case "3";
                TrouverCompte();
                break;
            case "4";
                EffectuerVirement();
                break;
            case "5";
                Console.WriteLine("Au revoir !");
                continue = false;
                break;
            default:
                Console.WriteLine("Choix invalide, veuillez réessayer.");
            break;


        }
    }
    public void CreerCompte()
    {

        Console.WriteLine("Saisir le nom du titulaire :");

            string titulaire = Console.ReadLine();

        Console.WriteLine("Saisir le solde initial :");

            double solde = double.Parse(Console.ReadLine());

        Console.WriteLine("Saisir le numéro de compte :");

        string numeroCompte = Console.ReadLine();

        banque compte = new banque(titulaire, solde, numeroCompte);
        listBanque.Add(compte);

        Console.WriteLine("Compte créé avec succès !");
    }
    public void SupprimerCompte()
    {
        Console.WriteLine("Saisir le numéro de compte à supprimer :");
        string numeroCompte = Console.ReadLine();

        banque compteASupprimer = listBanque.FirstOrDefault(c => c.NumeroCompte == numeroCompte);

        if (compteASupprimer != null)
        {
            listBanque.Remove(compteASupprimer);
            Console.WriteLine("Compte supprimé avec succès !");
        }
        else
        {
            Console.WriteLine("Compte non trouvé.");
        }
    }
    public void TrouverCompte()
    {

        Console.WriteLine("Saisir le numéro de compte à trouver :");
        string numeroCompte = Console.ReadLine();

        banque compteTrouve = listBanque.FirstOrDefault(c => c.NumeroCompte == numeroCompte);

        if (compteTrouve != null)
        {
            Console.WriteLine("Compte trouvé :");
            Console.WriteLine("Titulaire : " + compteTrouve.Titulaire);
            Console.WriteLine("Solde : " + compteTrouve.Solde);
            Console.WriteLine("Numéro de compte : " + compteTrouve.NumeroCompte);
        }
        else
        {
            Console.WriteLine("Compte non trouvé.");
        }
    }
    public void EffectuerVirement()
    {
        Console.WriteLine("Saisir le numéro de compte source :");
        string numeroCompteSource = Console.ReadLine();

        Console.WriteLine("Saisir le numéro de compte destination :");
        string numeroCompteDestination = Console.ReadLine();

        Console.WriteLine("Saisir le montant à virer :");
        double montant = double.Parse(Console.ReadLine());

        banque compteSource = listBanque.FirstOrDefault(c => c.NumeroCompte == numeroCompteSource);
        banque compteDestination = listBanque.FirstOrDefault(c => c.NumeroCompte == numeroCompteDestination);

        if (compteSource != null && compteDestination != null)
        {
            compteSource.Retirer(montant);
            compteDestination.Deposer(montant);
            Console.WriteLine("Virement effectué avec succès !");
        }
        else
        {
            Console.WriteLine("Un ou plusieurs comptes non trouvés.");
        }
    }
    public void AfficherComptes()
    {
        Console.WriteLine("Liste des comptes :");
        foreach (var compte in listBanque)
        {
            Console.WriteLine("Titulaire : " + compte.Titulaire);
            Console.WriteLine("Solde : " + compte.Solde);
            Console.WriteLine("Numéro de compte : " + compte.NumeroCompte);
            Console.WriteLine("--------------------------------------------------");
        }
    }


}
