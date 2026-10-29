/*
 ============================================================
  ALISTIRMA 01 - Iki Sayi Toplama          (Kolay)
 ============================================================
  KONU : int degiskenler, Console.ReadLine, tip donusumu,
         toplama ve ortalama hesabi
 ============================================================

  PROBLEM:
  Kullanicidan iki tam sayi al. Toplamini ve ortalamasini
  ekrana yazdir.

  ORNEK GIRDI :  7 ve  10
  BEKLENEN CIKTI:
      Toplam   : 17
      Ortalama : 8.5

  ============================================================
  Asagidaki kod calistirilabilir durumda. TODO isaretli
  yerleri sen dolduracaksin.
 ============================================================
*/

int sayi1, sayi2, toplam;
double ortalama;

Console.Write("1.Sayıyı giriniz  ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2.Sayıyı giriniz  ");
sayi2 = Convert.ToInt32(Console.ReadLine());

ortalama = (sayi1 + sayi2) / 2.0;
toplam = sayi1 + sayi2;

Console.WriteLine("Toplam   :" + toplam);
Console.WriteLine("Ortalama :" + ortalama);
