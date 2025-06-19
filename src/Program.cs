using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<EvcilHayvan> hayvanlar = new List<EvcilHayvan>();

        while (true)
        {
            Console.WriteLine("\n--- Evcil Hayvan Yönetimi ---");
            Console.WriteLine("1. Hayvan Ekle");
            Console.WriteLine("2. Hayvanları Listele");
            Console.WriteLine("3. Aşı Ekle");
            Console.WriteLine("4. Bakım Ekle");
            Console.WriteLine("5. Hayvanın Sesini Duy");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.Write("Hayvan tipi (Kedi/Köpek): ");
                    string tur = Console.ReadLine();
                    Console.Write("İsim: ");
                    string isim = Console.ReadLine();
                    Console.Write("Yaş: ");
                    int yas = int.Parse(Console.ReadLine());

                    if (tur.ToLower() == "kedi")
                        hayvanlar.Add(new Kedi(isim, yas));
                    else if (tur.ToLower() == "köpek" || tur.ToLower() == "kopek")
                        hayvanlar.Add(new Kopek(isim, yas));
                    else
                        Console.WriteLine("Sadece Kedi veya Köpek ekleyebilirsiniz.");
                    break;

                case "2":
                    if (hayvanlar.Count == 0)
                        Console.WriteLine("Kayıtlı hayvan yok.");
                    else
                        foreach (var h in hayvanlar)
                        {
                            Console.WriteLine(h);
                            Console.WriteLine("  Aşılar:");
                            foreach (var asi in h.AsiListesi())
                                Console.WriteLine("    " + asi);
                            Console.WriteLine("  Bakımlar:");
                            foreach (var bakim in h.BakimListesi())
                                Console.WriteLine("    " + bakim);
                        }
                    break;

                case "3":
                    Console.Write("Aşı eklenecek hayvanın ismi: ");
                    string asiIsim = Console.ReadLine();
                    var hayvanAsi = hayvanlar.Find(h => h.Isim == asiIsim);
                    if (hayvanAsi == null)
                    {
                        Console.WriteLine("Hayvan bulunamadı.");
                        break;
                    }
                    Console.Write("Aşı adı: ");
                    string asiAdi = Console.ReadLine();
                    Console.Write("Aşı tarihi (yyyy-MM-dd): ");
                    DateTime asiTarihi = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    hayvanAsi.AsiEkle(new Asi(asiAdi, asiTarihi));
                    Console.WriteLine("Aşı eklendi.");
                    break;

                case "4":
                    Console.Write("Bakım eklenecek hayvanın ismi: ");
                    string bakimIsim = Console.ReadLine();
                    var hayvanBakim = hayvanlar.Find(h => h.Isim == bakimIsim);
                    if (hayvanBakim == null)
                    {
                        Console.WriteLine("Hayvan bulunamadı.");
                        break;
                    }
                    Console.Write("Bakım açıklaması: ");
                    string aciklama = Console.ReadLine();
                    Console.Write("Bakım tarihi (yyyy-MM-dd): ");
                    DateTime bakimTarihi = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    hayvanBakim.BakimEkle(new Bakim(aciklama, bakimTarihi));
                    Console.WriteLine("Bakım eklendi.");
                    break;

                case "5":
                    Console.Write("Sesini duymak istediğiniz hayvanın ismi: ");
                    string sesIsim = Console.ReadLine();
                    var hayvanSes = hayvanlar.Find(h => h.Isim == sesIsim);
                    if (hayvanSes == null)
                    {
                        Console.WriteLine("Hayvan bulunamadı.");
                        break;
                    }
                    Console.WriteLine($"{hayvanSes.Isim} şöyle ses çıkarır: {hayvanSes.SesCikar()}");
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }
}