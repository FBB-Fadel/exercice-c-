class CompteEpargne : Compte
{
    // Taux d'intérêt
    public decimal TauxInteret { get; private set; }

    // Constructeur
    public CompteEpargne(
        string numero,
        string titulaire,
        decimal soldeInitial,
        decimal tauxInteret)
        : base(numero, titulaire, soldeInitial)
    {
        TauxInteret = tauxInteret;
    }
}