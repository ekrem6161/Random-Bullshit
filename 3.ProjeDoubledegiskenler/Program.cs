double sinav1, sinav2, sinav3, proje, ort;
string ad, soyad, numara;

Console.WriteLine("adınızı söyleyin");
ad = Console.ReadLine();

Console.WriteLine("Soyadınızı söyleyin");
soyad = Console.ReadLine();

Console.WriteLine("Numaranızı söyleyin");
numara= Console.ReadLine();

Console.WriteLine("Öğrenci sınav bilgilerini girin");
sinav1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("2. sınav notunu girin");
sinav2= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("3. sınav notunu girin");
sinav3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Proje notunu girin");
proje = Convert.ToDouble(Console.ReadLine());

ort = (sinav1 + sinav2 + sinav3 + proje) / 4;
Console.WriteLine(ort);
Console.ReadKey();