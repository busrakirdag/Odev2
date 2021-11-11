using System;

namespace KullaniciAdi
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciadi, sifre;
            Console.WriteLine("Kullanıcı Adı Giriniz:");
            kullaniciadi = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz:");
            sifre = Console.ReadLine();


            if (kullaniciadi == "admin" && sifre == "123")
            {
                Console.WriteLine("Hoşgeldiniz..");
            }
            else {
                int i = 0;
                while (i < 3)
                {

                    Console.WriteLine("Hatalı giriş yaptınız..");
                    Console.WriteLine("Kullanıcı Adı Giriniz:");
                    kullaniciadi = Console.ReadLine();
                    Console.WriteLine("Şifrenizi Giriniz:");
                    sifre = Console.ReadLine();
                    if (kullaniciadi != "admin" && sifre != "123")
                    {
                        i++;    
                    }
                    
                }
                
            }
            Console.ReadKey();

        }
    }
}
