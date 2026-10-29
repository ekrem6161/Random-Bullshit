/*
 ============================================================
  ALISTIRMA 06 - Artik Yil                 (Orta)
 ============================================================
  KONU : % (mod Alma), && , || , parantez onceligi
 ============================================================

  PROBLEM:
  Kullanicidan bir yil al ve o yilin artik yil olup
  olmadigini bul. Artik yil 366 gun, normal yil 365 gun.

  ARTIK YIL KURALI:
    - Yil 400'e tam bolunuyorsa            -> ARTIK
    - Ya da yil 4'e tam bolunuyor
      VE 100'e tam bolunmuyorsa            -> ARTIK
    - Diger durumlar                       -> ARTIK DEGIL

  ORNEKLER:
      2024 -> artik   (4'e bolunur, 100'e bolunmez)
      1900 -> artik degil (4'e bolunur AMA 100'e de bolunur)
      2000 -> artik   (400'e tam bolunur)
      2023 -> artik degil

  DIKKAT:
  1900 yili en kritik ornek. 4'e bolunmesine ragmen artik
  yil DEGILDIR. 100'e bolunme kontrolu olmadan bu ornek
  yanlis cikar.

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/



Console.Write("Yili girin : ");
int yil = Convert.ToInt32(Console.ReadLine());
bool artikYil = (yil % 400 == 0) || ((yil % 4 == 0) && (yil % 100 != 0));

if (artikYil)
{
  Console.WriteLine("Yil 366 gun ve Artık yıldır");
}
else
{
  Console.WriteLine("Yıl 365 gun ve Artık yıl değildir");
}
// TODO 1) Artik yil kuralini tek bir if icinde yaz.
//         bool artikYil = ...;
// TODO 2) if / else ile sonucu ekrana yazdir.
//         Artik yil 2024 yilidir. / 2024 artik bir yil degildir.
// TODO 3) Artik yilse kac gunu oldugunu da yazdir (366 / 365).

Console.WriteLine();

/*
 ---------------------------------------------------------
 IPUCLARI
 ---------------------------------------------------------
 1) % isareti bolmekten arta kalani verir (mod):

        2024 % 4    -> 0     (tam bolundu)
        2024 % 100  -> 24    (kalan)
        2024 % 400  -> 24    (tam bolunmedi)

    "X'e tam bolunuyor" demek  x % 4 == 0 demektir.
    sadece  x % 4  yazmak kalani verir, 0 mi diye bakmayi
    unutma.

 2) Parantez onemli:
        yil % 4 == 0 && yil % 100 != 0     dogru
        yil % 4 == 0 && ... % 100 != 0     hatali (once ve)
    && ve || operatorleri soldan saga degerlendirilir.
    Birlestirmek istedigin iki kosulu mutlaka ( ) ile sar.

 3) Tam hali:
        bool artikYil =
            (yil % 400 == 0) ||
            (yil % 4 == 0 && yil % 100 != 0);

 4) Artik yilin gun sayisi degiskeni:
        int gun = artikYil ? 366 : 365;
    Soru isareti (ternary) tek satirda "x doguysa a, degilse b"
    yazmanin kisaltmasidir.
    C# de ternary kullanmak icin using System; gerekmez,
    zaten vardir. Ternary ilerleyen konularda, simdilik if/else
    ile yazmak da tamamen dogru.
 ---------------------------------------------------------
*/
