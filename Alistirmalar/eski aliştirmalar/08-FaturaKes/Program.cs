/*
 ============================================================
  ALISTIRMA 08 - Fatura Kes                (Orta-Zor)
 ============================================================
  KONU : birden fazla if, KDV, kisi basi paylasim
 ============================================================

  PROBLEM:
  Restoranda yemek tutarini ve kisi sayisini al.
  Asagidaki kurallari uygula ve her kisiye kacak dugdugunu
  yazdir.

  KURALLAR:
    1) Yemek tutarina %20 KDV ekle.
    2) Tutar 1000 TL'yi gecerse 50 TL servis bedeli ekle.
       ("gecer" = 1000'den buyuk, esit degil)
    3) Kisi sayisi 5 veya daha fazlaysa toplamda %10 indirim
       uygula. (indirim KDV eklendikten sonraki tutara)
    4) Toplami kisi sayisina bolerek kisi basi payi bul.

  ORNEK GIRDI :  yemek 800 TL, 3 kisi
  BEKLENEN CIKTI:
      Ara toplam      : 800,00 TL
      KDV (%20)       : 160,00 TL
      Servis bedeli   : 0,00 TL      (1000 alti)
      Ara toplam      : 960,00 TL
      Indirim         : 0,00 TL      (5 kisi alti)
      Genel toplam    : 960,00 TL
      Kisi basi       : 320,00 TL

  ORNEK GIRDI :  yemek 1200 TL, 6 kisi
  BEKLENEN CIKTI:
      Ara toplam      : 1200,00 TL
      KDV (%20)       : 240,00 TL
      Servis bedeli   : 50,00 TL
      Ara toplam      : 1490,00 TL
      Indirim (%10)   : 149,00 TL
      Genel toplam    : 1341,00 TL
      Kisi basi       : 223,50 TL

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/
using System.Net;

double kdvTutari = 0;
double yemek = 0;
int kisi = 0;
int servisBedeli = 50;
double araToplam = 0;
double IndirimOrani = 0;
double anaToplam = 0;
double kisiBasiToplam = 0;


Console.Write("Yemek tutarini girin : ");
yemek = Convert.ToDouble(Console.ReadLine());

Console.Write("Kisi sayisini girin : ");
kisi = Convert.ToInt32(Console.ReadLine());

if (kisi < 1)
{
    Console.WriteLine("Hata en az 1 kişi olmak zorunda");
    return;
}

// TODO 1) KDV'yi hesapla ve tutara ekle.
kdvTutari = yemek / 5;
araToplam = yemek + kdvTutari;
// TODO 2) if ile servis bedelini ekle.e
if (araToplam > 1000)
{
    araToplam = araToplam + servisBedeli;
}
// TODO 3) if / else ile grup indirimini hesapla.
if (kisi > 5)
{
    IndirimOrani = araToplam / 10;
    anaToplam = araToplam - IndirimOrani;
}
else
{
    anaToplam = araToplam;
}
// TODO 4) Genel toplami bul ve kisi basi payi hesapla.
kisiBasiToplam = anaToplam / kisi;
// TODO 5) Tum ara adimlari ekrana yazdir.
 // Ara toplam      : 1200,00 TL
 //     KDV (%20)       : 240,00 TL
 //     Servis bedeli   : 50,00 TL
 //     Ara toplam      : 1490,00 TL
 //     Indirim (%10)   : 149,00 TL
 //    Genel toplam    : 1341,00 TL
 //     Kisi basi       : 223,50 TL
Console.WriteLine($"Ara toplam       : {yemek:C}");
Console.WriteLine($"   KDV (%20)     : {kdvTutari:C}");
Console.WriteLine($"   Servis bedeli : {servisBedeli:C} ");
Console.WriteLine($"   Ara toplam    : {araToplam:C}");
Console.WriteLine($"   Indirim (%10) : {IndirimOrani:C}");
Console.WriteLine($"   Genel Toplam  : {anaToplam:C}");
Console.WriteLine($"   Kisi basi     : {kisiBasiToplam:C}");
// TODO 6) Kisi sayisi 0 veya negatifse bastan uyari verip
//         bolme yapma. (Bunu en basta kontrol edebilirsin.)


Console.ReadKey();