def zadanie1():
    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    op = input("Operacja (+, -, *, /): ")

    if op == "+": wynik = a + b
    elif op == "-": wynik = a - b
    elif op == "*": wynik = a * b
    elif op == "/":
        if b == 0:
            print("Błąd: dzielenie przez zero!"); return
        wynik = a / b
    else:
        print("Nieznana operacja."); return

    print(f"Wynik: {wynik}")


def zadanie2():
    kierunek = input("Kierunek (C = °C→°F, F = °F→°C): ").upper()
    temp = float(input("Temperatura: "))

    if kierunek == "C":
        print(f"{temp}°C = {temp * 1.8 + 32}°F")
    elif kierunek == "F":
        print(f"{temp}°F = {(temp - 32) / 1.8:.2f}°C")
    else:
        print("Nieprawidłowy wybór.")
        

def zadanie3():
    n = int(input("Liczba ocen: "))
    oceny = [float(input(f"Ocena {i}: ")) for i in range(1, n + 1)]
    avg = sum(oceny) / len(oceny)
    print(f"Średnia: {avg:.2f}  {'Uczeń zdał.' if avg >= 3.0 else 'Uczeń nie zdał.'}")


while True:
    print("\n=== MENU ===")
    print("1. Kalkulator")
    print("2. Konwerter temperatur")
    print("3. Średnia ocen")

    match input("Wybierz zadanie (1-3): "):
        case "1": zadanie1()
        case "2": zadanie2()
        case "3": zadanie3()
        case _:   print("Nieprawidłowa opcja.")

    if input("Czy chcesz powtórzyć? (t/n): ").lower() != "t":
        print("Do widzenia!")
        break
