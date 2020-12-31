using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OkulYolum
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "  ☻☻☻ OKUL YOLUM ☻☻☻  ";
            string[] menuler =
            {
                "ÖĞRENCİ EKLE", "SERVİS EKLE", "SERVİS GÖRÜNTÜLE", "ÖĞRENCİ GÖRÜNTÜLE", "ÖĞRENCİ SİL", "SERVİS SİL",
                "ÇIKIŞ YAP"
            };
            for (int i = 0; i < 10; i++)
            {
                Arayuz.CizimYap();
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.WriteLine(Arayuz.MenuOlustur(menuler));
        
            bool durum = true;
            List<Servis> servisler = new List<Servis>();
            while (durum)
            {
                char secim = Console.ReadKey(true).KeyChar;
                switch (secim)
                {
                    case '1':
                        if (servisler.Count == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" \n \n \n \n \n \n\n \t \t  Sitemde Kayıtlı Servis bulunmadığından öğrenci ekleme işlemini gerçekleştiremiyoruz!\n \n\t \t \t \t \t Lütfen sisteme servis ekleyiniz!!!  ".ToUpper());
                            Console.ForegroundColor = ConsoleColor.Gray;
                            EkranYenile(menuler);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(Arayuz.ServisGoruntule(servisler));
                            Console.Write("\n \t \t  Öğrenci eklemek istediğiniz servisi seçiniz:");
                            int servisIndex = int.Parse(Console.ReadLine()) - 1;
                            Ogrenci ogrenci= new Ogrenci();
                            Console.Write("\n \t \t \t Öğrenci Adı: ");
                            ogrenci.OgrenciAd = Console.ReadLine().ToUpper();
                            Console.Write("\t \t \t Öğrenci Soyadı: ");
                            ogrenci.OgrenciSoyad = Console.ReadLine().ToUpper();
                            Console.Write("\t \t \t Öğrenci Numara: ");
                            ogrenci.OgrenciNumara = int.Parse(Console.ReadLine().ToUpper());
                            servisler[servisIndex].Ogrenciler.Add(ogrenci);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("\n \n \t \t  ---> öğrenci ekleme işlemi tamamlandı <---\n \n".ToUpper());
                            EkranYenile(menuler);
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Servis servis = new Servis();
                        Console.WriteLine("\n \n \n \n");

                        Console.WriteLine("\t \t \t \t▒ ▒ ▒ SERVİS EKLEME MODÜLÜ ▒ ▒ ▒");
                        Console.WriteLine("\t \t \t \t_________________________________\n");
                        Console.Write("\t \t \t \t Servis Sürücü: ");
                        servis.ServisSurucu = Console.ReadLine().ToUpper();
                        Console.Write("\t \t \t \t Servis Marka: ");
                        servis.ServisMarka = Console.ReadLine().ToUpper();
                        Console.Write("\t \t \t \t Servis Plaka: ");
                        servis.ServisPlaka = Console.ReadLine().ToUpper();
                        servisler.Add(servis);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\n \n \t \t \t ------> servis ekleme işlemi tamamlandı <------\n \n".ToUpper());
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        EkranYenile(menuler);
                      
                        break;
                    case '3':
                        if (servisler.Count == 0)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" \n \t \t \t SİSTEME KAYITLI SERVİS BULUNAMADI\n  \t \tTEKRAR İŞLEM YAPABİLMEK İÇİN LÜTFEN BEKLEYİNİZ...");
                            EkranYenile(menuler);
                        }
                        else
                        {
                            Console.WriteLine(Arayuz.ServisGoruntule(servisler));
                            EkranYenile(menuler);
                        }

                        break;
                    case '4':
                      
                        if (servisler.Count == 0 )
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" \n \t \t \tSİSTEME KAYITLI ÖĞRENCİ BULUNAMADI\n \t \tTEKRAR İŞLEM YAPABİLMEK İÇİN LÜTFEN BEKLEYİNİZ...");
                            EkranYenile(menuler);
                        }
                        
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.WriteLine(Arayuz.ServisGoruntule(servisler));
                            Console.Write("\n \t Öğrencilerini görüntülemek istediğiniz servisi seçiniz: ".ToUpper());
                            int goruntulenecekServisIndex = int.Parse(Console.ReadLine()) - 1;
                           
                            Console.WriteLine(Arayuz.OgrenciGoruntule(servisler[goruntulenecekServisIndex].Ogrenciler));
                            EkranYenile(menuler);
                        }
                        break;
                    case '5':
                        if (servisler.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" \n \t \t \tSİSTEME KAYITLI ÖĞRENCİ BULUNAMADI\n \t \tTEKRAR İŞLEM YAPABİLMEK İÇİN LÜTFEN BEKLEYİNİZ...");
                            EkranYenile(menuler);
                        }
                        else
                        {
                            Console.WriteLine(Arayuz.ServisGoruntule(servisler));
                            Console.Write("\n \tÖğrencilerini silmek istediğiniz servisi seçiniz: ".ToUpper());
                            int ogrenciSilinecekServisIndex = int.Parse(Console.ReadLine()) - 1;
                            Console.WriteLine(Arayuz.OgrenciGoruntule(servisler[ogrenciSilinecekServisIndex].Ogrenciler));
                            Console.Write("\n \tSilmek istediğiniz öğrenciyi seçiniz: ".ToUpper());
                            int silinecekOgrenciIndex = int.Parse(Console.ReadLine()) - 1;
                            servisler[ogrenciSilinecekServisIndex].Ogrenciler.RemoveAt(silinecekOgrenciIndex);
                            Console.WriteLine("\n \tseçmiş olduğunuz öğrenci kayıtlı servisten silinmiştir...".ToUpper());
                            Console.WriteLine("\n \tAna  menüye dönüş için lütfen bekleyiniz . . . ".ToUpper());
                            EkranYenile(menuler);
                        }
                     
                        break;
                    case '6':
                        if (servisler.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" \n \t \t \tSİSTEME KAYITLI SERVİS BULUNAMADI\n \t \tTEKRAR İŞLEM YAPABİLMEK İÇİN LÜTFEN BEKLEYİNİZ...");
                            EkranYenile(menuler);
                        }
                        else
                        {
                            Console.WriteLine(Arayuz.ServisGoruntule(servisler));
                            Console.Write("\n \tsilmek istediğiniz servisi seçiniz!!!".ToUpper());
                            int secilenServis2 = int.Parse(Console.ReadLine()) - 1;
                            servisler.RemoveAt(secilenServis2);
                            Console.WriteLine("\n \tseçmiş olduğunuz servis sistemden silinmiştir...".ToUpper());
                            Console.WriteLine("\n \tAna  menüye dönüş için lütfen bekleyiniz . . . ".ToUpper());
                            EkranYenile(menuler);
                        }
                      
                        break;
                    case '7':
                        Console.WriteLine("\n \t \t  Çıkış Yapmak istediğinize emin misiniz(E/H)");
                        char cıkıs = Console.ReadKey(true).KeyChar;
                        if (cıkıs == 'E' || cıkıs == 'e')
                        {
                            durum = false;
                        }
                        else if (cıkıs == 'H' || cıkıs == 'h')
                        {
                            Console.Clear();
                            Console.WriteLine(Arayuz.MenuOlustur(menuler));

                        }
                        else
                        {
                            Console.WriteLine("\n \t Geçerli bir seçim yapmadınız!!!");
                            Console.Clear();
                            Console.WriteLine(Arayuz.MenuOlustur(menuler));
                        }
                        break;
                    default:
                        Console.Write("\n \t geçerli bir seçim yapmadınız!!! Lütfen Tekrar Deneyin !!! ".ToUpper());
                        break;

                }
            }
            
        }

        static void EkranYenile(string[] menu)
        {
          
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(3700);
            Console.Clear();
            Console.WriteLine(Arayuz.MenuOlustur(menu));
        }
    }
}
