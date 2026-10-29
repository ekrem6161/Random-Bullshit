int not1, not2, not3, ort;

Console.Write("1. Not Numarasını girin  ");
not1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Not numarasını girin  ");
not2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. not ortalamasını giriniz  ");
not3 = Convert.ToInt32(Console.ReadLine());

ort = (not1 + not2 + not3) / 3;

Console.WriteLine("Ortalama ==  " + ort);
if(ort < 50)
{
    Console.WriteLine("sınavdan kaldı");
}
else
{
    Console.WriteLine("Sınavdan geçti");
}