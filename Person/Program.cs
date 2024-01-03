using System;

class Program
{
    static void Main()
    {
        // Przykład utworzenia obiektu klasy Osoba
        Osoba osoba = new Osoba("Jan", "Kowalski", 'M', new DateTime(1990, 1, 1));
        Console.WriteLine($"Imię: {osoba.Imie}, Nazwisko: {osoba.Nazwisko}, Płeć: {osoba.Plec}, Data Urodzenia: {osoba.DataUrodzenia.ToShortDateString()}");
    }
}
