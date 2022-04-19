using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45DersMetotlardaOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //EGER AYNI ISIMDE ANCAK FARKLI PARAMETRE ALAN BIRDEN FAZLA METOT OLUSTURURSAK OVERLOADING YAPMIS OLURUZ.
            //FONKSIYONU CAGIRIRKEN KULANDIGIMIZ PARAMETRE SAYISINA GORE ILGILI METOTU KENDI BULUR...
            //SADECE PARAMETRE SAYISI DEGIL, PARAMETRE TURUNU FARKLILASTIRARAK DA OVERLOADING YAPABILIRIZ (INT, DOUBLE VS.)
            Console.WriteLine(isimSoyle("Murat")); 
            Console.WriteLine(isimSoyle("Murat","Pala"));

            Console.ReadLine();
        }

        static string isimSoyle(string isim)
        {
            return "Tek parametreli metot: " + isim;
        }

        static string isimSoyle(string isim, string soyIsim)
        {
            return "İki parametreli metot: " + isim + " " + soyIsim;
        }
    }
}
