using System;

public class Bakim
{
    private string aciklama;
    private DateTime tarih;

    public Bakim(string aciklama, DateTime tarih)
    {
        this.aciklama = aciklama;
        this.tarih = tarih;
    }

    public string Aciklama
    {
        get { return aciklama; }
        set { aciklama = value; }
    }

    public DateTime Tarih
    {
        get { return tarih; }
        set { tarih = value; }
    }

    public override string ToString()
    {
        return $"Bakım: {aciklama}, Tarih: {tarih.ToShortDateString()}";
    }
}
