using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savaitgalio_pasisprendimai
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             // 10-27, 35, 37,33
          
            //10uzduotis 

            Console.WriteLine("Iveskite kvadrato krastine");
            int krasitine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite apskirtimo spinduli");
            int spindulys = Convert.ToInt32(Console.ReadLine());

            if (spindulys <= krasitine )
            {
                Console.WriteLine("Katinas tilps per skyle");
            }
            else
            {
                Console.WriteLine("Katinas netilps per skyle");
            }
            

            //11uzduotis

            Console.WriteLine("Iveskite pinigu suma, kuria gauna seima per menesi (eur):");
            double suma = Convert.ToDouble(Console.ReadLine());

            double mokesciai = suma * 0.05;
            double maistas = suma * 0.5;
            double Rubai = suma * 0.3;
            double Pramogos = suma * 0.15;

            Console.WriteLine("Seima mokesciams isleidzia {0}, maistui {1}, rubams {2}, pramogoms {3}", mokesciai, maistas, Rubai, Pramogos);
            
            //12uzduotis 

            Console.WriteLine("Iveskite valandas ir minutes, kada buvo pradeta spresti uzduotis");
            int h1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite valandas ir minutes, kada buvo baigta spresti uzduotis");
            int h2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());

            int h = h2 - h1;
            int m = m2 - m1;

            if (m < 0)
            {
                h = h - 1;
                m = m + 60;
            }

            Console.WriteLine("Uzduociu sprendimui mokinys uztruko {0} valandu {1} minuciu", h, m );
            

            //13uzduotis 

            Console.WriteLine("Iveskite lazdeles ilgi jardais");
            int jardai1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite lazdeles ilgi pedom");
            int pedos1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite lazdeles ilgi coliais");
            int coliai1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Iveskite lazdeles ilgi jardais");
            int jardai2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite lazdeles ilgi pedom");
            int pedos2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite lazdeles ilgi coliais");
            int coliai2 = Convert.ToInt32(Console.ReadLine());

            int jardai3 = jardai1 + jardai2;
            int pedos3 = pedos1 + pedos2;
            int coliai3 = coliai1 + coliai2;
            

            if (coliai3 >= 12)
            {
                coliai3 = coliai3 - 12;
                pedos3 = pedos3 + 1;
            }
            if (pedos3 >= 3)
            {
                pedos3 = pedos3 - 3;
                jardai3 = jardai3 + 1;
            }

            Console.WriteLine("lazdeliu sumos ilgis {0} jardu, {1} pedu, {2} coliu", jardai3, pedos3, coliai3);
            

            //14uzdutis

            Console.WriteLine("Iveskite skysiu kieki galonais");
            double galonas1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skysiu kieki buseliais");
            double buselis1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite skysiu kieki galonais");
            double galonas2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skysiu kieki buseliais");
            double buselis2 = Convert.ToDouble(Console.ReadLine());

            double galonas = galonas1 + galonas2;
            double buselis = buselis1 + buselis2;

            if (galonas >= 8)
            {
                galonas = galonas - 8;
                buselis = buselis + 1;
            }

            Console.WriteLine("Is viso yra {0} buseliai ir {1} galonai ", buselis, galonas);

            double is_viso_galonu = buselis * 8 + galonas;
            double litrai = is_viso_galonu * 4.54069;

            Console.WriteLine("Is viso skysciu litrais {0}", litrai);
            

            //15uzduotis 

            Console.WriteLine("Iveskite, kiek turite pencu");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite, kiek turite silingu");
            int sh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite, kiek turite svaru");
            int s = Convert.ToInt32(Console.ReadLine());

            p = p + 1;

            if (p >= 12)
            {
                p = p - 12;
                sh = sh + 1;
            }
            if (sh >= 20)
            {
                sh = sh - 20;
                s = s + 1;
            }
            Console.WriteLine("Is viso yra {0} pencu, {1} silingu, {2} svaru", p, sh, s);
            

            //16uzduotis

            Console.WriteLine("Iveskite norima skaiciu paru");
            int p = Convert.ToInt32(Console.ReadLine());

            int valandos_per_para = p * 24;
            int minutes_per_para = p * 1440;
            int sekundes_per_para = p * 86400;

            Console.WriteLine("Paroje yra {0} sekundziu, {1} minuciu, {2} valandu", sekundes_per_para, minutes_per_para, valandos_per_para);
            

            //17uzduotis

            Console.WriteLine("iveskite skysti saikais");
            int saikai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite skysti gorciais");
            int gorciai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite skysti kvortomis");
            int kvortos = Convert.ToInt32(Console.ReadLine());

            kvortos = kvortos + 1;

            if (kvortos >= 4)
            {
                kvortos = kvortos - 4;
                gorciai = gorciai + 1;
            }
            if (gorciai >= 6)
            {
                gorciai = gorciai - 6;
                saikai = saikai + 1;
            }

            Console.WriteLine("Turite {0} saiku, {1} gorciu, {2} kvortu", saikai, gorciai, kvortos);
            

            //18uzduotis
            Console.WriteLine("Iveskite valandas, kada buvo pradetas spresti kontrolonis darbas");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite minutes, kada buvo pradetas spresti kontrolonis darbas");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite sekundes, kada buvo pradetas spresti kontrolonis darbas");
            int s1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Iveskite valandas, kada buvo baigtas spresti kontrolonis darbas");
            int h2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite minutes, kada buvo baigtas spresti kontrolonis darbas");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite sekundes, kada buvo baigtas spresti kontrolonis darbas");
            int s2 = Convert.ToInt32(Console.ReadLine());


            int h = h2 - h1;
            int m = m2 - m1;
            int s = s2 - s1;
            
            if (s < 0)
            {
                s = s + 60;
                m = m - 1;
            }
            if (m < 0)
            {
                m = m + 60;
                h = h - 1;
            }

            Console.WriteLine("Sprendziant kontroloni darba mokinys uztruko {0} valandu, {1} minuciu, {2} ekundziu", h, m,s);
            


            //19uzduotis 

            Console.WriteLine("Iveskite keturzenkli skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());

            int sk1 = sk / 1000;
            int sk2 = (sk % 1000) / 100;
            int sk3 = (sk % 100) / 10;
            int sk4 = sk % 10;


            int sk_atvirkscias = sk4 * 1000 + sk3 * 100 + sk2 * 10 + sk1;

            Console.WriteLine("Atvirskcias skaicius {0}", sk_atvirkscias);
            
            //20uzduotis
            Console.WriteLine("Iveskite keturzenkli skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());

            int sk1 = sk / 1000;
            int sk2 = (sk % 1000) / 100;
            int sk3 = (sk % 100) / 10;
            int sk4 = sk % 10;


            int sk_atvirkscias = sk4 * 1000 + sk1 * 100 + sk2 * 10 + sk3;

            Console.WriteLine("Atvirskcias skaicius {0}", sk_atvirkscias);

            
            //21uzduotis 

            Console.WriteLine("Iveskite valandas, kada buvo pradetas spresti kontrolonis darbas");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite minutes, kada buvo pradetas spresti kontrolonis darbas");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite sekundes, kada buvo pradetas spresti kontrolonis darbas");
            int s = Convert.ToInt32(Console.ReadLine());

            s--;

            if (s < 0)
            {
                s = s + 60;
                m = m - 1;
            }
            if (m < 0)
            {
                m = m + 60;
                h = h - 1;
            }

            Console.WriteLine("Pries sekunde laikrodis rade {0} valandu, {1} minuciu, {2} sekundziu", h, m, s);
            

            //23uzduotis

            Console.WriteLine("Iveskite metus");
            int metai = Convert.ToInt32(Console.ReadLine());

            if (metai >= 1896 && metai % 4 == 0)
            {
                int numeris = (metai - 1896) / 4 + 1;
                Console.WriteLine("Metai yra olimpiniai, ju numeris {0}", numeris);

            } else
            {
                Console.WriteLine("Metai nera olimpiniai");
            }
            

            //24uzudotis 

            Console.WriteLine("Iveskite keturzenkli skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());

            int sk1 = sk / 1000;
            int sk2 = (sk % 1000) / 100;
            int sk3 = (sk % 100) / 10;
            int sk4 = sk % 10;

            int reiks = 0;

            if (sk1 != 0)
            {
                reiks++;
            }
            if (sk2 != 0)
            {
                reiks++;
            }
            if (sk3 != 0)
            {
                reiks++;
            }
            if (sk4 != 0)
            {
                reiks++;
            }

            int nereiks = 4 - reiks;
            Console.WriteLine("Reiksmingu skaiciu {0}, nereiksmingu {1}", reiks, nereiks);
            
            //25uzduotis

            Console.WriteLine("Iveskite tris ugius");
            int U1 = Convert.ToInt32(Console.ReadLine());
            int U2 = Convert.ToInt32(Console.ReadLine());
            int U3 = Convert.ToInt32(Console.ReadLine());


            if (U1 > U2 && U1 > U3)
            {
                Console.WriteLine("Auksciausias yra U1");
            }
            if (U2 > U1 && U2 > U3)
            {
                Console.WriteLine("Auksciausias yra U2");
            }
            if (U3 > U1 && U3 > U2)
            {
                Console.WriteLine("Auksciausias yra U3");
            }
            if (U1 == U2 && U1 > U3)
            {
                Console.WriteLine("Auksciausias yra U1 ir U2");
            }
            if (U2 == U3 && U2 > U1)
            {
                Console.WriteLine("Auksciausias yra U2 ir U3");
            }
            if (U3 == U1 && U3 > U2)
            {
                Console.WriteLine("Auksciausias yra U3 ir U1");
            }
            if (U1 == U2 && U2 == U3)
            {
                Console.WriteLine("Auksciausias yra U3 ir U1 ir U2");
            }`
            
            //26uzduotis

            Console.WriteLine("Iveskite valandas, kada Petras isejo is namu");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite minutes, kada Petras isejo is namu");
            int min1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite  kiek minuciu Petras ejo iki mokyklos");
            int min2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite, kad prasideda pamokos valandomis");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite, kad prasideda pamokos minutemis");
            int min = Convert.ToInt32(Console.ReadLine());


            int bendra_trume_minutemis = (val - val1) * 60;
            int bendras_min = min - min1;

            int bendra_trume_minutemis1 = bendra_trume_minutemis + bendras_min;

            if(min2 > bendra_trume_minutemis1)
            {
                Console.WriteLine("Petras i mokykla nespes");
            }
            if (min2 < bendra_trume_minutemis1)
            {
                Console.WriteLine("Petras i mokykla spes");
            }
            
            //27uzduotis

            Console.WriteLine("Iveskite penkiazenki naturalu skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());

            int sk1 = sk / 10000;
            int sk2 = (sk % 10000) / 1000;
            int sk3 = (sk % 1000) / 100;
            int sk4 = (sk % 100) / 10;
            int sk5 = sk % 10;


            if (sk1 == sk5 && sk2 == sk4)
            {
                Console.Write("Skaicius yra polindromas");
            } else
            {
                Console.Write("Skaicius nera polindromas");
            }
            
            //33uzduoti

            int kiekis = 0;


            for (int i = 10;  i < 100; i++)
            {
                int i1 = i / 10;
                int i2 = i % 10;

                if (i1 == 2)
                {
                    kiekis++;
                }
                if (i2==2)
                {
                    kiekis++;
                }
            }
            Console.WriteLine("Is viso dvejetu yra {0}", kiekis);
            

            //35uzduoti


            double suma_turtuolio = 0;
            int suma_matematiko = 0;

            for (int i = 1; i < 31; i++)

            {
                suma_turtuolio = suma_turtuolio + 0.02 * Math.Pow(2, i - 1);
            }
            Console.WriteLine("Turtuolis matemakui sumokes {0}", suma_turtuolio);

            for (int i = 1; i < 31; i++)
            {
                suma_matematiko = suma_matematiko + 1000000;
            }
            Console.WriteLine("Matematikas turtuoliui sumokes {0}", suma_matematiko);

            

            //37uzduotis 

            Console.WriteLine("Iveskite naturalu skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            int sk = 1;

            while (suma < n)
            {
                suma += sk;
                sk++;
            }
            if (suma == n)
            {
                for (int i = 1; i < sk; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Sekos nera");
            }

            */
        }
    }
}
