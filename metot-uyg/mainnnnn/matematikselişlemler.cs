using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainnnnn
{
    public class matematikselişlemler
    {
        //topla
        public decimal toplamaıslemi(decimal sy1, decimal sy2)
        {
            decimal sonuc = sy1 + sy2;
            return sonuc;
        }
        //çıkar
        public decimal çıkarmaıslemi(decimal sy1,  decimal sy2)
        {
            decimal sonuc = sy1 - sy2;
            return sonuc;
        }

        //çarp
        public decimal çarpmaıslemi(decimal sy1 , decimal sy2)
        {
            decimal sonuc = sy1 * sy2;
            return sonuc;
        }

        //bölme
        public decimal bölmeıslemi (decimal sy1 ,decimal sy2)
        {
            decimal sonuc = sy1 / sy2;
            return sonuc;
        }

        public void menuhazırla ()
        {
            Console.Clear();
            Console.WriteLine("****MENU****");
            Console.WriteLine("1-TOPLAMA");
            Console.WriteLine("2-ÇIKARMA");
            Console.WriteLine("3-ÇARPMA");
            Console.WriteLine("4-BÖLME");
            Console.Write("LÜTFEN DEĞER SEÇİNİZ:");
        }

        public void sonucekranayaz(decimal kulanıcısayı1, decimal kulanıcısayı2, decimal sonuc ,string operators)
        {
            Console.WriteLine("{0} {1} {2} ={3}" ,kulanıcısayı1 , operators, kulanıcısayı2, sonuc);
        }
      }
}
