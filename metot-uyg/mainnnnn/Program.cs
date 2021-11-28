using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainnnnn
{
    class Program
    {
        static void Main(string[] args)
        {
            yenidenişlemyap:
        matematikselişlemler m = new matematikselişlemler();
            m.menuhazırla();
            int kulanıcısecim = int.Parse(Console.ReadLine());

            Console.WriteLine( "lütfen birinci sayı değerini giriniz");
            decimal kulanıcısayı1 = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine(" lütfen ikinci sayı değerini giriniz ");
            decimal kulanıcısayı2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;
            switch(kulanıcısecim)
                {
                case 1://topla
                    sonuc = m.toplamaıslemi(kulanıcısayı1, kulanıcısayı2);
                    m.sonucekranayaz(kulanıcısayı1, kulanıcısayı2, sonuc, "+");
                    break;
                case 2://çıkar
                    sonuc = m.bölmeıslemi(kulanıcısayı1, kulanıcısayı2);
                    m.sonucekranayaz(kulanıcısayı1, kulanıcısayı2, sonuc, "-");
                    break;
                case 3://çarp
                    sonuc = m.çarpmaıslemi(kulanıcısayı1, kulanıcısayı2);
                    m.sonucekranayaz(kulanıcısayı1, kulanıcısayı2, sonuc, "*");
                    break;
                case 4://bölme
                    sonuc = m.bölmeıslemi(kulanıcısayı1, kulanıcısayı2);
                    m.sonucekranayaz(kulanıcısayı1, kulanıcısayı2, sonuc, "/");
                    break;
                default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içerisinde bulunmamaktadır");
                    Console.WriteLine("lütfen yeniden deneyiniz");
                    System.Threading.Thread.Sleep(2000);
                    goto yenidenişlemyap;
            }
            Console.WriteLine("yeniden işlem yapmak istiyormusunuz? [E/H]");
            string EH = Console.ReadLine();
            if(EH=="E" || EH=="e")
                {
                goto yenidenişlemyap;
            }

        }         
    }
}
