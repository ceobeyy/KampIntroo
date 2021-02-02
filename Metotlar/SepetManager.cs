using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{ //manager olan yer operasyon tutuyor demektir.
    class SepetManager
    {
        public void Ekle(Urun urun) //Urun veri tipimizz yani asıl class ımız, yanındakı urun ise ilişkilendirceğimiz takma ad. 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "  + urun.Adi);
        }

        //uzun yol , tek tek yazmak 
        public void Ekle2(string urunAdi , string aciklama , double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
