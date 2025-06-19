using System;

public class Kopek : EvcilHayvan
{
    public Kopek(string isim, int yas) : base(isim, "Köpek", yas)
    {
    }

    public override string SesCikar()
    {
        return "Hav hav!";
    }
}