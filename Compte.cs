///Exercice 5
class Compte
{
    // Numéro du compte
    public string Numero { get; private set; }

    // Solde du compte
    public decimal Solde { get; private set; }

    // Constructeur
    public Compte(string numero, decimal soldeInitial)
    {
        Numero = numero;
        Solde = soldeInitial;
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
