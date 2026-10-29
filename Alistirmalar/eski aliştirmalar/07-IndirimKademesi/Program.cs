/*
 ============================================================
  ALISTIRMA 07 - Indirim Kademesi           (Orta-Zor)
 ============================================================
  KONU : if / else if zinciri, aralik kontrolu, yuzde hesabi
 ============================================================

  PROBLEM:
  Kullanicidan alisveris tutarini al. Tutarin araligina gore
  indirim uygula ve odenecek tutari bul.

  INDIRIM KADEMELERI:
      5000 TL ve uzeri   ->  %20 indirim
      3000 - 4999 TL     ->  %15 indirim
      1000 - 2999 TL     ->  %10 indirim
      1000 TL alti       ->  indirim yok

  ORNEK GIRDI :  6500
  BEKLENEN CIKTI:
      Ara toplam     : 6500,00 TL
      Indirim (%20)  : 1300,00 TL
      Odenecek       : 5200,00 TL

  ORNEK GIRDI :  4500
  BEKLENEN CIKTI:
      Ara toplam     : 4500,00 TL
      Indirim (%15)  : 675,00 TL
      Odenecek       : 3825,00 TL

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/

Console.Write("Alisveris tutarini girin : ");
double tutar = Convert.ToDouble(Console.ReadLine());
double oran;

if (tutar >= 5000)
{
    oran = 20;
}
else if (tutar >= 3000)
{
    oran = 15;
}
else if (tutar >= 1000)
{
    oran = 10;
}
else
{
    oran = 0;
}

double yapilacakIndirimTutari = (tutar * oran) / 100;

double indirimliFiyat = tutar - yapilacakIndirimTutari;

Console.WriteLine($"Ara Toplam      : {tutar:C}");
Console.WriteLine($"İndirim (%{oran})   : {yapilacakIndirimTutari:C}");
Console.WriteLine($"Odenecek        : {indirimliFiyat:C}");


Console.WriteLine();

/*
 ---------------------------------------------------------
 IPUCLARI
 ---------------------------------------------------------
 1) Aralik kontrolu iki kosul gerektirir:
        tutar >= 3000 && tutar < 5000
    Alt sinir >= , ust sinir < ile yazilir. 5000 de %20
    alacagi icin ust siniri 5000'ten kucuk tutmak gerekir.

 2) Zincirde ilk dogrulan kosul secilir ve digerlerine
    bakilmaz. Yuksekten asagi yaz:
        if      (tutar >= 5000) { oran = 20; }
        else if (tutar >= 3000) { oran = 15; }
        else if (tutar >= 1000) { oran = 10; }
        else                    { oran = 0;  }
    En altta ust siniri yazmana gerek yok, zincirin sonu
    zaten "5000'ten kucuk" demektir.

 3) Yuzde hesabi:   tutar * oran / 100
    Burada once carp, sonra bol. Yuzdeyi once bulsen de
    olur:   oran = tutar * oran / 100;

 4) Para gosterimi icin :F2 veya para birimi icin :C
        Console.WriteLine($"{tutar:C}");   // 6.500,00 TL
    Sistem diline gore para birimi simgesi degisebilir.
    Ile ilgili degilse kendi metnini elle yaz:
        Console.WriteLine($"Odenecek : {tutar:F2} TL");
 ---------------------------------------------------------
*/
