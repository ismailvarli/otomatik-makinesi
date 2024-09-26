namespace otomatik_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = { "Coco Cola", "Ayran", "Su ", "Fanta" };
            int[] fiyatlar = { 50, 15, 10, 35 };


            {
                Console.WriteLine("Ürünler:");
                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {urunler[i]} ->>> {fiyatlar[i]} TL");
                }
                Console.WriteLine("\nBir Ürün Seçiniz(1/4):");
                int urunSecimi = int.Parse(Console.ReadLine()) - 1;

                int urunFiyati = fiyatlar[urunSecimi];
                int toplamPara = 0;

                while (toplamPara < urunFiyati)
                {
                    Console.Write($"Seçtiğiniz ürün: {urunler[urunSecimi]} -> Fiyatı: {urunFiyati} TL\n");
                    Console.Write("Para girin: ");

                    int girilenPara = int.Parse(Console.ReadLine());
                    toplamPara += girilenPara;

                    if (toplamPara < urunFiyati)
                    {
                        Console.WriteLine($"Yetersiz bakiye! Kalan tutar: {urunFiyati - toplamPara} TL.");
                    }
                }

                // Ürünü satın alma
                Console.WriteLine($"Tebrikler! {urunler[urunSecimi]} aldınız.");

                // Para üstü kontrolü
                if (toplamPara > urunFiyati)
                {
                    Console.WriteLine($"Para üstü: {toplamPara - urunFiyati} TL.");
                }

                Console.WriteLine("İşlem tamamlandı.");


            }
        }
    }
}
