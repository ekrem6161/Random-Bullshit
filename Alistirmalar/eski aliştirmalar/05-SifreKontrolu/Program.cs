/*
 ============================================================
  ALISTIRMA 05 - Sifre Kontrolu            (Orta)
 ============================================================
  KONU : && , || , string ile calisma, string.Length
 ============================================================

  PROBLEM:
  Kullanicidan bir sifre al. Sifre asagidaki tum kurallari
  sagliyorsa "Sifre gecerli", saglamiyorsa hangi kuralin
  bozuldugunu yazdir.

  KURALLAR:
    1) En az 8 karakter uzunlugunda olmali
    2) En az 1 rakam icermeli
    3) Kucuk ve buyuk harflerin ikisini de icermeli
    4) "sifre" kelimesini icermemeli

  ORNEK GIRDI :  Sifre123
  BEKLENEN CIKTI:
      Sifre gecerli.

  ORNEK GIRDI :  kisa1
  BEKLENEN CIKTI:
      En az 8 karakter uzunlugunda olmali.

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/

using System.Linq;

Console.Write("Sifrenizi girin : ");
string sifre = Console.ReadLine() ?? "";
int karaktersayisi = sifre.Length;
bool rakamvarmi = sifre.Any(char.IsDigit);
bool kucukbuyukvarmi =
    sifre.Any(char.IsUpper) &&
    sifre.Any(char.IsLower);
bool sifrekelimeiceriyormu = sifre.Contains("sifre");

if (karaktersayisi < 8)
{
    Console.WriteLine("Sifre en az 8 karakter uzunlugunda olmalıdır");
}
else if (!rakamvarmi)
{
    Console.WriteLine("Sifre en az 1 rakam içermelidir");
}
else if (!kucukbuyukvarmi)
{
    Console.WriteLine("Sifre en az bir büyük ve bir küçük harf içermelidir");
}
else if (sifrekelimeiceriyormu)
{
    Console.WriteLine("Sifreniz 'sifre' kelimesini içeremez");
}
else
{
    Console.WriteLine("Sifre geçerli");
}
// TODO 2) else blogunda 2. kurali kontrol et (rakam var mi).
//         Rakam kontrolu icin ipuclarina bak.
// TODO 3) else blogunda 3. kurali kontrol et (kucuk + buyuk
//         harf birlikte olmali).
// TODO 4) else blogunda 4. kurali kontrol et ("sifre" kelimesi
//         icermemeli).
// TODO 5) Her kural icin ayri bir mesaj yazdir.
//         Hepsi gecerse "Sifre gecerli." yazdir.

Console.WriteLine();

/*
 ---------------------------------------------------------
 IPUCLARI
 ---------------------------------------------------------
 1) string bir nesnedir, onunla birkac sey yapabilirsin:

        sifre.Length          -> karakter sayisi (int)
        sifre.Contains("abc") -> icinde "abc" var mi (bool)
        sifre.ToUpper()       -> hepsini buyuk harf yapar
        sifre.ToLower()       -> hepsini kucuk harf yapar
        sifre.Trim()          -> bastaki/sondaki bosluklari siler

 2) Rakam var mi diye bakmanin en kolay yolu:
        sifre.Any(char.IsDigit)
    Bu icinde gizli bir dongu var, senin yazmana gerek yok.
    Ayrica kullanabilecegin benzer kontroller:
        sifre.Any(char.IsUpper)     buyuk harf var mi
        sifre.Any(char.IsLower)     kucuk harf var mi
        sifre.Any(char.IsPunctuation)  noktalama var mi

 3) Once buyuk harfe cevirip kontrol edebilirsin:
        string buyuk = sifre.ToUpper();
        buyuk.Any(char.IsDigit)     // ayni sonucu verir

 4) Kurallari sirayla kontrol etmek yerine her birini ayri
    if ile yazip sonunda birlestirmek de olur. Ama o zaman
    "hangi kural bozuldu" bilgisini kaybetmis olursun.
    O yuzden if / else if zinciri bu alistirma icin daha uygun.
 ---------------------------------------------------------
*/
