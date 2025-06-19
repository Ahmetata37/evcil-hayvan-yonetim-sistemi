using System;

public class Asi
{
    private string asiAdi;
    private DateTime tarih;

    public Asi(string asiAdi, DateTime tarih)
    {
        this.asiAdi = asiAdi;
        this.tarih = tarih;
    }

    public string AsiAdi
    {
        get { return asiAdi; }
        set { asiAdi = value; }
    }

    public DateTime Tarih
    {
        get { return tarih; }
        set { tarih = value; }
    }

    public override string ToString()
    {
        return $"Aşı: {asiAdi}, Tarih: {tarih.ToShortDateString()}";
    }
}
