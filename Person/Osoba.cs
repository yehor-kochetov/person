﻿using System;

public class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public char Plec { get; set; } // M dla mężczyzny, K dla kobiety
    public DateTime DataUrodzenia { get; set; }

    // Konstruktor
    public Osoba(string imie, string nazwisko, char plec, DateTime dataUrodzenia)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Plec = plec;
        DataUrodzenia = dataUrodzenia;
    }
}
