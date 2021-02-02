using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        { // eğer class yapmayıp sadece tek tek string int gibi yazsaydım o zaman  dizi oluşturamazdım.
          // o yüzden class kullanırız.Burdaki örnekte sadece string olanlardan dizi oluşturabilirdim.
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            // bizi ilgilendiren kısım bundan sonrası classlar yani işimizi kolaylaştıran şey.Burada hepsinnden bir dizi oluşturabilirim.
            //çünkü klass tanımladım ve int string gibi ifadelerin hepsini tek bir çatı altında yani class ta tanımladım.

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

             //yukarıda yaptığğımız işlerler classıntro dakiler gibi, hatta aynısı.  


            }

            Console.WriteLine("--------Metotlar---------");

            
            SepetManager sepetManager = new SepetManager(); //class çağırmak ( aynısını yukaruda urune de yaptık)

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //uzun yolun özelliklerini tanımladık. Encopsulation
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,11);


        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practise
