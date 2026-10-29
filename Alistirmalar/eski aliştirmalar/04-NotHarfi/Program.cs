/*
 ============================================================
  ALISTIRMA 04 - Not Harfi                 (Orta)
 ============================================================
  KONU : if / else if / else zinciri, aralik kontrolu
 ============================================================

  PROBLEM:
  Kullanicidan 0-100 arasi bir not al ve harf notunu yazdir.
  Gecersiz bir not girilirse uyari ver.

  HARF NOTLARI:
      90 - 100  ->  AA
      75 - 89   ->  BA
      60 - 74   ->  BB
      50 - 59   ->  CC
      40 - 49   ->  DD
       0 - 39   ->  FF

  DIKKAT:
  89 ve 75 de dahil. Yani AA icin >= 90, BA icin >= 75
  yazman yeterli, ayri bir kontrol yapmana gerek yok.
  Cunku yuksekten asagi kontrol edersen 75 ve uzeri zaten
  90'dan kucuk kalmis olur.

  ORNEK GIRDI :  85
  BEKLENEN CIKTI:
      Notunuz: 85
      Harf notunuz: BA

  ORNEK GIRDI :  120
  BEKLENEN CIKTI:
      Gecersiz not! Not 0 ile 100 arasinda olmalidir.

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/
int not;

Console.Write("Notunuzu girin (0-100) : ");
not = Convert.ToInt32(Console.ReadLine());

if (not < 0 || not > 100)
{
    Console.WriteLine("Geçersiz not! Not 0 ile 100 arasında olmalıdır.");
}
else if (not >= 90)
{
    Console.WriteLine("Notunuz:  " + not);
    Console.WriteLine("Harf Notunuz:  AA");
}
else if (not >= 75)
{
    Console.WriteLine("Notunuz:  " + not);
    Console.WriteLine("Harf Notunuz:  BA");
}
else if (not >= 60)
{
    Console.WriteLine("Notunuz:  " + not);
    Console.WriteLine("Harf Notunuz:  BB");
}
else if (not >= 50)
{
    Console.WriteLine("Notunuz:  " + not);
    Console.WriteLine("Harf Notunuz:  CC");
}
else if (not >= 40)
{
    Console.WriteLine("Notunuz:  " + not);
    Console.WriteLine("Harf Notunuz:  DD");
}
else
{
    Console.WriteLine("Notunuz:  " + not);
    Console.WriteLine("Harf Notunuz:  FF");
}