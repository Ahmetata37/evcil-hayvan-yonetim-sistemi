using System;

public class BagliListe
{
    public class Dugum
    {
        public EvcilHayvan Veri { get; set; }
        public Dugum Sonraki { get; set; }

        public Dugum(EvcilHayvan veri)
        {
            Veri = veri;
            Sonraki = null;
        }
    }

    private Dugum bas;

    public BagliListe()
    {
        bas = null;
    }

    // Başa ekle
    public void Ekle(EvcilHayvan hayvan)
    {
        Dugum yeni = new Dugum(hayvan);
        yeni.Sonraki = bas;
        bas = yeni;
    }

    // İsme göre sil
    public bool Sil(string isim)
    {
        Dugum onceki = null;
        Dugum mevcut = bas;

        while (mevcut != null)
        {
            if (mevcut.Veri.Isim == isim)
            {
                if (onceki == null)
                    bas = mevcut.Sonraki;
                else
                    onceki.Sonraki = mevcut.Sonraki;
                return true;
            }
            onceki = mevcut;
            mevcut = mevcut.Sonraki;
        }
        return false;
    }

    // Listele
    public void Listele()
    {
        Dugum mevcut = bas;
        while (mevcut != null)
        {
            Console.WriteLine(mevcut.Veri);
            mevcut = mevcut.Sonraki;
        }
    }
}