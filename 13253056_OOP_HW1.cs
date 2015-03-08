using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingHomeWork1
{
    class Program
    {
        static int OgrenciSayisi;
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {

            int menusecim,ekleogrenci=0;
            string menusecimstring;
            do
            {
                Console.WriteLine("1-Ogrenci Bilgi girisi yap");
                Console.WriteLine("2-Ogrenci Bilgilerini Goruntule");
                Console.WriteLine("3-Ders Sınav Ortalaması Goruntule");
                Console.WriteLine("4-60'dan dusuk notları Goruntule");
                Console.WriteLine("5-Ortalamadan yuksek notları Goruntule");
                Console.WriteLine("6-60 altında olan notların sayısını goruntule");
                Console.WriteLine("7-En yuksek notu goruntule");
                Console.WriteLine("8-En dusuk notu goruntule");
                Console.WriteLine("9-Genel ortalamaya gore ogrenci bilgilerini sıralayarak goster");
                Console.WriteLine("10-Ogrenci numarasına gore ogrenci bilgilerini goster");
                Console.WriteLine("Programdan çıkış yapmak için 10 sayısından büyük herhangi bir sayıyı yazıp enter tuşuna basınız.");
                Console.Write("Seciminiz = ");
                menusecimstring = Console.ReadLine();
                menusecim = int.Parse(menusecimstring);
                
                if (menusecim == 1)
                {
                    Console.Clear();
                    OgrenciSayisi = OgrenciSayiGiris();
                    OgrenciSayisi = OgrenciSayisi + ekleogrenci;
                    ekleogrenci = OgrenciBilgiGiris(ekleogrenci,OgrenciSayisi);
                    ekrantemizlemenuyedon();
                }
                else if(menusecim==2)
                {
                    Console.Clear();
                    BilgiGoruntule(OgrenciSayisi);
                    ekrantemizlemenuyedon();
                }
                else if(menusecim==3)
                {
                    Console.Clear();
                    menusecim = 0;
                    Console.WriteLine("1-OOP Dersi Ortalama Goruntule");
                    Console.WriteLine("2-Seminer Dersi Ortalama Goruntule");
                    Console.WriteLine("3-Ayrık Matematiksel Yapılar Dersi Ortalama Goruntule");
                    Console.Write("Seciminiz = ");
                    menusecimstring = Console.ReadLine();
                    menusecim = int.Parse(menusecimstring);
                    if (menusecim == 1)
                    { 
                        Console.WriteLine("OOP Ortalama:" + DersOrtalamaHesapla(OOP));
                    }
                    else if (menusecim == 2)
                    {
                        Console.WriteLine("Ayrik Matematiksel Yapilar Ortalama:" + DersOrtalamaHesapla(AyrikMatematikselYapilar));     
                    }
                    else if (menusecim == 3)
                    {
                        Console.WriteLine("Seminer Ortalama:" + DersOrtalamaHesapla(Seminer));
                    }
                    ekrantemizlemenuyedon();
                }
                else if (menusecim == 4)
                {
                    Console.Clear();
                    menusecim = 0;
                    Console.WriteLine("1-OOP (60) altı notları goruntule");
                    Console.WriteLine("2-Seminer (60) altı notları goruntule");
                    Console.WriteLine("3-Ayrık Matematiksel Yapılar (60) altı notları goruntule");
                    Console.Write("Seciminiz = ");
                    menusecimstring = Console.ReadLine();
                    menusecim = int.Parse(menusecimstring);
                    if (menusecim == 1)
                    {
                        kucuk_60(OOP);
                    }
                    else if (menusecim == 2)
                    {
                        kucuk_60(AyrikMatematikselYapilar);
                    }
                    else if (menusecim == 3)
                    {
                        kucuk_60(Seminer);
                    }
                    ekrantemizlemenuyedon();
                }
                else if (menusecim == 5)
                {
                    Console.Clear();
                    menusecim = 0;
                    Console.WriteLine("1-OOP ortalama ustu notları goruntule");
                    Console.WriteLine("2-Seminer ortalama ustu notları goruntule");
                    Console.WriteLine("3-Ayrık Matematiksel Yapılar ortalama ustu notları goruntule");
                    Console.Write("Seciminiz = ");
                    menusecimstring = Console.ReadLine();
                    menusecim = int.Parse(menusecimstring);
                    if (menusecim == 1)
                    {
                        buyuk_ort(OOP);
                    }
                    else if (menusecim == 2)
                    {
                        buyuk_ort(AyrikMatematikselYapilar);
                    }
                    else if (menusecim == 3)
                    {
                        buyuk_ort(Seminer);
                    }
                    ekrantemizlemenuyedon();
                }
                else if (menusecim == 6)
                {
                    Console.Clear();
                    Console.WriteLine("OOP dersinde " + kucuk_60_sayisi(OOP) + " kisi 60 altında not almis.");
                    Console.WriteLine("Ayrik Matematiksel Yapilar dersinde " + kucuk_60_sayisi(AyrikMatematikselYapilar) + " kisi 60 altında not almis.");
                    Console.WriteLine("Seminer dersinde " + kucuk_60_sayisi(Seminer) + " kisi 60 altında not almis.");
                    ekrantemizlemenuyedon();
                }
                else if (menusecim == 7)
                {
                    Console.Clear();
                    menusecim = 0;
                    Console.WriteLine("1-OOP dersi icin en yuksek notu goruntule");
                    Console.WriteLine("2-Seminer dersi icin en yuksek notu goruntule");
                    Console.WriteLine("3-Ayrık Matematiksel Yapılar dersi icin en yuksek notu goruntule");
                    Console.Write("Seciminiz = ");
                    menusecimstring = Console.ReadLine();
                    menusecim = int.Parse(menusecimstring);
                    if (menusecim == 1)
                    {
                        Console.WriteLine("OOP dersi icin en yuksek not : " + maximum(OOP));
                    }
                    else if (menusecim == 2)
                    {
                        Console.WriteLine("Seminer dersi icin en yuksek not : " + maximum(Seminer));
                    }
                    else if (menusecim == 3)
                    {
                        Console.WriteLine("Ayrık Matematiksel Yapılar dersi icin en yuksek not : " + maximum(AyrikMatematikselYapilar));
                    }
                    ekrantemizlemenuyedon();
                }
                else if (menusecim == 8)
                {
                    Console.Clear();
                    menusecim = 0;
                    Console.WriteLine("1-OOP dersi icin en dusuk notu goruntule");
                    Console.WriteLine("2-Seminer dersi icin en dusuk notu goruntule");
                    Console.WriteLine("3-Ayrık Matematiksel Yapılar dersi icin en dusuk notu goruntule");
                    Console.Write("Seciminiz = ");
                    menusecimstring = Console.ReadLine();
                    menusecim = int.Parse(menusecimstring);
                    if (menusecim == 1)
                    {
                        Console.WriteLine("OOP dersi icin en dusuk not : " + minimum(OOP));
                    }
                    else if (menusecim == 2)
                    {
                        Console.WriteLine("Seminer dersi icin en dusuk not : " + minimum(Seminer));
                    }
                    else if (menusecim == 3)
                    {
                        Console.WriteLine("Ayrık Matematiksel Yapılar dersi icin en dusuk not : " + minimum(AyrikMatematikselYapilar));
                    }
                    ekrantemizlemenuyedon();
                }
                else if(menusecim==9)
                {
                    Console.Clear();
                    derstoplam();
                    ekrantemizlemenuyedon();
                }
                else if(menusecim==10)
                {
                    Console.Clear();
                    ogrencinumarasinagoresirala();
                    ekrantemizlemenuyedon();
                }
            } while (menusecim <=10);
 
        }
        public static int SinavSonucGiris()
        {
            int gecicinotbilgisitutma;
            string notgiris;
            notgiris = Console.ReadLine();
            gecicinotbilgisitutma = int.Parse(notgiris);
            return gecicinotbilgisitutma;
        }
        static int OgrenciSayi;
        public static int[] ogrencinumara = new int[30];
        public static int[] OOP = new int[30];
        public static int[] Seminer = new int[30];
        public static int[] AyrikMatematikselYapilar = new int[30];
        public static string[] ogrenciadsoyad = new string[30];
        public static string OgrenciNumaraString;
        public static int OgrenciBilgiGiris(int ekleogrenci, int OgrenciSayisi)
        {
            int i;
            for (i = ekleogrenci; i < OgrenciSayisi; i++)
            {
                Console.Write(i + 1 + ". Ogrencinin numarasini giriniz:");
                OgrenciNumaraString = Console.ReadLine();
                ogrencinumara[i] = int.Parse(OgrenciNumaraString);
                Console.Write(i + 1 + ". Ogrencinin ad ve soyadını giriniz:");
                ogrenciadsoyad[i] = Console.ReadLine();
                Console.Write("OOP Dersi Notunu Giriniz :");
                OOP[i] = SinavSonucGiris();
                Console.Write("Ayrık Matematiksel Yapılar Dersi Notunu Giriniz Giriniz :");
                AyrikMatematikselYapilar[i] = SinavSonucGiris();
                Console.Write("Seminer Dersi Notunu Giriniz :");
                Seminer[i] = SinavSonucGiris();
            }
            return i;
        }
        public static int BilgiGoruntule(int OgrenciSayisi)
        {
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                Console.WriteLine(i + 1 + "." + ogrencinumara[i] +
                    " numaralı " + ogrenciadsoyad[i] +
                    " adlı ogrencinin " + " OOP Dersi Notu:" + OOP[i] +
                    " Ayrık Matematiksel Yapılar Dersi Notu:" + AyrikMatematikselYapilar[i] +
                    " Seminer Dersi Notu:" + Seminer[i]);
            }
            return 0;
        }                                                                

        public static int OgrenciSayiGiris()
        {
            string OgrenciSayiString;
            Console.Write("Kac adet ogrenci bilgisi gireceksiniz :");
            OgrenciSayiString = Console.ReadLine();
            OgrenciSayi = int.Parse(OgrenciSayiString);
            return OgrenciSayi;
        }
        public static float DersOrtalamaHesapla(int[] deger)
        {
            int toplam = 0;
            for (int i = 0; i < OgrenciSayisi;i++ )
            {
                toplam = toplam + deger[i];
            }
                return (float)toplam / OgrenciSayisi; 
        }
        public static void kucuk_60(int[] deger)
        {
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                 if(deger[i]<60)
                 {
                     Console.WriteLine(ogrencinumara[i] + " " + ogrenciadsoyad[i] + " " + deger[i]);
                 }
            }
        }
        public static void buyuk_ort(int[] deger)
        {
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                if (deger[i] > DersOrtalamaHesapla(deger))
                {
                    Console.WriteLine(ogrencinumara[i] + " " + ogrenciadsoyad[i] + " " + deger[i]);
                }
            }

        }
        public static int kucuk_60_sayisi(int[] deger)
        {
            int dusuknot = 0;
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                if (deger[i] < 60)
                {
                    dusuknot++;
                }
            }
            return dusuknot;
        }
        public static int minimum(int[] deger)
        {
            int minimum = deger[0];
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                if (deger[i] < minimum)
                {
                    minimum = deger[i];
                }
            }
            return minimum;
        }
        public static int maximum(int[] deger)
        {
            int maximum = deger[0];
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                if (deger[i] > maximum)
                {
                    maximum = deger[i];
                }
            }
            return maximum;
        }
        public static void derstoplam()
        {
            int gecici = 0;
            int[] indextut = new int[30];
            int[] dersnottoplam = new int[30];
            int[] dersnottoplam2 = new int[30];
            for(int i=0;i<OgrenciSayisi;i++)
            {
                dersnottoplam[i] = OOP[i] + Seminer[i] + AyrikMatematikselYapilar[i];    // 3 dersin not toplamını bulan kod.
                dersnottoplam2[i] = OOP[i] + Seminer[i] + AyrikMatematikselYapilar[i];
            }
            int a = 0;
            for (a = 0; a < OgrenciSayisi; a++)
            {
                gecici = dersnottoplam[0];// gecici degiskeninde döngü başlangıcındaki ilk değeri atıyor                                          // indextut[a] degiskenine a yı atıyor.
                for (int i = 1; i < OgrenciSayisi; i++)
                {
                    if (dersnottoplam[i] < gecici)
                    {
                        gecici = dersnottoplam[i];
                        indextut[a] = i;
                    }
                    else if (gecici != dersnottoplam2[0])
                    {

                    }
                    else
                    {
                        indextut[a] = 0;
                    }
                }
                dersnottoplam[indextut[a]] = 999999;
            }
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                Console.WriteLine(i + 1 + "-" + ogrencinumara[indextut[i]] +
     " numaralı " + ogrenciadsoyad[indextut[i]] +
     " adlı ogrencinin " + " OOP Dersi Notu:" + OOP[indextut[i]] +
     " Ayrık Matematiksel Yapılar Dersi Notu:" + AyrikMatematikselYapilar[indextut[i]] +
     " Seminer Dersi Notu:" + Seminer[indextut[i]]);
            }
        }
        public static void ogrencinumarasinagoresirala()
        {
            int gecici = 0;
            int[] indextut = new int[30];
            int[] ogrencinosirala= new int[30];
            int[] ogrencinosirala2 = new int[30];
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                ogrencinosirala[i] = ogrencinumara[i];    // 3 dersin not toplamını bulan kod.
                ogrencinosirala2[i] = ogrencinumara[i];
            }
            int a = 0;
            for (a = 0; a < OgrenciSayisi; a++)
            {
                gecici = ogrencinosirala[0];// gecici degiskeninde döngü başlangıcındaki ilk değeri atıyor                                          // indextut[a] degiskenine a yı atıyor.
                for (int i = 1; i < OgrenciSayisi; i++)
                {
                    if (ogrencinosirala[i] < gecici)
                    {   
                        gecici = ogrencinosirala[i];
                        indextut[a] = i;
                    }
                    else if(gecici != ogrencinosirala2[0])
                    {
                        
                    }
                    else
                    {
                        indextut[a] = 0;     
                    }
                }
                ogrencinosirala[indextut[a]] = 999999;
            }
            for (int i = 0; i < OgrenciSayisi; i++)
            {
                Console.WriteLine(i + 1 + "-" + ogrencinumara[indextut[i]] +
     " numaralı " + ogrenciadsoyad[indextut[i]] +
     " adlı ogrencinin " + " OOP Dersi Notu:" + OOP[indextut[i]] +
     " Ayrık Matematiksel Yapılar Dersi Notu:" + AyrikMatematikselYapilar[indextut[i]] +
     " Seminer Dersi Notu:" + Seminer[indextut[i]]);
            }
        }
        public static void ekrantemizlemenuyedon()
        {
            Console.WriteLine("Ekranı temizlemek ve ana menuye donmek icin bir tusa basiniz.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
    
