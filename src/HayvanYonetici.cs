using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class HayvanYonetici<T> where T : EvcilHayvan
{
    private List<T> hayvanlar;

    public HayvanYonetici()
    {
        hayvanlar = new List<T>();
    }

    public void HayvanEkle(T hayvan)
    {
        hayvanlar.Add(hayvan);
    }

    public List<T> TumHayvanlariListele()
    {
        return new List<T>(hayvanlar);
    }

    public List<T> YasaGoreBul(int yas)
    {
        return hayvanlar.Where(h => h.Yas == yas).ToList();
    }

    public List<T> TureGoreBul(string tur)
    {
        return hayvanlar.Where(h => h.Tur.Equals(tur, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // JSON'a kaydet
    public void KaydetJson(string dosyaYolu)
    {
        var ayarlar = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };
        string json = JsonSerializer.Serialize(hayvanlar, ayarlar);
        File.WriteAllText(dosyaYolu, json);
    }

    // JSON'dan yükle
    public void YukleJson(string dosyaYolu)
    {
        if (!File.Exists(dosyaYolu))
            return;

        var ayarlar = new JsonSerializerOptions
        {
            IncludeFields = true
        };
        string json = File.ReadAllText(dosyaYolu);
        hayvanlar = JsonSerializer.Deserialize<List<T>>(json, ayarlar) ?? new List<T>();
    }

    // XML'e kaydet
    public void KaydetXml(string dosyaYolu)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
        using (FileStream fs = new FileStream(dosyaYolu, FileMode.Create))
        {
            serializer.Serialize(fs, hayvanlar);
        }
    }

    // XML'den yükle
    public void YukleXml(string dosyaYolu)
    {
        if (!File.Exists(dosyaYolu))
            return;

        XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
        using (FileStream fs = new FileStream(dosyaYolu, FileMode.Open))
        {
            hayvanlar = (List<T>)serializer.Deserialize(fs);
        }
    }

    // Binary olarak kaydet
    public void KaydetBinary(string dosyaYolu)
    {
#pragma warning disable SYSLIB0011
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream(dosyaYolu, FileMode.Create))
        {
            formatter.Serialize(fs, hayvanlar);
        }
#pragma warning restore SYSLIB0011
    }

    // Binary olarak yükle
    public void YukleBinary(string dosyaYolu)
    {
        if (!File.Exists(dosyaYolu))
            return;
#pragma warning disable SYSLIB0011
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream(dosyaYolu, FileMode.Open))
        {
            hayvanlar = (List<T>)formatter.Deserialize(fs);
        }
#pragma warning restore SYSLIB0011
    }
}