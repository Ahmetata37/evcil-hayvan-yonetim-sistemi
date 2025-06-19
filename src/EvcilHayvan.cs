using System;
using System.Collections.Generic;

public abstract class EvcilHayvan : IBakimGerekli
{
    private string isim;
    private string tur;
    private int yas;

    private List<Asi> asilar;
    private List<Bakim> bakimlar;

    public EvcilHayvan(string isim, string tur, int yas)
    {
        this.isim = isim;
        this.tur = tur;
        this.yas = yas;
        this.asilar = new List<Asi>();
        this.bakimlar = new List<Bakim>();
    }

    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }

    public string Tur
    {
        get { return tur; }
        set { tur = value; }
    }

    public int Yas
    {
        get { return yas; }
        set { yas = value; }
    }

    public void AsiEkle(Asi asi)
    {
        asilar.Add(asi);
    }

    public List<Asi> AsiListesi()
    {
        return new List<Asi>(asilar);
    }

    public void BakimEkle(Bakim bakim)
    {
        bakimlar.Add(bakim);
    }

    public List<Bakim> BakimListesi()
    {
        return new List<Bakim>(bakimlar);
    }

    public abstract string SesCikar();

    // Yaşı 5'ten büyükse bakım gerekli kabul edilsin (örnek)
    public virtual bool BakimGerekliMi()
    {
        return yas > 5;
    }

    public override string ToString()
    {
        return $"İsim: {isim}, Tür: {tur}, Yaş: {yas}";
    }
}