using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13253039HW._2
{
    class car
    {
        
       int boyut;
       public int[,] matris;

        public car(int boyut)
        {
            this.boyut = boyut;
            matris = new int[boyut, boyut];
        }

        public int sagIlerleme(int ilerleme,ref int sutun,int satir,ref int fircadurum)      //baslangicdurum 1 oldugunda ilerleme icin kullanılacak metot
        {
                int count = 0;
                if(boyut-sutun>ilerleme)
                {
                        for (int j = sutun+1; j <=sutun+ilerleme ;j++)
                        {
                            if(fircadurum==1)         //eger fircadurum 1 ise ilgili yere * koyulacak
                            matris[satir, j] = 1;  
                        }
                        sutun = ilerleme+sutun;
                }
                else if(boyut-sutun<=ilerleme)        //eger arac boyut disina cikiyosa kullanilir
                {
                        for (int j = sutun+1; j < boyut; j++)
                        {
                            if(fircadurum==1)
                            matris[satir, j] = 1;
                            count++;
                        }
                       
                        for (int j = 0; j < ilerleme-count; j++)
                        {
                            if(fircadurum==1)
                            matris[satir, j] = 1;
                            
                        }
                        sutun = ilerleme - count-1;
                }
                return sutun;
            }
        
        public int solIlerleme(int ilerleme,ref int sutun, int satir,ref int fircadurum)   //baslangicdurum 3 oldugunda kullanilacak metot
        {
                int count=0;
                if (sutun-ilerleme>=0)
                {
                    
                    for (int j = sutun-1; j >= sutun-ilerleme; j--)
                    {
                        if(fircadurum==1)
                        matris[satir, j] = 1;
                    }
                    sutun = sutun - ilerleme;
                }
                else if (sutun-ilerleme < 0)
                {
                    for (int j = sutun-1; j >=0; j--)
                    {
                        if(fircadurum==1)
                        matris[satir, j] = 1;
                        count++;   
                    }

                    for (int j = boyut-1; j >=boyut-(ilerleme-count); j--)
                    {
                        if(fircadurum==1)
                        matris[satir, j] = 1;
                    }
                    sutun = boyut - (ilerleme - count);
                }
            
            return sutun;
        }

        public int asagiIlerleme(int ilerleme,  int sutun,ref int satir,ref int fircadurum)      //baslangicdurum 2 oldugunda kullanilacak metot
        {
            int count = 0;
            if (boyut - satir > ilerleme)
            {
                for (int j = satir+1; j <= satir + ilerleme; j++)
                {
                    if(fircadurum==1)
                    matris[j, sutun] = 1;
                }
                satir = ilerleme+satir;
            }
            else if (boyut - satir <= ilerleme)
            {
                for (int j = satir+1; j < boyut; j++)
                {
                    if(fircadurum==1)
                    matris[j, sutun] = 1;
                    count++;
                }

                for (int j = 0; j < ilerleme-count; j++)
                {
                    if(fircadurum==1)
                    matris[j, sutun] = 1;

                }
                satir = ilerleme - count-1;
                
            }
            return satir;
        }
        public int yukariIlerleme(int ilerleme, int sutun,ref int satir,ref int fircadurum)     //baslangicdurum 4 oldugunda kullanilacak metot
        {
                int count=0;
                if (satir-ilerleme>=0)
                {
                    
                    for (int j = satir-1; j >= satir-ilerleme; j--)
                    {
                        if(fircadurum==1)
                        matris[j, sutun] = 1;
                      
                    }
                    satir = satir - ilerleme;
                }
                else if (satir-ilerleme < 0)
                {
                    for (int j = satir-1; j >=0; j--)
                    {
                       if(fircadurum==1)
                        matris[j, sutun] = 1;
                        count++;   
                    }

                    for (int j = boyut-1; j >=boyut-(ilerleme-count); j--)
                    {
                        if(fircadurum==1)
                        matris[j, sutun] = 1;
                    }
                    satir = boyut - (ilerleme - count);
                }
            
            return satir;
        }

        public int sagDon(ref int durum)     //sag donme metodu
        {
            if (durum == 4)          //durum 4 ise(yani yukari konumdaysa) 1.duruma(yani sag kanumuna) gelir.
                return 1;
            return durum++;         //diger durumlarda durum 1 arttirilir.
            
        }

        public int solDon(ref int durum)    //sol donme metodu
        {
            if (durum == 1)          //durum 1 iken(sag konum) 4 konumuna(yukari) gelir.
                durum = 4;
            else
                durum--;              //diger durumlarda durum 1 azaltilir.
            
            return durum ;
 
        }

        public int GeriDon(ref int durum)     //bulundugu durumun tam tersine doner
        {
            if (durum == 1)
                durum = 3;
            else if (durum == 2)
                durum = 4;
            else if (durum == 3)
                durum = 1;
            else if (durum == 4)
                durum = 2;
            return durum;

        }
        public int SagZipla(int satir,ref int sutun,ref int fircadurum)    //bulundugu kare haric 3 kare ziplar 
        {
            int count = 0;
            if (boyut > 3 + sutun)
                sutun += 3;
            else
            {
                for (int j = sutun + 1; j < boyut; j++)
                    count++;
                sutun = 3 - count - 1;
            }
            fircadurum = 2;
            return sutun;
 
        }
        public int AsagiZipla(ref int satir, int sutun,ref int fircadurum)
        {
            int count = 0;
            if (boyut >= 3 + satir)
                satir += 3;
            else
            {
                for (int j = satir + 1; j < boyut; j++)
                    count++;
                satir = 3 - count - 1;
            }
            fircadurum = 2;
            return satir;
        }
        public int SolZipla(int satir,ref int sutun,ref int fircadurum)
        {
            int count = 0;
            if (sutun - 3 >= 0)
                sutun -= 3;
            else
            {
                for (int j = sutun - 1; j >= 0; j--)
                    count++;
                sutun = boyut - (3 - count);
            }
            fircadurum = 2;
            return sutun;
                
        }
        public int YukariZipla(ref int satir,int sutun,ref int fircadurum)
        {
            int count = 0;
            if (satir - 3 >= 0)
                satir -= 3;
            else
            {
                for (int j = satir - 1; j >= 0; j--)
                    count++;
                satir = boyut - (3 - count);
            }
            fircadurum = 2;
            return satir;
 
        }
        
        public void goruntuleme()
        {
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    if(matris[i,j]==1)
                        Console.Write("*");
                    else
                    Console.Write(matris[i,j]);
                }
                Console.WriteLine();
            }
        }
        public int fircaDurumu(ref int durum,int dizi,ref int satır,ref int sutun)
        {
            if (dizi == 1)
            {
                durum = 1;
                matris[satır, sutun] = 1;
            }
            else if (dizi == 2)
                durum = 2;
            return durum;
        }


    }
}
