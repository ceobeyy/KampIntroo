using System;

namespace KampIntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişken oluşturma vs.
            string KategoriEtiketi = "kategoriEtiketi";
            int OgrenciSayısı = 32000;
            double Oran = 1.45;
            bool sistemeGirisYapmısMi = false;
            //Şart blokları
            double dolarDün = 7.35;
            double dolarBugün = 7.45;

            if (dolarDün>dolarBugün)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDün<dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmısMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


        }


    }
}
