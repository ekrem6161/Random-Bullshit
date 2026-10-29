/*
 ============================================================
  ALISTIRMA 03 - Ortalama ve Kurus Kaybi      (Kolay)
 ============================================================
  KONU : double degiskenler, ondalik bolme, gece / gündüz
 ============================================================

  PROBLEM:
  Kullanicidan 3 sınav notu al. Ortalamayi bul ve 50 ustu
  mu altinda mi diye if / else ile bildir.

  ORNEK GIRDI :  70, 80, 90
  BEKLENEN CIKTI:
      Ortalama : 80
      Gectiniz!

  ORNEK GIRDI :  45, 50, 30
  BEKLENEN CIKTI:
      Ortalama : 41.67
      Kaldiniz.

  DIKKAT:
  70 + 80 + 90 = 240 ,  240 / 3 = 80 tam sayi.
  45 + 50 + 30 = 125 ,  125 / 3 = 41.666...
  Ikinci ornekte ondalik yazdigin halde ekrana 41 yazarsa
  bu bir hata degil, tam sayi bolmenin sonucudur.
  Ortalamayi 3 yerine 3.0 ile bolmeyi dene.

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/

int sayi1, sayi2, sayi3;
double ortalama;

Console.Write("1. Notu Giriniz  ");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Notu Giriniz  ");
sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. Notu Giriniz  ");
sayi3 = Convert.ToInt32(Console.ReadLine());

ortalama = (sayi1 + sayi2 + sayi3) / 3.0;
Console.WriteLine("Ortalamanız  " + ortalama.ToString("F2"));
if (ortalama >= 50)
{
    Console.WriteLine("Sınavı geçtiniz");
}
else
{
    Console.WriteLine("Sınavı kaybettiniz");
}
