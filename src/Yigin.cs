using System;
using System.Collections.Generic;

public class Yigin<T>
{
    private List<T> elemanlar = new List<T>();

    // Yığına eleman ekler
    public void Ekle(T eleman)
    {
        elemanlar.Add(eleman);
    }

    // Yığından eleman çıkarır (son eklenen çıkar)
    public T Cikar()
    {
        if (BosMu())
            throw new InvalidOperationException("Yığın boş.");
        int sonIndex = elemanlar.Count - 1;
        T son = elemanlar[sonIndex];
        elemanlar.RemoveAt(sonIndex);
        return son;
    }

    // Yığının tepesindeki elemanı döndürür ama çıkarmaz
    public T Bak()
    {
        if (BosMu())
            throw new InvalidOperationException("Yığın boş.");
        return elemanlar[elemanlar.Count - 1];
    }

    // Yığın boş mu kontrolü
    public bool BosMu()
    {
        return elemanlar.Count == 0;
    }
}