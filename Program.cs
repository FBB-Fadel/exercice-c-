decimal solde = 1000m;
decimal montant = 150m;

if(montant > 0)
{
    solde += montant;
}
else if (montant < 0)
{
    decimal débit = -montant;
    if(débit <= solde)
    {
        solde -= débit;
    }
    else
    {
        Console.WriteLine("solde Insuffisant");
    }
}
Console.WriteLine($"Solde: {solde}");

public decimal Crediter(decimal montant, decimal solde)
{
    if(montant >0)
}
{
    
}

