
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Donem2odev1
{
    class Program
    {

        //Matris metodu
        static void Matris()
        {
            //MATRİS 
            Console.WriteLine("..:: Matris işlemleri ::..");
            Console.WriteLine("Matrisin satır x sütün sayısını giriniz(1-10 arasında)");

            int m = Convert.ToInt32(Console.ReadLine());

            if (m < 11 && m > 0)
            {
                m = m + 1;
                int i, j;
                int[,] arr1 = new int[m, m];

                Console.Write("\n\n3X3 Boyununda 2 boyutlu bir dizi okuyun ve matrisi yazdırın :\n");
                Console.Write("********************\n");

                Console.Write("MATRIS Giriş öğesi :\n");
                for (i = 1; i < m; i++)
                {
                    for (j = 1; j < m; j++)
                    {
                        Console.Write("deger - [{0},{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\n MATRİS : \n");
                for (i = 1; i < m; i++)
                {
                    Console.Write("\n");
                    for (j = 1; j < m; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }
                Console.Write("\n\n");

                Console.WriteLine("1- En büyük satır");
                Console.WriteLine("2- Satırların Toplamı");
                while (true)
                {

                    Console.Write("Seçiminiz: ");
                    string matrissecim = Console.ReadLine();


                    if (matrissecim == "1")
                    {
                        int degisken = 0;
                        for (int asd = 1; asd < m; asd++)
                        {
                            degisken = 0;
                            for (int das = 1; das < m; das++)
                            {
                                if (degisken < arr1[asd, das])
                                {
                                    degisken = arr1[asd, das];
                                }
                            }
                            Console.Write(degisken + " ");
                        }
                        Console.WriteLine(" ");
                        MenuDon();
                        break;
                    }
                    //Satır toplam

                    else if (matrissecim == "2")
                    {
                        for (int a = 1; m > a; a++)
                        {
                            double sum = 0.0;
                            for (int b = 1; b < m; b++)
                            {
                                sum += arr1[a, b];
                            }
                            Console.Write(sum + "\t");

                            Console.WriteLine(" ");
                            MenuDon();
                            break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız lütfen tekrar deneyiniz");
                        Console.Clear();
                        Matris();
                    }


                }
            }

            else
            {
                Console.WriteLine("Hatalı giriş yaptınız! Lütfen 1 ila 10 arası değer giriniz.");
            }


        }

        //String metodu
        static void String()
        {
            //Stringle ilgili islemler
            Console.WriteLine("*String işlemleri*");
            Console.Write("String'i giriniz :");
            string kelime = Console.ReadLine();
            Console.Write("İstenilen Harf : ");
            char harf = Convert.ToChar(Console.ReadLine());


            int sayac = 0;

            foreach (var x in kelime)
            {

                if (x == harf)
                {
                    sayac++;
                }
            }

            if (sayac >= 2)
            {
                while (true)
                {
                    Console.WriteLine("1-Ara metni tersten yazma");
                    Console.WriteLine("2-Ara metni tekrarlı yazma");
                    Console.Write("Seçiminiz: ");
                    string stringsecim = Console.ReadLine();
                    int[] terssayac = new int[2];
                    int sayac1 = 0;

                    int yersayac = 0;

                    for (int i = 0; i < kelime.Length; i++)
                    {

                        if (kelime[i] == harf)
                        {

                            terssayac[yersayac] = sayac1;
                            yersayac++;

                        }
                        sayac1++;
                    }

                    if (stringsecim == "1")
                    {

                        Console.WriteLine(" ");

                        for (int i = terssayac[1] - 1; i > terssayac[0]; i--)
                        {
                            Console.Write(kelime[i]);

                        }
                        MenuDon();
                        break;

                    }

                    else if (stringsecim == "2")
                    {
                        Console.WriteLine(" ");
                        for (int j = 0; j < 5; j++)
                        {
                            for (int i = terssayac[0] + 1; i < terssayac[1]; i++)
                            {
                                Console.Write(kelime[i]);
                            }

                            Console.WriteLine("\n");
                        }
                        MenuDon();
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız.");
                    }
                }

            }

            else
            {
                Console.WriteLine("Cümle içerisinde aranan harf bulunamamıştır.");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                String();
            }

        }
        //MENU     
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1- Matris işlemleri");
                Console.WriteLine("2-String işlemleri");
                Console.WriteLine("3-Çıkış");
                Console.Write("Seçiminizi Giriniz : ");

                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.Clear();
                    Matris();

                    break;
                }

                else if (secim == "2")
                {
                    Console.Clear();
                    String();
                    break;
                }


                else if (secim == "3")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Program sonlandırılıyor...");
                    break;
                }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("YANLIŞ SEÇİM!");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            }

        }
        //MENU DONUSUM
        static void MenuDon()
        {
            Console.WriteLine("\n ANA MENÜYE DÖNMEK İÇİN BİR TUŞA BAS");
            Console.ReadKey();
            Console.WriteLine("ANA MENÜYE YÖNLENDİRİLİYORSUNZ...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Menu();
        }


        static void Main(string[] args)
        {
            Menu();
        }
    }

}

