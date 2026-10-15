// Toto je jednořádkový komentář

/* Toto je
víceřádkový
komentář */ 


// Nejprve budeme řešit opakování programu

string again = "a";
Console.Clear();
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání malého "a" tak i velkého "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("************ Výpis řady ***************");
    Console.WriteLine("***************************************");
    Console.WriteLine("************ Tomáš Žižka **************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    // Vstup počáteční hodnoty - špatně řešený
    // Console.Write("Zadejte první číslo řady (celé číslo): ");
    // int first =int.Parse(Console.ReadLine()); 

    // Vstup počáteční hodnoty - řešený správně 
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první číslo řady znovu (celé číslo): ");
    }

    // Vstup konečné hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte poslední číslo řady znovu (celé číslo): ");
    }

    // Vstup pro diferenci s kontrolou na kladnou hodnotu
    Console.Write("Zadejte diferenece (kladné celé číslo): ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0 )
    {
        Console.Write("Nezadali jste kladné celé číslo! Zadejte diferenci znovu (kladné celé číslo): ");
    }

    


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}


