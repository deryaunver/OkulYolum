using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OkulYolum
{
    public class Arayuz
    {
        public static string MenuOlustur(string[] menuler)
        {
            string menu = "\t╔════════════════════════════════════════════════════════╗\n \n";
            for (int i = 0; i < menuler.Length; i++)
            {
                menu += $"\n \t \t \t {i + 1} ► {menuler[i]} ";

            }
            menu += "\n\n \t╚════════════════════════════════════════════════════════╝";
            return menu;
        }

        public static void CizimYap()
        {
            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("\t \t \t OKUL YOLUM ÖĞRENCİ SERVİS TAKİP UYGULMASINA HOŞGELDİNİZ !!!\t \t \t \t \n");
            Console.WriteLine(" \t \t \t \t \t  LÜTFEN BEKLEYİNİZ \n");
            Console.WriteLine("\t \t \t \t╔════════════════════════════════════╗");
            Console.WriteLine("\t \t \t \t║  ═══════    ═══════    ═══════     ║");
            Console.WriteLine("\t \t \t \t║  ║     ║    ║     ║    ║     ║     ║");
            Console.WriteLine("\t \t \t \t║  ║     ║    ║     ║    ║     ║     ║");
            Console.WriteLine("\t \t \t \t║  ═══════    ═══════    ═══════     ╚════════╗");
            Console.WriteLine("\t \t \t \t║                                             ║");
            Console.WriteLine("\t \t \t \t║          ♥♥♥ OKUL YOLUM ♥♥♥                 ║");
            Console.WriteLine("\t \t \t \t║                                             ║");
            Console.WriteLine("\t \t \t \t║        ______          ______               ║");
            Console.WriteLine("\t \t \t \t╚═══════║      ║════════║      ║══════════════╝");
            Console.WriteLine("\t \t \t \t        ║______║        ║______║               ");


        }

        public static string OgrenciGoruntule(List<Ogrenci> liste)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            string cizgi = "\n \t╔════════════════════════════════════════════════════════╗\n \n";
            for (int i = 0; i < liste.Count; i++)
            {
                cizgi+=$"\t {i + 1}.ÖĞRENCİ \n \t \t \t  ÖĞRENCİ ADI : {liste[i].OgrenciAd}\n \t\t \t  ÖĞRENCİ SOYADI : {liste[i].OgrenciSoyad}\n \t\t \t  OĞRENCİ NUMARASI: {liste[i].OgrenciNumara}";
                cizgi += "\n\n \t╚════════════════════════════════════════════════════════╝\n";
            }

            return cizgi;
            
        }
   
        public static string ServisGoruntule(List<Servis> liste)
        {
            
            #region alternatif yol
            //string cizgi = "\n \t╔════════════════════════════════════════════════════════╗\n \n";

            //for (int i = 0; i < liste.Count; i++)
            //{

            //    cizgi += $" \t {i+1}.SERVİS \n \t\t \t SERVİS SÜRÜCÜSÜ : {liste[i].ServisSurucu}\n \t\t \t SERVİS MARKASI: {liste[i].ServisMarka}\n \t\t \t SERVİS PLAKA: {liste[i].ServisPlaka}";
            //    cizgi += "\n\n \t╚════════════════════════════════════════════════════════╝\n";
            //}

            //return cizgi; 
            #endregion
            string cizgi = "\n \t╔════════════════════════════════════════════════════════╗\n \n";
            int servisSayisi = 0;
            foreach (var servis in liste)
            {
                servisSayisi++;
                cizgi += $" \t {servisSayisi}.SERVİS \n \t\t \t SERVİS SÜRÜCÜSÜ : {servis.ServisSurucu}\n \t\t \t SERVİS MARKASI: {servis.ServisMarka}\n \t\t \t SERVİS PLAKA: {servis.ServisPlaka}";
                cizgi += "\n\n \t╚════════════════════════════════════════════════════════╝\n";

            }

            return cizgi;
        }


       
    }
}
