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

    // Vstup počáteční hodnoty - špatně řešený
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first =int.Parse(Console.ReadLine());  

    


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}


