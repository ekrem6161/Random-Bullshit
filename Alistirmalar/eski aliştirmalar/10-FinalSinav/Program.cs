/*
 ============================================================
  ALISTIRMA 10 - Final Sinav               (Zor)
 ============================================================
  KONU : Hepsinin bir arasi. Degiskenler, tip donusumu,
         kuruş kaybi, if / else if zinciri, && , || ,
         girdi dogrulama, string birlestirme
 ============================================================

  PROBLEM:
  Bir ogrencinin sinav sonuclarini gir, harf notunu ve
  durumunu gosteren bir ozet cikart.

  VERILER:
      - 3 sinav notu (0-100 arasi)
      - 1 proje notu (0-100 arasi)
      - Devamsizlik gun sayisi

  HESAPLAMA:
      1) 3 sinav notunun ortalamasini al  (sinav ortalamasi)
      2) Genel not = sinav ortalamasi * %70
                   + proje notu     * %30
      3) Her sinav notu 50'nin altindaysa veya devamsizlik
         12 gunden fazlaysa durum "KALDI" olur.
         (Kalan dersler harf notunu degistirmez, sadece
          durumu etkiler.)

  HARF NOTU  (genel nota gore)
      90 ve ustu  -> AA
      75 - 89     -> BA
      60 - 74     -> BB
      50 - 59     -> CC
      40 - 49     -> DD
      0  - 39     -> FF

  ORNEK GIRDI :  85, 90, 78, proje 80, devamsizlik 3
  BEKLENEN CIKTI:
      ---------------- OGRENCI OZETI ----------------
      Sinav ortalamasi : 84,33
      Genel not         : 82,90
      Harf notu         : BB
      Devamsizlik       : 3 gun
      Durum             : GECTI
      ---------------------------------------------

  ============================================================
  TODO isaretli yerleri sen dolduracaksin.
 ============================================================
*/

Console.Write("=== OGRENCI NOT BILGILERI ===\n");

Console.Write("1. sinav notu   : ");
// TODO 1) 3 sinav notunu ve proje notunu oku.
// TODO 2) Devamsizlik gun sayisini oku.
// TODO 3) Notlara gecerlilik kontrolu ekle.
//         Her not 0-100 arasi olmali. Degilse uyari ver.
//         (Convert.ToInt32 yerine TryParse kullanabilirsin,
//          ipuclarina bak.)
// TODO 4) sinavOrt ve genelNot degiskenlerini hesapla.
//         DIKKAT: ortalama bolmesinde 3.0 kullan,
//         yoksa ondalik kisim kaybolur.
// TODO 5) if / else if / else ile harf notunu bul.
// TODO 6) Durumu belirle: herhangi bir sinav 50 altindaysa
//         VEYA devamsizlik 12'den fazlaysa KALDI.
// TODO 7) Ozeti yazdir. Ornekteki bicimi taklit etmeye calis.

Console.WriteLine();

/*
 ---------------------------------------------------------
 IPUCLARI
 ---------------------------------------------------------
 1) BU ALISTIRMA YAPISAL OLARAK UC KISIMDAN OLUSUR.
    Kodunu sirayla yaz, her adimi calistirip test et:

        1) Okuma      -> degiskenlere deger al
        2) Hesaplama  -> sayilari uret
        3) Karar      -> if / else ile sonuc bul
        4) Cikti      -> ekrana yaz

    Hepsini tek seferde yazmaya calisma.

 2) Genel not agirlikli ortalamadir. Iki ayri carpma ve
    bir toplama gerekir:
        double genelNot = sinavOrt * 0.70 + projeNotu * 0.30;
    Toplam agirliklarin 1'e esit oldugundan emin ol.

 3) sinavOrt hesabinda bolmeyi 3.0 ile yap:
        double sinavOrt = (not1 + not2 + not3) / 3.0;
    3 ile bolersen 84.67 yerine 84 gelir.

 4) Durum kosulunda iki farkli kontrolu birlestir:
        if (not1 < 50 || not2 < 50 || not3 < 50 || devamsizlik > 12)
    Tek bir if icinde birden fazla || kullanabilirsin.
    Her kosulu ( ) icine almak okunabilirligi artirir:
        if ((not1 < 50) || (not2 < 50) || (devamsizlik > 12))

 5) Ozet yazdirirken interpolation kullan:
        Console.WriteLine($"Genel not : {genelNot:F2}");
    Arada tire satiri gibi ayirici yazmak icin:
        Console.WriteLine(new string('-', 40));

 6) Bonus: Tum notlari girmeden once kac tanesinin 50
    altinda oldugunu sayan bir kontrol daha ekleyebilirsin.
    (Bu icin dongu veya sayac kullanman gerekir.)
 ---------------------------------------------------------
*/
