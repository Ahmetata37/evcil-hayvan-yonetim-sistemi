using System;

public class IkiliAramaAgaci
{
    public class Dugum
    {
        public EvcilHayvan Veri { get; set; }
        public Dugum Sol { get; set; }
        public Dugum Sag { get; set; }

        public Dugum(EvcilHayvan veri)
        {
            Veri = veri;
            Sol = null;
            Sag = null;
        }
    }

    private Dugum kok;

    public IkiliAramaAgaci()
    {
        kok = null;
    }

    // İsme göre ekle (alfabetik sıralama)
    public void Ekle(EvcilHayvan hayvan)
    {
        kok = EkleRec(kok, hayvan);
    }

    private Dugum EkleRec(Dugum dugum, EvcilHayvan hayvan)
    {
        if (dugum == null)
            return new Dugum(hayvan);

        int cmp = string.Compare(hayvan.Isim, dugum.Veri.Isim, StringComparison.OrdinalIgnoreCase);
        if (cmp < 0)
            dugum.Sol = EkleRec(dugum.Sol, hayvan);
        else if (cmp > 0)
            dugum.Sag = EkleRec(dugum.Sag, hayvan);
        // Aynı isim varsa ekleme
        return dugum;
    }

    // İsme göre ara
    public EvcilHayvan AraIsmeGore(string isim)
    {
        Dugum mevcut = kok;
        while (mevcut != null)
        {
            int cmp = string.Compare(isim, mevcut.Veri.Isim, StringComparison.OrdinalIgnoreCase);
            if (cmp == 0)
                return mevcut.Veri;
            else if (cmp < 0)
                mevcut = mevcut.Sol;
            else
                mevcut = mevcut.Sag;
        }
        return null;
    }

    // Yaşa göre ara (ilk bulduğunu döndürür)
    public EvcilHayvan AraYasaGore(int yas)
    {
        return AraYasaGoreRec(kok, yas);
    }

    private EvcilHayvan AraYasaGoreRec(Dugum dugum, int yas)
    {
        if (dugum == null)
            return null;
        if (dugum.Veri.Yas == yas)
            return dugum.Veri;
        var sol = AraYasaGoreRec(dugum.Sol, yas);
        if (sol != null)
            return sol;
        return AraYasaGoreRec(dugum.Sag, yas);
    }

    // Sırayla gez (in-order traversal)
    public void SiraliGez()
    {
        SiraliGezRec(kok);
    }

    private void SiraliGezRec(Dugum dugum)
    {
        if (dugum == null)
            return;
        SiraliGezRec(dugum.Sol);
        Console.WriteLine(dugum.Veri);
        SiraliGezRec(dugum.Sag);
    }
}