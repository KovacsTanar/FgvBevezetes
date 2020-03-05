using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FgvBevezetes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb1 = new int[5] { 1, 1, 1, 4, 5, };

            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A {0} számnak ennyi osztója van: {1}", szam1, HanyOszto(szam1));
           
            Console.WriteLine("Prim? {0}",Prim_e(HanyOszto(szam1)));

            Console.Clear();
            Console.WriteLine("Melyik értéket keressem?");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            //Tipusos
             Console.WriteLine("Ennyiszer volt meg a tömbben a keresett érték: {0}", HarmasFeladat(szam2, tomb1));

            //voidos
            HarmasFeladatVoid(szam2, tomb1);


            SzerepelE(234, tomb1);

            Console.WriteLine("\nA tömb átlaga: {0:0.0}",TombAtlaga(tomb1));

            Console.WriteLine("\nEnnyivel 3-mal osztható, de 5-tel nem osztható szám van a tömbben: {0}",HatosFeladat(tomb1));

            Console.ReadKey();


            
        }

        static int HanyOszto(int szam)
        {
            int oszto = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                    oszto++;
            }

            return oszto;
        }

        static bool Prim_e(int osztok)
        {
            bool prim_e = false;
            if (osztok == 2)
                prim_e = true;
            return prim_e;
        }

        static int HarmasFeladat(int keresettErtek, int[] tomb)
        {
            int talalt = 0;

            foreach (var item in tomb)
            {
                if (item == keresettErtek)
                    talalt++;
            }

            return talalt;
        }

        static void HarmasFeladatVoid(int keresettErtek,int[] tomb)
        {
            int talalt = 0;
            foreach (var item in tomb)
            {
                if (item == keresettErtek)
                    talalt++;
            }

            Console.WriteLine("Ennyiszer volt meg a tömbben a keresett érték: {0}", talalt);

        }

        static void SzerepelE(int keresettSzam, int[] tomb)
        {
            int index = 0;
            while(index < tomb.Length && tomb[index] != keresettSzam)
            {
                index++;
            }

            if(index < tomb.Length)
                Console.WriteLine("Benne van!");
            else
                Console.WriteLine("Nincs benne!");
        }

        static double TombAtlaga(int[] tomb)
        {
            int osszeg = 0;

            foreach (var item in tomb)
            {
                osszeg += item;
            }

            double atlag = (double)osszeg / tomb.Length;
            return atlag;
        }

        static int HatosFeladat(int[] tomb)
        {
            int oszthato = 0;
            foreach (var item in tomb)
            {
                if (item % 3 == 0 && item % 5 != 0)
                    oszthato++;
            }

            return oszthato;
        }
    }
}
