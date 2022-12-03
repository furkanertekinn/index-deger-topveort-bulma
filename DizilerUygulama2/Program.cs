using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerUygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Oluşturmak İstediğiniz Veri Uzunluğunu Giriniz : ");
            String diziUzunluk = Console.ReadLine();
            int diziUzunlukInt = Convert.ToInt32(diziUzunluk);

            int[] dizi = new int[diziUzunlukInt];

            for (int sayac = 0; sayac < dizi.Length; sayac++)
            {
                Console.Write(sayac + ". index'e gelen değeri giriniz :");
                dizi[sayac] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Teşekkürler! Tüm alanları doldurdunuz.");
            Console.WriteLine("Dizi içerisinde ki toplam ve ortalama değerleri aşağıdaki gibidir ;");
            Console.ReadLine();

            int diziToplam = 0;
            int diziOrtalama = 0;

            foreach (int item in dizi)
            {
                Console.WriteLine(item);
                diziToplam = diziToplam + item;
            }
            Console.WriteLine("+");
            Console.WriteLine("----------------");
            Console.WriteLine(diziToplam);
            Console.WriteLine("Dizi içerisinde ki elaman sayısı :" + dizi.Length);
            diziOrtalama = (diziToplam / dizi.Length);
            Console.WriteLine("Dizi Ortalaması :" + diziOrtalama);
            Console.ReadLine();

        }
    }
}
