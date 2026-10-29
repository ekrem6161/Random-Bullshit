# AGENTS.md

## Depo yapısı
- Bu bir tek uygulama değil, kişisel bir C# öğrenme çalışma alanıdır. Üst düzey klasörler birbirinden bağımsız .NET 8 projeleri veya alıştırma gruplarıdır; `.sln` yoktur, bu yüzden kök dizinden `dotnet build` hedef bulamaz.
- `EkranButonu` tek GUI projesidir (`net8.0-windows`, WinForms); diğerleri konsol uygulamasıdır.
- Klasör adıyla eşleşmeyen proje dosyaları:
  - `1.Projesayitoplama\1.projem.csproj`
  - `2.Projesayitoplama\Proje2.csproj`
- `AresV1` boş bir konsol iskeletidir (`Program.cs` yalnızca BOM içerir); henüz giriş noktası yoktur.

## Derleme / çalıştırma
- Tek bir projeyi çalışma alanının kökünden derleyin veya çalıştırın:
  `dotnet build "5.SwitchCase\5.SwitchCase.csproj"`
  `dotnet run --project "7.ForLoop\7.ForLoop.csproj"`
- README'de belirtilen WinForms exe'si için Release derlemesi:
  `dotnet build "EkranButonu\EkranButonu.csproj" -c Release`
- Konsol uygulamalarının çoğu `Console.ReadLine`/`ReadKey` bekler; doğrudan `dotnet run` komutu takılır. Otomatik kontrolde `dotnet build` kullanın veya stdin'e veri verin.
- Test, CI, formatter/analyzer yapılandırması veya NuGet paketi yoktur. Doğrulama yöntemi derleme ve elle çalıştırmadır.

## Alıştırma projeleri (`Alistirmalar`)
- `eski aliştirmalar\01-...` ile `10-...` arasındaki projeler Türkçe öğrenme alıştırmalarıdır. Her `Program.cs` başında problem metni, sonunda ipuçları bulunur; `OKUBENI.txt` içindekiler listesidir.
- TODO yorumları kasıtlı öğretim iskeletidir. Bazı dosyalar çözülmüş olsa da TODO içerir (ör. `05-SifreKontrolu`, `09-GirdiDogrulama`); bunları silmeyin veya kodu bozuk sanmayın.
- Tamamlanma işaretleri tutarsızdır (`durum.txt`, `Durum.txt` veya uzantısız `durum`); işarete güvenmek yerine kodu kontrol edin.
- `SwitchForLoopVeStringArray Alıştırmaları` şu an boş bir yer tutucu klasördür.

## EkranButonu (WinForms)
- Form kasıtlı olarak odak almaz (`WS_EX_NOACTIVATE` ve `ShowWithoutActivation`), böylece `SendKeys.Send("a")` önceden aktif olan uygulamaya yazar. Bunu normal odak davranışına çevirmeyin.
- Küçük harf `"a"` gönderir ve büyük/küçük harfi Caps Lock belirler; Shift göndermeyin.
- `EkranButonu_SingleInstance` mutex'i ile uygulama tek örnek olarak çalışır; ikinci başlatma sessizce kapanır.
- Arayüz yalnızca `MainForm.cs` içinde kodla yazılmıştır; `.Designer.cs` veya `.resx` dosyası yoktur. Davranış referansı `README.md`'dir.

## Metin ve yollar
- Kod, yorumlar ve konsol çıktısı Türkçe/UTF-8'dir. Bu üslubu koruyun; istenmedikçe çevirmeyin veya tanımlayıcıları yeniden adlandırmayın.
- Windows PowerShell'de `Get-Content`, Türkçe karakterleri bozuk gösterebilir. Bu kaynaklar için dosya okuma/düzenleme araçlarını kullanın.
- Yollarda boşluk ve ASCII dışı karakterler vardır; komutlarda yolları tırnak içine alın.
