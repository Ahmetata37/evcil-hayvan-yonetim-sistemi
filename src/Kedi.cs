using System;

public class Kedi : EvcilHayvan
{
    public Kedi(string isim, int yas) : base(isim, "Kedi", yas)
    {
    }

    public override string SesCikar()
    {
        return "Miyav!";
    }
}