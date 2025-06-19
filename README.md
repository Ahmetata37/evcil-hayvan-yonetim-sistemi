# Evcil Hayvan Yönetim Sistemi

Bu proje, C# ile yazılmış, evcil hayvanların ve onların bakım/aşı bilgilerinin yönetilebildiği bir uygulamadır.

## Özellikler

- **Soyut Sınıf ve Kalıtım:**  
  `EvcilHayvan` soyut sınıfı ve ondan türeyen `Kedi`, `Kopek` gibi sınıflar.
- **Arayüz (Interface):**  
  `IBakimGerekli` arayüzü ile bakım gerekliliği kontrolü.
- **Generic Veri Yapıları:**  
  - `Kuyruk<T>`: FIFO prensibiyle çalışan kuyruk.
  - `Yigin<T>`: LIFO prensibiyle çalışan yığın.
- **Bağlı Liste:**  
  Kendi yazdığımız tek yönlü bağlı liste ile hayvanları tutma.
- **İkili Arama Ağacı (BST):**  
  Hayvanları isme veya yaşa göre hızlı bulmak için.
- **Serileştirme:**  
  - JSON, XML ve Binary formatlarında veri kaydetme ve geri alma.
- **Konsol Menüsü:**  
  Kullanıcı dostu, Türkçe konsol menüsü ile işlem yapabilme.

## Kullanılan Teknolojiler

- C# 9.0+
- .NET 9.0
- System.Text.Json
- System.Xml.Serialization
- System.Runtime.Serialization.Formatters.Binary

## Başlatma

```bash
dotnet build
dotnet run --project src
```

## Dosya Yapısı

```
src/
├── Asi.cs
├── Bakim.cs
├── EvcilHayvan.cs
├── Kedi.cs
├── Kopek.cs
├── IBakimGerekli.cs
├── Kuyruk.cs
├── Yigin.cs
├── BagliListe.cs
├── IkiliAramaAgaci.cs
├── HayvanYonetici.cs
├── Program.cs
```

## Açıklamalar

- **EvcilHayvan.cs:** Soyut temel sınıf, hayvan bilgileri ve bakım/aşı listeleri.
- **Kedi.cs, Kopek.cs:** EvcilHayvan’dan türeyen, ses çıkarma gibi özellikleri override eden sınıflar.
- **IBakimGerekli.cs:** Bakım gerekliliğini soyutlayan arayüz.
- **Kuyruk.cs, Yigin.cs:** Generic veri yapıları.
- **BagliListe.cs:** Kendi yazdığımız bağlı liste.
- **IkiliAramaAgaci.cs:** Kendi yazdığımız ikili arama ağacı.
- **HayvanYonetici.cs:** Generic yönetici sınıfı, serileştirme desteğiyle.
- **Program.cs:** Konsol menüsü ve uygulama giriş noktası.

## Katkı ve Lisans

Bu proje eğitim amaçlıdır. Katkıda bulunmak için pull request gönderebilirsiniz.