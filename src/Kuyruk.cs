using System;
using System.Collections.Generic;

public class Kuyruk<T>
{
    private List<T> elemanlar = new List<T>();

    // Kuyruğa eleman ekler
    public void Ekle(T eleman)
    {
        elemanlar.Add(eleman);
    }

    // Kuyruktan eleman çıkarır (ilk eklenen çıkar)
    public T Cikar()
    {
        if (BosMu())
            throw new InvalidOperationException("Kuyruk boş.");
        T ilk = elemanlar[0];
        elemanlar.RemoveAt(0);
        return ilk;
    }

    // Kuyruğun başındaki elemanı döndürür ama çıkarmaz
    public T Bak()
    {
        if (BosMu())
            throw new InvalidOperationException("Kuyruk boş.");
        return elemanlar[0];
    }

    // Kuyruk boş mu kontrolü
    public bool BosMu()
    {
        return elemanlar.Count == 0;
    }
}