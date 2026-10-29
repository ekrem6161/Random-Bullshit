/*
 ============================================================
  ALISTIRMA 09 - Girdi Dogrulama           (Zor)
 ============================================================
  KONU : int.TryParse , hatali girdi yakalama, bool donusu
 ============================================================

  PROBLEM:
  Kullanicidan yasini sor. Girdi bir sayi degilse veya
  mantikli bir aralikta degilse hata mesaji ver.
  Dogru girdi yas grubunu yazdir.

  YAS GRUPLARI:
        0 - 12    ->  Cocuk
       13 - 17    ->  Genc
       18 - 64    ->  Yetiskin
       65 ve ustu ->  Yasli

  BIRDEN FAZLA DENEME HAKKIN VAR:
  Kullanici gecersiz bir sey yazarsa tekrar sor.
  "k" yazip girene kadar sormaya devam et.

  ORNEK GIRDI :  abc  ->  "Gecersiz giris, tekrar deneyin."
                 35    ->  "Yetiskin"
                 -5    ->  "Yas 0-120 arasinda olmalidir."

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/

// NOT: Bu iki degisken asagida tanimli ama henuz kullanilmiyor.
//      Bu yuzden derleyici "atanir ancak kullanilmaz" uyarisi
//      verir (CS0219). Bu normal. TODO'lari doldurdugunda
//      uyari kendiliginden kaybolur.
int yas = 0;
bool gecerli = false;

while (!gecerli)
{
    Console.WriteLine("Yaşınız  :  ");
    string girdi = Console.ReadLine() ?? "";
    
    if (int.TryParse(girdi, out yas))
    {
        if (yas >= 0 && yas <= 120)
        {
            gecerli = true;
        }
        else
        {
            Console.WriteLine("yas 0 ile 120 arasında olmalıdır");
        }
    }
    else
    {
        Console.WriteLine("Geçersiz giriş");
    }
}

// 0 - 12    ->  Cocuk
  //     13 - 17    ->  Genc
    //   18 - 64    ->  Yetiskin
   // 65 ve ustu ->  Yasli

if (yas <= 12)
{
    Console.WriteLine("Cocuk");
}
else if (yas <= 17)
{
    Console.WriteLine("Genc");
}
else if (yas <= 64)
{
    Console.WriteLine("Yetiskin");
}
else if (yas >= 65)
{
    Console.WriteLine("Yasli");
}

// TODO 1) Kullanici dogru bir yas girene kadar sor.
//         while dongusu kur.
//         Soru:  Console.Write("Yasiniz : ");
//         Oku :   string girdi = Console.ReadLine() ?? "";
//         Kontrol: int.TryParse(girdi, out yas)
//         bu metot true donerse "sayi okundu", false ise
//         "sayi degil" demektir.
// TODO 2) Sayi okundu ama aralik yanlissa uyari ver.
//         Negatif ya da 120'den buyukse kabul etme.
// TODO 3) Girdi gecerli olunca donguden cik.
// TODO 4) Son olarak yas grubunu if / else if ile bul ve yazdir.
//         (Donguden ciktiktan sonra, en sonda)

Console.WriteLine();

/*
 ---------------------------------------------------------
 IPUCLARI
 ---------------------------------------------------------
 1) Convert.ToInt32 yerine TryParse kullanmanin farki:
    "abc" girildiginde Convert.ToInt32 bir HATA firlatir ve
    program coktugunden kodu calismaz.
    TryParse hata firlatmaz, sadece false doner. Bu yuzden
    kullanici yanlislik yaptiginda program cokmez.

 2) int.TryParse iki bilgi dondurur:

        bool basarili = int.TryParse(girdi, out int sayi);
                                      ^^^^^^^^^^^^
                                       buraya yazan deger atanir

    basarili true  ise sayi okunmus demektir
    basarili false ise girdi sayi degildir

 3) Sifirlamadan once bool kontrol etmek daha temiz olur:

        while (!gecerli)
        {
            Console.Write("Yasiniz : ");
            string girdi = Console.ReadLine() ?? "";

            if (int.TryParse(girdi, out int sayi))
            {
                if (sayi >= 0 && sayi <= 120)
                {
                    yas = sayi;
                    gecerli = true;      // dongu biter
                }
                else
                {
                    Console.WriteLine("Yas 0-120 arasinda olmalidir.");
                }
            }
            else
            {
                Console.WriteLine("Gecersiz giris, tekrar deneyin.");
            }
        }

 4) while dongusu:
        while (kosul) { ... }

    Kosul dogu oldugu surece blok tekrarlanir. En sonda
    gecerli = true oldugu icin kosul yanlisa doner ve
    dongu biter.

    DIKKAT: gecerli hiç true olmazsa dongu hiç bitmez.
    Kullanicidan "k" yazip girmezse program sonsuza dek
    soru sorar. Kendi cözümünde bu dongunun mutlaka bitmesini
    sagla.

 5) C# de while ile ... arasindaki int'i hemen tanimlayip
    hemen kullanabilirsin:
        if (int.TryParse(girdi, out int sayi))
    Daha once yazdiysan onu kullanmak zorunda degilsin.
 ---------------------------------------------------------
*/
