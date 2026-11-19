string again = "a";
Console.Clear();
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání malého "a" tak i velkého "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel ***");
    Console.WriteLine("****************************************");
    Console.WriteLine("************ Tomáš Žižka ***************");
    Console.WriteLine("****************************************");
    Console.WriteLine("****************************************");
    Console.WriteLine();

    // Vstup pro počet generovaných čísel
    Console.Write("Zadejte počet generovaných čísel (kladné celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n<=0 )
    {
        Console.Write("Nezadali jste celé kladné celé číslo! Zadejte počet čísel znovu: ");
    }

    // Vstup pro dolní mez
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte dolní mez znovu: ");
    }

    // Vstup pro horní mez
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě pro dolní mez): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo nebo je horní mez menší než dolní mez! Zadejte horní mez znovu: ");
    }

  
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("==================================");
    Console.WriteLine();    



    // Začátek konkrétního algoritmu

    // Deklarace pole a jeho alokace v paměti
    int[] myRandNumbs = new int[n];

    // Inicializace generátoru náhodných čísel
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(50); // Pevný seed pro testovací účely (vždy stejná čísla)

    // záporná, kladná a nuly
    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeros = 0;

    // sudá a lichá
    int evenNumbs = 0;
    int oddNumbs = 0;

    Console.WriteLine("Generovaná čísla: ");
    for(int i = 0; i < myRandNumbs.Length; i++ )
    {
        // Generování i-tého náhodného čísla
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");

        // kladná, záporná nebo nuly
        if(myRandNumbs[i] < 0)
           negativeNumbs++;
        else if(myRandNumbs[i] > 0)
            positiveNumbs++;
        else
            zeros++;

        // sudá a lichá čísla
        if(myRandNumbs[i] % 2 == 0)
            evenNumbs++;
        else
            oddNumbs++;     
    }

    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"Počet záporných čísel: {negativeNumbs}");
    Console.WriteLine($"Počet kladných čísel: {positiveNumbs}");
    Console.WriteLine($"Počet nul: {zeros}");
    Console.WriteLine("==================================");
    Console.WriteLine($"Počet sudých čísel: {evenNumbs}");
    Console.WriteLine($"Počet lichých čísel: {oddNumbs}");
    Console.WriteLine("==================================");
    Console.WriteLine();
    // Konec konkrétního algoritmu
    
    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}




