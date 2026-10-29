/*
 ============================================================
  ALIŞTIRMA 01 - Hafta Günü                    (Kolay)
 ============================================================
  KONU : switch-case, default, girdi kontrolü
 ============================================================

  PROBLEM:
  Kullanıcıdan 1-7 arasında bir gün numarası al.
  Numaraya karşılık gelen gün adını ve o günün
  hafta içi mi hafta sonu mu olduğunu yazdır.

  GÜN NUMARALARI:
      1 -> Pazartesi
      2 -> Salı
      3 -> Çarşamba
      4 -> Perşembe
      5 -> Cuma
      6 -> Cumartesi
      7 -> Pazar

  KURALLAR:
  - Gün adlarını bulurken mutlaka switch-case kullan.
  - 1-7 dışındaki sayılar için default bloğunda uyarı ver.
  - Hafta içi / hafta sonu ayrımını if ile yapabilirsin.

  ÖRNEK GİRDİ : 3
  BEKLENEN ÇIKTI:
      Gün      : Çarşamba
      Gün türü : Hafta içi

  ÖRNEK GİRDİ : 6
  BEKLENEN ÇIKTI:
      Gün      : Cumartesi
      Gün türü : Hafta sonu

  ÖRNEK GİRDİ : 12
  BEKLENEN ÇIKTI:
      Geçersiz gün numarası! 1-7 arasında bir sayı girin.

  ============================================================
  TODO işaretli yerleri sen dolduracaksın.
 ============================================================
*/

Console.Write("Gün numarası (1-7): ");
string girdi = Console.ReadLine() ?? "";

if (!int.TryParse(girdi, out int gun) || gun < 1 || gun > 7)
{
    Console.WriteLine("Geçersiz gün numarası! 1-7 arasında bir sayı girin.");
    return;
}

// TODO 1) switch (gun) yaz.
// TODO 2) Her case için gün adını bir değişkene ata
//         veya doğrudan Console.WriteLine ile yazdır.
// TODO 3) default bloğunda geçersiz durum için mesaj ver.
//         (Yukarıdaki if sayesinde buraya normalde gelinmez,
//          yine de default yazmayı alışkanlık hâline getir.)
// TODO 4) Gün adını yazdırdıktan sonra hafta içi /
//         hafta sonu bilgisini if ile yazdır.

Console.WriteLine();
Console.WriteLine("Kapatmak için Enter'a bas...");
Console.ReadLine();

/*
 ---------------------------------------------------------
 İPUÇLARI
 ---------------------------------------------------------
 1) switch söz dizimi:

        switch (gun)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                ...
            default:
                Console.WriteLine("Geçersiz");
                break;
        }

    Her case'in sonunda break unutma. break yoksa C#
    derleme hatası verir.

 2) Gün adını hem yazdırmak hem sonra kullanmak için
    önce bir değişkene alabilirsin:

        string gunAdi;

        switch (gun)
        {
            case 1: gunAdi = "Pazartesi"; break;
            ...
            default: gunAdi = "Geçersiz"; break;
        }

    Sonra:

        Console.WriteLine($"Gün      : {gunAdi}");
        Console.WriteLine($"Gün türü : {gunTuru}");

    Hafta içi / hafta sonu için normal if / else de olur:

        string gunTuru;
        if (gun <= 5)
        {
            gunTuru = "Hafta içi";
        }
        else
        {
            gunTuru = "Hafta sonu";
        }

 3) int.TryParse önceki alıştırmalarda gördüğün gibi
    metni sayıya çevirir. Girdi "abc" ise false döner.

 4) Gün numarası geçerliyse gun değişkeni 1-7 arasındadır.
    Bu yüzden hafta sonu kontrolü için sadece
    gun == 6 || gun == 7 yazman yeterlidir.
 ---------------------------------------------------------
 BONUS
 ---------------------------------------------------------
 - Kullanıcı "pazartesi" gibi gün adı yazarsa da
   çalışacak şekilde genişlet. (İpucu: ToLower ve
   ikinci bir switch.)
 - switch expression (=>) söz dizimini araştırıp
   aynı işi daha kısa yazmayı dene.
 ---------------------------------------------------------
*/
