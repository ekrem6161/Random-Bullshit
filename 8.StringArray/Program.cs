string[] sehirler = new string[5];
Console.WriteLine("Şehirleri Söyleyin");
for (int i = 0; i < 5; i++)
{
    sehirler[i] = Console.ReadLine();
}

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(sehirler[i]);
}