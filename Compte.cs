///Exercice 5
class Compte
{
    // Numéro du compte
    public string Numero { get; private set; }

    // Titulaire du compte
    public string Titulaire {get; private set; }

    // Solde du compte
    public decimal Solde { get; private set; }

    // Constructeur
    public Compte(string numero, string titulaire, decimal soldeInitial)
    {
        Numero = numero;
        Titulaire = Titulaire;
        Solde = soldeInitial;
    }

    public Compte(string numero,string titulaire)
        :this(numero,titulaire,0m)
    {
        
    }


    // Ajouter de l'argent
    public void Crediter(decimal montant)
    {
        if (montant > 0)
        {
            Solde += montant;
        }
    }

    // Retirer de l'argent
    public void Debiter(decimal montant)
    {
        if (montant > 0 && montant <= Solde)
        {
            Solde -= montant;
        }
    }
}
