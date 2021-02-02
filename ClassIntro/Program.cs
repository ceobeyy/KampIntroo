using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {//aşağıda oluşturduğumuz klass ve özelliklerine burada yani void kısmında isimlendirdik özellikleri.
            //BURASI İKİNCİ PART

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ömer Turan";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Turan";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Turan";
            kurs3.IzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Turan";
            kurs4.IzlenmeOranı = 100;


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen); bu da bir örnek olarak kalsın.


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 }; //döngülerdeki örnek gibi yaptık, bu sefer string değil kurs classı türü tanımladık.

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen); //bütün kursları listeledik eğitmenlerle birlikte.

            }

        }
    }
    // string gibi int gibi bir tür oluşturmak gibi düşün class ı. Hepsini bir arada tutan bir tür gibi..
    //BURASI BİRİNCİ PART
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

        


    }
}
