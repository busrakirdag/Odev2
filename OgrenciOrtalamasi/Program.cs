using System;

namespace OgrenciOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Sayısını Giriniz:");
            int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());
            double ortalama, genelOrt;
            double toplam = 0;
            double endusukOrt = 100;
            double enyuksekOrt = -1;
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine($"Lütfen {i+1}. Öğrencinin Vize Notunu Giriniz");
                int vize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Lütfen {i+1}. Öğrencinin Final Notunu Giriniz");
                int final = Convert.ToInt32(Console.ReadLine());

                ortalama = (vize * 0.4) + (final * 0.6);
                Console.WriteLine($"{i+1}. Öğrenci Ortalaması:{ortalama}");

                if (ortalama > enyuksekOrt)
                {
                    enyuksekOrt = ortalama;
                }
                if (ortalama < endusukOrt)
                {
                    endusukOrt = ortalama;
                }
                toplam += ortalama;
                

            }
            genelOrt = toplam / ogrenciSayisi;
            Console.WriteLine($"En Düşük Öğrenci Ortalaması: {endusukOrt}");
            Console.WriteLine($"En Yüksek Öğrenci Ortalaması: {enyuksekOrt}");
            Console.WriteLine($"Genel Öğrenci Ortalaması: {genelOrt}");
            Console.ReadKey();
        }
    }
}
