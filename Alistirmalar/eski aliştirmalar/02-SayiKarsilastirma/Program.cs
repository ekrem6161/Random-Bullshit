/*
 ============================================================
  ALISTIRMA 02 - Sayi Karsilastirma        (Kolay)
 ============================================================
  KONU : if / else , karsilastirma operatorleri
 ============================================================

  PROBLEM:
  Iki sayi al. Hangisi buyuk, esit mi yoksa kucuk mu
  oldugunu if / else ile bul ve yazdir.

  ORNEK GIRDI :  15 ve  9
  BEKLENEN CIKTI:
      15 sayisi 9 sayisindan buyuktur.

  DIGER ORNEKLER:
      5 ve 5  ->  "5 sayisi 5 sayisine esittir."
      2 ve 10 ->  "2 sayisi 10 sayisindan kucuktur."

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/

int sayi1, sayi2;

Console.Write("1. Sayıyı girin  ");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sayıyı girin  ");
sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi1 == sayi2)
{
    Console.WriteLine(sayi1 + "  sayisi  " + sayi2 + "  sayisina eşittir  ");
}
else if (sayi1 > sayi2)
{
    Console.WriteLine(sayi1 + "  sayisi  " + sayi2 + "  sayisindan buyuktur  ");
}
else
{
    Console.WriteLine(sayi1 + "  sayisi  " + sayi2 + "  sayisindan kuçuktur  ");
}