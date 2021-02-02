using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            
            //array - dizi (yukarıdakileri tek tek konsolda yazmak yerine aşağıda tek satırda yazdık hepsini.)

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs", "java","Python","C++","C#" };


            //yukarıdaki string[] arrayini yazdırdık for ile tek tek
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            // kursları dolaş. Foreach dizilere uygulanır. Bu diziler için  daha kolay for a göre.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            


        }
    }
}
