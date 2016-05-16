//Hilal MEMİŞ
//13253039

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class OgrenciIslemleri
    {
        public Ogrenci[] degerAlma(int sınıfMevcudu)// metoda Test classı içerisinden sınıf mevcudunu göndereceğiz. (Parametre olarak)
        {
            Ogrenci[] ogrenciler = new Ogrenci[sınıfMevcudu];
            
            for (int i = 0; i < sınıfMevcudu; i++)
            {
                Ogrenci ogrenci = new Ogrenci();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Öğrenci Numaranız  :");
                ogrenci.numara = int.Parse(Console.ReadLine());
                Boolean flag=true;
                while (flag == true)
                {
                    if (ogrenci.numara < 0 || ogrenci.numara> 101)
                    {
                        Console.WriteLine("öğrenci numaraları 0-100 arasında seçilmelidir");
                        ogrenci.numara = int.Parse(Console.ReadLine());

                    }
                    else
                    {
                        flag = false;
                    }

                }
                Console.Write("Adınız  :");
                ogrenci.isim = Console.ReadLine();
               
                Console.Write("Algoritma Notu  :");
                ogrenci.not1 = int.Parse(Console.ReadLine());

                Boolean flag1 = true;
                    while (flag1 == true)
                    {
                        if (ogrenci.not1 < 0 || ogrenci.not1 > 101)
                        {
                            Console.WriteLine("Notlar 0-100 Arasında Değer Alabilirler");
                            ogrenci.not1 = int.Parse(Console.ReadLine());

                        }
                        else
                        {
                            flag1 = false;
                        }

                    }
                Console.Write("Matematik Notu  :");
                ogrenci.not2 = int.Parse(Console.ReadLine());
                Boolean flag3 = true;
                while (flag3 == true)
                {
                    if (ogrenci.not2 < 0 || ogrenci.not2 > 101)
                    {
                        Console.WriteLine("Notlar 0-100 Arasında Değer Alabilirler");
                        ogrenci.not2= int.Parse(Console.ReadLine());

                    }
                    else
                    {
                        flag3 = false;
                    }

                }
                Console.Write("Fizik Notu  :"); 
                ogrenci.not3 = int.Parse(Console.ReadLine());
                Boolean flag4 = true;
                while (flag4== true)
                {
                    if (ogrenci.not3 < 0 || ogrenci.not3 > 101)
                    {
                        Console.WriteLine("Notlar 0-100 Arasında Değer Alabilirler");
                        ogrenci.not3= int.Parse(Console.ReadLine());

                    }
                    else
                    {
                        flag4 = false;
                    }

                }
               
                ogrenciler[i] = ogrenci;
            }
            return ogrenciler;
        }

        public void listeleme(Ogrenci[] ogrenciler)// Yine Test classı içerisinden ogrenci dizisi alacağız
        {

            for (int j = 0; j < ogrenciler.Length; j++) //ogrenciler.Length dizinin boyu kadar döngünün dönmesini sağlar.
            {
                Console.WriteLine("ÖĞRENCİNİN NUMARASI {0} ADI {1} NOT1 {2} NOT2 {3} NOT3 {4} ",ogrenciler[j].numara, ogrenciler[j].isim, ogrenciler[j].not1, ogrenciler[j].not2, ogrenciler[j].not3);
            }
        }
        public float not1Ortalama(Ogrenci[] ogrenciler)
        {
            int toplam = 0;

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                toplam = toplam + ogrenciler[i].not1;
            }

            return (float)toplam / ogrenciler.Length;

        }
        public float not2Ortalama(Ogrenci[] ogrenciler)
        {
            int toplam2 = 0;

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                toplam2 = toplam2 + ogrenciler[i].not2;
            }

            return (float)toplam2 / ogrenciler.Length;

        }
        public float not3Ortalama(Ogrenci[] ogrenciler)
        {
            int toplam3 = 0;

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                toplam3 = toplam3 + ogrenciler[i].not3;
            }

            return (float)toplam3 / ogrenciler.Length;

        }
        public void altmışdanDüşükÖğrencilerNot1(Ogrenci[] ogrenciler)
        {
                for (int i = 0; i < ogrenciler.Length; i++)
                {

                    if (ogrenciler[i].not1 < 60)
                    {
                        Console.WriteLine("ÖĞRENCİNİN NUMARASI {0} ADI {1} NOT1 {2}  ", ogrenciler[i].numara, ogrenciler[i].isim, ogrenciler[i].not1);
                    }
                }
            
        }
        public void altmışdanDüşükÖğrencilerNot2(Ogrenci[] ogrenciler)
        {
           
                for (int i = 0; i < ogrenciler.Length; i++)
                {

                    if (ogrenciler[i].not2 < 60)
                    {
                        Console.WriteLine("ÖĞRENCİNİN NUMARASI {0} ADI {1} NOT2 {2}  ", ogrenciler[i].numara, ogrenciler[i].isim, ogrenciler[i].not2);
                    }
                }
        }
        public void altmışdanDüşükÖğrencilerNot3(Ogrenci[] ogrenciler)
        {
           
                for (int i = 0; i < ogrenciler.Length; i++)
                {

                    if (ogrenciler[i].not3 < 60)
                    {
                        Console.WriteLine("ÖĞRENCİNİN NUMARASI {0} ADI {1} NOT3 {2}  ", ogrenciler[i].numara, ogrenciler[i].isim, ogrenciler[i].not3);
                    }
                }
        }
        public void ortÜstündekiÖğrencilerNot1(Ogrenci[] ogrenciler)
        {
            for (int j = 0; j < ogrenciler.Length; j++)
            {

                if (ogrenciler[j].not1 >= not1Ortalama(ogrenciler))
                {
                    Console.WriteLine("ÖĞRENCİNİN NUMARASI {0} ADI {1} NOT1 {2}  ", ogrenciler[j].numara, ogrenciler[j].isim, ogrenciler[j].not1);
                }
            }
        }
        public void ortÜstündekiÖğrencilerNot2(Ogrenci[] ogrenciler)
        {
            for (int j = 0; j < ogrenciler.Length; j++)
            {
                if (ogrenciler[j].not2 >= not2Ortalama(ogrenciler))
                {
                    Console.WriteLine("ÖĞRENCİNİN NUMARASI {0} ADI {1} NOT2 {2} ",ogrenciler[j].numara ,ogrenciler[j].isim ,ogrenciler[j].not2);
                }
            }
        }
        public void ortÜstündekiÖğrencilerNot3(Ogrenci[] ogrenciler)
        {
            for (int j = 0; j < ogrenciler.Length; j++)
            {
                if (ogrenciler[j].not3 >= not3Ortalama(ogrenciler))
                {
                    Console.WriteLine("ÖĞRENCİNİN NUMARASI {0} ADI {1} NOT3 {2}  ",ogrenciler[j].numara ,ogrenciler[j].isim , ogrenciler[j].not3);
                }
            }
        }
        public int altmıştanKüçükSınavDeğeri(Ogrenci[] ogrenciler)
        {
            int düşüknot=0;
            int düşüknot1 = 0;
            int düşüknot2 = 0;
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ogrenciler[i].not1 < 60)
                {
                    düşüknot++;
                }
                if (ogrenciler[i].not2 < 60)
                {
                    düşüknot1++;
                }
                if (ogrenciler[i].not3 < 60)
                {
                    düşüknot2++;
                }
            }
            return düşüknot+düşüknot1+düşüknot2;

        }
        public int minNot1(Ogrenci[] ogrenciler)
        {
            int min = ogrenciler[0].not1;
            
            for (int i = 1; i < ogrenciler.Length; i++)
            {
               
                    if (ogrenciler[i].not1 < min)
                    {
                        min = ogrenciler[i].not1;
                        
                    }
                
            }
            return min;


        }
        public int minNot2(Ogrenci[] ogrenciler)
        {
            int min = ogrenciler[0].not1;
            
            for (int i = 0; i < ogrenciler.Length; i++)
            {

                if (ogrenciler[i].not1 < min)
                {
                    min = ogrenciler[i].not1;
                    
                }


            } return min;


        }
        public int minNot3(Ogrenci[] ogrenciler)
        {
            int min = ogrenciler[0].not1;
            
            for (int i = 0; i < ogrenciler.Length; i++)
            {

                if (ogrenciler[i].not1 < min)
                {
                    min = ogrenciler[i].not1;
                    
                }


            } return min;


        }
        public int maxNot1(Ogrenci[]  ogrenciler)
        {
           int max1 = ogrenciler[0].not1;
            for (int i = 1; i < ogrenciler.Length; i++)
            {
                
                    if (ogrenciler[i].not1 > max1)
                    {
                        max1 = ogrenciler[i].not1;
                    }
                
            }
            return max1;
        }
        public int maxNot2(Ogrenci[] ogrenciler)
        {
            int max2 = ogrenciler[0].not2;
            for (int i = 0; i < ogrenciler.Length; i++)
            {

                if (ogrenciler[i].not2 > max2)
                {
                    max2 = ogrenciler[i].not2;
                }

            }
            return max2;
        }
        public int maxNot3(Ogrenci[] ogrenciler)
        {
            int max3 = ogrenciler[0].not3;
            for (int i = 0; i < ogrenciler.Length; i++)
            {

                if (ogrenciler[i].not3 > max3)
                {
                    max3 = ogrenciler[i].not3;
                }

            }
            return max3;
        }
        public void üçSınavOrtalaması(Ogrenci[] ogrenciler)
        {
            float toplam = 0;
             
            for (int i = 0; i <ogrenciler.Length; i++)
			{
               toplam=ogrenciler[i].not1 + ogrenciler[i].not2+ogrenciler[i].not3;
                ogrenciler[i].sonuc= toplam / 3;
                
			}
           
           
        }
        public void NotSıralaması(Ogrenci[] ogrenciler)
        {
            
            for (int i = 0; i < ogrenciler.Length - 1; i++)
            {
                for (int j = 0; j < ogrenciler.Length - 1 - i; j++)
                {
                    if (ogrenciler[j].sonuc > ogrenciler[j + 1].sonuc)
                    {
                        float temp = ogrenciler[j].sonuc;
                        ogrenciler[j].sonuc = ogrenciler[j + 1].sonuc;
                        ogrenciler[j + 1].sonuc= temp;
                        
                    }
                    
                }
            }
        }
        public void yazdırma(Ogrenci[] ogrenciler)
        {
            for (int j = 0; j < ogrenciler.Length; j++)
            {


                Console.WriteLine("ÖĞRENCİ ORTALAMA {0} ADI {1} NUMARA {2} ",ogrenciler[j].sonuc,ogrenciler[j].isim,ogrenciler[j].numara);
            }
        }
        public void numaraSıralama(Ogrenci[] ogrenciler)
        {

            for (int i = 0; i < ogrenciler.Length - 1; i++)
            {
                for (int j = 0; j < ogrenciler.Length - 1 - i; j++)
                {
                    if (ogrenciler[j].numara > ogrenciler[j + 1].numara)
                    {
                        int temp = ogrenciler[j].numara;
                        ogrenciler[j].numara = ogrenciler[j + 1].numara;
                        ogrenciler[j + 1].numara = temp;

                    }

                }
            }
        }
        public void notlaraGöreYazdırma(Ogrenci[] ogrenciler)
        {
            for (int j = 0; j < ogrenciler.Length; j++)
            {


                Console.WriteLine("ÖĞRENCİ NUMARASI {0} ADI {1} NOT1 {2} NOT2 {3} NOT3 {4} ",ogrenciler[j].numara , ogrenciler[j].isim , ogrenciler[j].not1,ogrenciler[j].not2,ogrenciler[j].not3);
            }
        }


    }
}