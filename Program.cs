class Program
{
    static void Main()
    {
        List<int> sayilar = new List<int>();
        sayilar.Add(1);
        sayilar.Add(2);
        sayilar.Add(3);
        sayilar.Add(4);
        sayilar.Add(5);
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
            toplam += sayi;
        }
        Console.WriteLine("Toplam:" + toplam);
    }
}
