/*
    Napisz program, który pyta użytkownika o podanie liczby całkowitych a w wyniku wypisuje komunikat o ilości cyfr.
*/

Console.WriteLine("Podaj liczbę całkowitą: ");

string str = Console.ReadLine();

if(str.Length >= 2) Console.WriteLine("Liczba {0} posiada {1} cyfry.", str, str.Length);
    else Console.WriteLine("Liczba {0} posiada {1} cyfrę.", str, str.Length);