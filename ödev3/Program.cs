//Hilal MEMİŞ
//13253039
//ÖDEV2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13253039HW._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int  baslangicsutun = 0;    //baslangicta sutun 0
            int baslangicsatir = 0;     //baslangicta satir 0
            int baslangicdurum=1;       //baslangıcdurum 1 oldugunda araba saga donuk ,2 oldugunda asagi donuk ,3 oldugunda sola donuk,4 oldugunda yukari donuk durumdadİr.
            int fircadurum=2;           //fırcadurum 2 oldugunda firca yukarida,1 oldugunda firca asagidadir.
            Console.WriteLine("Komutlarınızı Giriniz");
            var komutlar = Console.ReadLine();
           
           string[] dizi = komutlar.Split('+');
           car obj = new car(int.Parse(dizi[0]));

           for (int i = 1; i < dizi.Length; i++)
           {

               if (dizi[i] == "1" || dizi[i] == "2")
                   obj.fircaDurumu(ref fircadurum, int.Parse(dizi[i]), ref baslangicsatir, ref baslangicsutun);   
               else if (dizi[i] == "3")
                   obj.sagDon(ref baslangicdurum);
               else if (dizi[i] == "4")
                   obj.solDon(ref baslangicdurum);
               else if (dizi[i].StartsWith("5_"))
               {
                   int ilerleme = int.Parse(dizi[i].Remove(0, 2));

                   if (baslangicdurum == 1)
                       obj.sagIlerleme(ilerleme, ref baslangicsutun, baslangicsatir, ref fircadurum);
                   else if (baslangicdurum == 2)
                       obj.asagiIlerleme(ilerleme, baslangicsutun, ref baslangicsatir, ref fircadurum);
                   else if (baslangicdurum == 3)
                       obj.solIlerleme(ilerleme, ref baslangicsutun, baslangicsatir, ref fircadurum);
                   else
                       obj.yukariIlerleme(ilerleme, baslangicsutun, ref baslangicsatir, ref fircadurum);
               }
               else if (dizi[i] == "7")
                   obj.GeriDon(ref baslangicdurum);
               else if (dizi[i] == "6")
               {
                   if (baslangicdurum == 1)
                       obj.SagZipla(baslangicsatir, ref baslangicsutun,ref fircadurum);    //bulundugu kare haric 3 kare ziplar.
                   else if (baslangicdurum == 2)
                       obj.AsagiZipla(ref baslangicsatir, baslangicsutun,ref fircadurum);
                   else if (baslangicdurum == 3)
                       obj.SolZipla(baslangicsatir, ref baslangicsutun,ref fircadurum);
                   else if (baslangicdurum == 4)
                       obj.YukariZipla(ref baslangicsatir, baslangicsutun,ref fircadurum);

               }
               else if (dizi[i] == "8")
                   obj.goruntuleme();
               else if (dizi[i] == "0")
                   break;


           }
            
          
        }
    }
}
