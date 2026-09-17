Compte compte = new Compte("FR123456", 1000m);

Console.WriteLine($"Numéro : {compte.Numero}");
Console.WriteLine($"Solde initial : {compte.Solde} €");

compte.Crediter(200m);
compte.Debiter(50m);

Console.WriteLine($"Nouveau solde : {compte.Solde} €");