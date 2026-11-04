string again = "a";

// Hlavní řídicí cyklus aplikace
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************");
    Console.WriteLine("***** Vizuální řada čísel (Schody) *****");
    Console.WriteLine("****************************************");
    Console.WriteLine("************* Tomáš Žižka **************");
    Console.WriteLine("****************************************");
    Console.WriteLine();

    // 1. Vstup počáteční hodnoty (s kontrolou na nezáporné číslo kvůli vykreslování znaků)
    Console.Write("Zadejte první číslo řady (kladné celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first) || first < 0)
    {
        Console.Write("Hodnota musí být celé nezáporné číslo. Zadejte první číslo znovu: ");
    }

    // 2. Vstup koncové hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo znovu: ");
    }

    // 3. Vstup diference s kontrolou na kladnou hodnotu
    Console.Write("Zadejte diferenci / výšku schodu (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Diference musí být kladné celé číslo větší než 0. Zadejte znovu: ");
    }

    // 4. Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference: {step}");
    Console.WriteLine("========================================");
    Console.WriteLine();

    // 5. Výpis řady a vykreslení schodiště
    Console.WriteLine("Vizuální schodiště (výpis řady):");
    if (first <= last)
    {
        int current = first;
        while (current <= last)
        {
            // Vytvoří textový blok o délce 'current' ze znaků '█'
            string blocks = new string('█', current);

            // {current, 4} zarovná číslo doprava na 4 pozice, aby svislá čára lícovala
            Console.WriteLine($"{current, 4} | {blocks}");

            current += step;
        }
    }
    else
    {
        Console.WriteLine("První číslo je větší než poslední. Tento program umí vykreslit pouze vzestupné schodiště.");
    }

    // 6. Dotaz na opakování programu
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}