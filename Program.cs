var compteCourant = new CompteCourant(
    "CC001",
    "Alice",
    1000m
);

var compteEpargne = new CompteEpargne(
    "CE001",
    "Bob",
    2000m,
    2.5m
);

// Compte courant
Console.WriteLine("Compte courant");
Console.WriteLine($"Numéro : {compteCourant.Numero}");
Console.WriteLine($"Titulaire : {compteCourant.Titulaire}");
Console.WriteLine($"Solde : {compteCourant.Solde} €");

Console.WriteLine();

// Compte épargne
Console.WriteLine("Compte épargne");
Console.WriteLine($"Numéro : {compteEpargne.Numero}");
Console.WriteLine($"Titulaire : {compteEpargne.Titulaire}");
Console.WriteLine($"Solde : {compteEpargne.Solde} €");
Console.WriteLine($"Taux d'intérêt : {compteEpargne.TauxInteret} %");

