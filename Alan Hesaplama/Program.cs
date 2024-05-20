using System;

namespace Alan_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şekli girin (Daire, Üçgen, Kare, Dikdörtgen. ): ");
            string şekil = Console.ReadLine();

            double sonuç = 0;

            switch (şekil.ToLower())
            {
                case "daire":
                    Console.Write("Yarıçapı girin: ");
                    double yarıçap = Convert.ToDouble(Console.ReadLine());
                    sonuç = Daire_Çevresini_Hesapla(yarıçap);
                    Console.WriteLine($"Çemberin çevresi: {sonuç:F2}");
                    break;

                case "üçgen":
                    Console.Write("Üsse girin: ");
                    double taban_uzunluğu = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Yüksekliği girin: ");
                    double yükseklik = Convert.ToDouble(Console.ReadLine());
                    sonuç = Üçgen_Alanı_Hesapla(taban_uzunluğu, yükseklik);
                    Console.WriteLine($"Üçgenin alanı: {sonuç:F2}");
                    break;

                case "kare":
                    Console.Write("Kenar uzunluğunu girin: ");
                    double kenar_uzunluğu = Convert.ToDouble(Console.ReadLine());
                    sonuç = Kare_Alanı_Hesapla(kenar_uzunluğu);
                    Console.WriteLine($"Meydanın alanı: {sonuç:F2}");
                    break;

                case "dikdörtgen":
                    Console.Write("Uzunluğu girin: ");
                    double uzunluk = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Genişliği girin: ");
                    double Genişlik = Convert.ToDouble(Console.ReadLine());
                    sonuç = Dikdörtgen_Alanı_Hesapla(uzunluk, Genişlik);
                    Console.WriteLine($"Dikdörtgenin alanı: {sonuç:F2}");
                    break;

                default:
                    Console.WriteLine("Geçersiz şekil. Lütfen tekrar deneyin.");
                    break;
            }

            Console.ReadLine();
        }

        static double Daire_Çevresini_Hesapla(double yarıçap)
        {
            return 2 * Math.PI * yarıçap;
        }

        static double Üçgen_Alanı_Hesapla(double taban_uzunluğu, double yükseklik)
        {
            return 0.5 * taban_uzunluğu * yükseklik;
        }

        static double Kare_Alanı_Hesapla(double kenar_uzunluğu)
        {
            return kenar_uzunluğu* kenar_uzunluğu;
        }

        static double Dikdörtgen_Alanı_Hesapla(double uzunluk, double Genişlik)
        {
            return uzunluk * Genişlik;
        }
    }
}
