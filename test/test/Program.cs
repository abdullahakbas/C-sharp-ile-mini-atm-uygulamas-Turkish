using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wilee = 10;
            int bakiye = 1000;

            do
            {
                Console.WriteLine("İş Bank Atm sine Hoşgeldiniz");
                Console.WriteLine("Lütfen Yapmak İstediğiniz işlemi seçiniz;");
                Console.WriteLine();
                Console.WriteLine("1. Bakiye öğrenme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Para Çekme");
                int istenilen = Convert.ToInt32(Console.ReadLine());

                if (istenilen == 1)
                {
                    Console.WriteLine("Bakiye öğrenme ekranına hoşgeldiniz");
                    Console.WriteLine("Bakiyeniz " + bakiye + " tl dir");
                    Console.WriteLine();
                    Console.WriteLine("9 .Başka bir işlem yapmak istiyorsanız");
                    Console.WriteLine("0 .çıkış yapmak istiyorsanız");
                    int veri = Convert.ToInt32(Console.ReadLine());

                    if (veri == 9)
                    {
                        Console.WriteLine("Ana Sayfaya yönlendiriliyorsunuz");
                        Console.WriteLine("Lütfen herhangi bir tuşa basınız");
                        Console.ReadLine();
                    }

                    else if (veri == 0)
                    {
                        Console.WriteLine("Hesabınızdan Çıkış yapıldı");
                        Console.WriteLine("İyi Günler Dileriz");
                        wilee = wilee + 1;
                        Console.ReadLine();
                    }

                }

                else if (istenilen == 2)
                {
                    Console.WriteLine("Para Yatırma Ekranına Hoşgeldiniz");
                    Console.WriteLine("bakiyeniz " + bakiye + " tl dir");
                    Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz");
                    int yatır = Convert.ToInt32(Console.ReadLine());
                    if (yatır > 0 && yatır < 2000000)
                    {
                        bakiye = bakiye + yatır;
                        Console.WriteLine("Paranız Yatırılmıştır");
                        Console.WriteLine("Yeni Bakiyeniz " + bakiye + " tl dir");
                        Console.WriteLine();
                        Console.WriteLine("9 .Başka bir işlem yapmak istiyorsanız");
                        Console.WriteLine("0 .çıkış yapmak istiyorsanız");
                        int veri1 = Convert.ToInt32(Console.ReadLine());
                        if (veri1 == 9)
                        {
                            Console.WriteLine("Ana Sayfaya yönlendiriliyorsunuz");
                            Console.WriteLine("Lütfen herhangi bir tuşa basınız");
                            Console.ReadLine();
                        }

                        else if (veri1 == 0)
                        {
                            Console.WriteLine("Hesabınızdan Çıkış yapıldı");
                            Console.WriteLine("İyi Günler Dileriz");
                            wilee = wilee + 1;
                            Console.ReadLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir meblağ giriniz");
                        Console.WriteLine("Tek seferde en fazla 2000000 tl yatırabilirsiniz");
                        Console.WriteLine("Ve unutmayın negatif değerler girilemez");
                        Console.WriteLine("Şimdilik hesabınızdan çıkış yapılıyor Yapmak istediğiniz işlemi tekrar deneyiniz");
                        wilee = wilee + 1;
                        Console.ReadLine() ;
                    }
                    
                }

                else if (istenilen == 3)
                {
                    Console.WriteLine("Para Çekme Ekranına Hoşgeldiniz");
                    Console.WriteLine("Bakiyeniz " + bakiye + " tl dir");
                    Console.WriteLine();
                    Console.WriteLine("Lütfen çekmek istediğniz tutarı giriniz");
                    int cekme = Convert.ToInt32(Console.ReadLine());
                    if (cekme > 0 && 2000000 > cekme)
                    {
                        if (cekme < bakiye)
                        {
                            bakiye = bakiye - cekme;
                            Console.WriteLine();
                            Console.WriteLine("Yeni Bakiyeniz " + bakiye + " tl dir");
                            Console.WriteLine();
                            Console.WriteLine("9 .Başka bir işlem yapmak istiyorsanız");
                            Console.WriteLine("0 .çıkış yapmak istiyorsanız");
                            int veri2 = Convert.ToInt32(Console.ReadLine());
                            if (veri2 == 9)
                            {
                                Console.WriteLine("Ana Sayfaya yönlendiriliyorsunuz");
                                Console.WriteLine("Lütfen herhangi bir tuşa basınız");
                                Console.ReadLine();
                            }

                            else if (veri2 == 0)
                            {
                                Console.WriteLine("Hesabınızdan Çıkış yapıldı");
                                Console.WriteLine("İyi Günler Dileriz");
                                wilee = wilee + 1;
                                Console.ReadLine();
                            }
                        }
                        else if (cekme > bakiye)
                        {
                            Console.WriteLine("Çekeceğiniz Para Bakiyenizden Çok Olamaz");
                            Console.WriteLine("Hesabınızdan çıkış yapılıyor... Lütefen tekrar deneyiniz.");
                            wilee += 1;
                            Console.ReadLine() ;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir meblağ giriniz");
                        Console.WriteLine("Tek seferde en fazla 2000000 tl çekebilirsiniz");
                        Console.WriteLine("Ve unutmayın negatif değerler girilemez");
                        Console.WriteLine("Şimdilik hesabınızdan çıkış yapılıyor Yapmak istediğiniz işlemi tekrar deneyiniz");
                        wilee = wilee + 1;
                        Console.ReadLine();
                    }

                }
            } while (wilee == 10);
        }
    }
}
