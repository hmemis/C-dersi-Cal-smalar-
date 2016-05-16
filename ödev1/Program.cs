//Hilal MEMİŞ
//13253039



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sınıf Mevcudunu Giriniz   :");     
            int sınıfMevcudu = int.Parse(Console.ReadLine());
            Boolean flag = true;       // sınıf mevcudunun kaç kişilik olacağını belirleyen metod
            while (flag == true)        //
            {
                if (sınıfMevcudu < 0 || sınıfMevcudu > 101)   //
                {
                    Console.WriteLine("Sınıf Mevcudu 0-100 arasında seçilmelidir");   //
                    sınıfMevcudu = int.Parse(Console.ReadLine());                     //

                }
                else               //
                {
                    flag = false;    //
                }

            }
            OgrenciIslemleri ogrislemleri = new OgrenciIslemleri();// OgrenciIslemleri classında ki metodları kullanmak için oluşturduğum obje 

            Ogrenci[] ogrenciler = ogrislemleri.degerAlma(sınıfMevcudu); 
            
            Console.WriteLine("Yaptırmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine();
            Console.WriteLine("1) Öğrencilerin Numara,İsim ve Notlarını Listeleme");
            Console.WriteLine("2) Not Ortalamaları");
            Console.WriteLine("3) 60'dan Düşük Not Alan Öğrenci Listesi");
            Console.WriteLine("4) Ortalamanın Üstünde Not Alan Öğrenci Listesi");
            Console.WriteLine("5) 60'dan Küçük Sınavların Sayısı");
            Console.WriteLine("6) En Yüksek Sınav Notu");
            Console.WriteLine("7) En Düşük Sınav Notu");
            Console.WriteLine("8) Küçükten Büyüğe 3 Sınav Ortalaması");
            Console.WriteLine("9) Numara Sırasına Göre Listeleme");
            
            int secim=int.Parse(Console.ReadLine());
            if(secim==1)
            {
                ogrislemleri.listeleme(ogrenciler);
            }
            else if(secim==2)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ortalamasını İstediğiniz Notu Seçiniz");
                Console.WriteLine("1) Öğrencilerin Algoritma Notları Ortalamaları");
                Console.WriteLine("2) Öğrencilerin Matematik Notları Ortalamaları");
                Console.WriteLine("3) Öğrencilerin Fizik Notları Ortalamaları");
                int secim2 = int.Parse(Console.ReadLine());
                if (secim2 == 1)
                { 
                    Console.WriteLine(ogrislemleri.not1Ortalama(ogrenciler));
                }
                else if (secim2 == 2)
                {
                   Console.WriteLine(ogrislemleri.not2Ortalama(ogrenciler));
                }
                else if (secim2 == 3)
                {
                    Console.WriteLine(ogrislemleri.not3Ortalama(ogrenciler));
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ!!!");
                }
            }
            else if(secim==3)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("İşlem Yapmak İstediğiniz Notu Seçiniz");
                Console.WriteLine("1) Öğrencilerin Algoritma Notlarındaki 60dan Küçük Notlar");
                Console.WriteLine("2) Öğrencilerin Matematik Notlarındaki 60dan Küçük Notlar");
                Console.WriteLine("3) Öğrencilerin Fizik Notlarındaki 60dan Küçük Notlar");
                int secim3 = int.Parse(Console.ReadLine());
                if (secim3 == 1)
                {
                    ogrislemleri.altmışdanDüşükÖğrencilerNot1(ogrenciler);
                }
                else if (secim3 == 2)
                {
                    ogrislemleri.altmışdanDüşükÖğrencilerNot2(ogrenciler);
                }
                else if (secim3 == 3)
                {
                     ogrislemleri.altmışdanDüşükÖğrencilerNot3(ogrenciler);
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ!!!");
                }
            }
            else if (secim == 4)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("İşlem Yapmak İstediğiniz Notu Seçiniz");
                Console.WriteLine("1) Öğrencilerin Algoritma Notlarındaki Ortalama ve Ortalamanın Üstündeki Notlar");
                Console.WriteLine("2) Öğrencilerin Matematik Notlarındaki Ortalama ve Ortalamanın Üstündeki Notlar");
                Console.WriteLine("3) Öğrencilerin Fizik Notlarındaki Ortalama ve Ortalamanın Üstündeki Notlar");
                int secim4 = int.Parse(Console.ReadLine());
                if (secim4 == 1)
                {
                    Console.WriteLine(ogrislemleri.not1Ortalama(ogrenciler));
                     ogrislemleri.ortÜstündekiÖğrencilerNot1(ogrenciler);
                }
                else if (secim4 == 2)
                {
                    Console.WriteLine(ogrislemleri.not2Ortalama(ogrenciler));
                     ogrislemleri.ortÜstündekiÖğrencilerNot2(ogrenciler);
                }
                else if (secim4 == 3)
                {
                    Console.WriteLine(ogrislemleri.not3Ortalama(ogrenciler));
                     ogrislemleri.ortÜstündekiÖğrencilerNot3(ogrenciler);
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ!!!");
                }
            }
            else if (secim == 5)
            {
                 Console.WriteLine(ogrislemleri.altmıştanKüçükSınavDeğeri(ogrenciler));
            }
            else if (secim == 6)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("İşlem Yapmak İstediğiniz Notu Seçiniz");
                Console.WriteLine("1) Öğrencilerin Algoritma Notlarındaki En Yüksek Not");
                Console.WriteLine("2) Öğrencilerin Matematik Notlarındaki En Yüksek Not");
                Console.WriteLine("3) Öğrencilerin Fizik Notlarındaki En Yüksek Not");
                int secim5 = int.Parse(Console.ReadLine());
                if (secim5 == 1)
                {
                    Console.WriteLine(ogrislemleri.maxNot1(ogrenciler));
                }
                else if (secim5 == 2)
                {
                    Console.WriteLine(ogrislemleri.maxNot2(ogrenciler));
                }
                else if (secim5 == 3)
                {
                     Console.WriteLine(ogrislemleri.maxNot3(ogrenciler));
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ!!!");
                }
            }
            else if (secim == 7)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("İşlem Yapmak İstediğiniz Notu Seçiniz");
                Console.WriteLine("1) Öğrencilerin Algoritma Notlarındaki En Düşük Not");
                Console.WriteLine("2) Öğrencilerin Matematik Notlarındaki En Düşük Not");
                Console.WriteLine("3) Öğrencilerin Fizik Notlarındaki En Düşük Not");
                int secim6 = int.Parse(Console.ReadLine());
                if (secim6 == 1)
                {
                    Console.WriteLine(ogrislemleri.minNot1(ogrenciler));
                }
                else if (secim6 == 2)
                {
                    Console.WriteLine(ogrislemleri.minNot2(ogrenciler));
                }
                else if (secim6 == 3)
                {
                    Console.WriteLine(ogrislemleri.minNot3(ogrenciler));
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ!!!");
                }
            }
            else if (secim == 8)
            {
                ogrislemleri.üçSınavOrtalaması(ogrenciler);
                ogrislemleri.NotSıralaması(ogrenciler);
                ogrislemleri.yazdırma(ogrenciler);
            }
            else if (secim == 9)
            {
                ogrislemleri.numaraSıralama(ogrenciler);
                ogrislemleri.notlaraGöreYazdırma(ogrenciler);
            }
            else
            {
                Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ!!!");
            } 
            Console.ReadLine();
        }
    }
}
