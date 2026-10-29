# Ekran Butonu

Ekranın üstünde, diğer pencerelerin üzerinde duran küçük bir "A" butonu.
Sol tıklandığında aktif uygulamaya **Caps Lock durumuna göre** `A` veya `a` yazar.

## Kullanım

- **Sol tık:** `A` yazar. Caps Lock açıksa büyük `A`, kapalıysa küçük `a`.
- **Sağ tuşla sürükle:** Butonu ekranda taşır.
- **Sağ tık:** Menüyü açar (Gizle / Konumu sıfırla / Kapat).
- **Tepsi simgesi:** Çift tıkla göster/gizle; sağ tıkla menü.

## Önemli notlar

- Buton, tıklandığında odak çalmaz. Böylece `A`, arkadaki aktif uygulamaya gider.
- Yönetici olarak çalışan uygulamalara yazdırmak için bu uygulamayı da yönetici olarak çalıştır.
- UAC ekranında ve bazı tam ekran oyunlarda çalışmayabilir.
- Her tıklamada bir harf gönderir; basılı tutunca tekrarlamaz.

## Çalıştırma

```powershell
dotnet run --project "C:\Users\Ekrem\Desktop\C# Projelerim\EkranButonu\EkranButonu.csproj"
```

Derlenmiş exe:

```text
C:\Users\Ekrem\Desktop\C# Projelerim\EkranButonu\bin\Release\net8.0-windows\EkranButonu.exe
```
