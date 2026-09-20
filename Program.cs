
var compte1 = new Compte("FR001", "Alice");

var compte2 = new Compte("FR002", "Bob", 500m);

///Affichage des information
Console.WriteLine($"Numéro : {compte1.Numero}");
Console.WriteLine($"Titulaire : {compte1.Titulaire}");
Console.WriteLine($"Solde : {compte1.Solde}€");
Console.WriteLine($"Nouveau Solde : {compte1.Solde}€");

///Affichage des information 2eme compte
Console.WriteLine();
Console.WriteLine("Compte 2");
Console.WriteLine($"Numéro : {compte2.Numero}");
Console.WriteLine($"Titulaire : {compte2.Titulaire}");
Console.WriteLine($"Solde : {compte2.Solde}€");
Console.WriteLine($"Nouveau Solde : {compte2.Solde}€");