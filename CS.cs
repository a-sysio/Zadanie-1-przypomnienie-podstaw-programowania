using System;

class Zadania
{
    static void Zadanie1()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine()!);
        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine()!);
        Console.Write("Operacja (+, -, *, /): ");
        string op = Console.ReadLine()!;

        double wynik;
        switch (op)
        {
            case "+": wynik = a + b; break;
            case "-": wynik = a - b; break;
            case "*": wynik = a * b; break;
            case "/":
                if (b == 0) { Console.WriteLine("Błąd: dzielenie przez zero!"); return; }
                wynik = a / b; break;
            default:
                Console.WriteLine("Nieznana operacja."); return;
        }
        Console.WriteLine($"Wynik: {wynik}");
    }

    static void Zadanie2()
    {
        Console.Write("Kierunek (C = °C→°F, F = °F→°C): ");
        string k = Console.ReadLine()!.ToUpper();
        Console.Write("Temperatura: ");
        double t = double.Parse(Console.ReadLine()!);

        switch (k)
        {
            case "C": Console.WriteLine($"{t}°C = {t * 1.8 + 32}°F"); break;
            case "F": Console.WriteLine($"{t}°F = {(t - 32) / 1.8:F2}°C"); break;
            default: Console.WriteLine("Nieprawidłowy wybór."); break;
        }
    }

    static void Zadanie3()
    {
        Console.Write("Liczba ocen: ");
        int n = int.Parse(Console.ReadLine()!);
        double suma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ocena {i}: ");
            suma += double.Parse(Console.ReadLine()!);
        }
        
        double avg = suma / n;
        Console.WriteLine($"Średnia: {avg:F2}  {(avg >= 3.0 ? "Uczeń zdał." : "Uczeń nie zdał.")}");
    }

    static void Main()
    {
        bool powtorz = true;

        while (powtorz)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Kalkulator");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen");
            Console.Write("Wybierz zadanie (1-3): ");

            switch (Console.ReadLine())
            {
                case "1": Zadanie1(); break;
                case "2": Zadanie2(); break;
                case "3": Zadanie3(); break;
                default: Console.WriteLine("Nieprawidłowa opcja."); break;
            }
            Console.Write("Czy chcesz powtórzyć? (t/n): ");
            powtorz = Console.ReadLine()!.ToLower() == "t";
        }
        Console.WriteLine("Do widzenia!");
    }
}
