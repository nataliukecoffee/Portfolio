using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrekeStruct;

namespace Strukturos_klaseje_Nr._4
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Preke> prekiuSarasas = new List<Preke>();
            PradinesPrekiuReiksmes(prekiuSarasas);

            bool iseiti = false;

            while (iseiti != true)
            {
                Console.WriteLine("Ka norite atlikti: [1] - prideti preke; [2] - parodyti visa sarasa, [3] - istrinti preke, [4] - koreguoti kieki");
                int veiksmas = int.Parse(Console.ReadLine());

                if (veiksmas == 1)
                {
                    PridetiNaujaPreke(prekiuSarasas);
                }

                else if (veiksmas == 2)
                {
                    ParodytiKainaViso(prekiuSarasas);
                    Console.ReadLine();
                }

                else if (veiksmas == 3)
                {
                    IstrintiPreke(prekiuSarasas);
                }
                else if (veiksmas == 4)
                {
                    PrekesKiekioKoregavimas(prekiuSarasas);
                }

                else
                {
                    NetinkamasVartotojoVeiksmas();
                }

                Console.WriteLine("[1] - Testi darba?, [2] - Iseiti");
                veiksmas = Convert.ToInt16(Console.ReadLine());
                if (veiksmas == 2)
                {
                    iseiti = true;
                }
                else if (veiksmas != 2 && veiksmas != 1)
                {
                    NetinkamasVartotojoVeiksmas();
                }
            }
        }

        private static void PradinesPrekiuReiksmes(List<Preke> prekiuSarasas)
        {
            prekiuSarasas.Add(new Preke("Sofa", 1, 5000));
            prekiuSarasas.Add(new Preke("Stalas", 1, 2000));
            prekiuSarasas.Add(new Preke("Kede", 1, 10000));
        }

        private static void PrekesKiekioKoregavimas(List<Preke> prekiuSarasas)
        {
            Console.WriteLine("Iveskite prekes, kuria norite koreguoti, numeri");
            int kuriElementaKoreguoti = Convert.ToInt16(Console.ReadLine());

            if (ArElementasEgzistuoja(prekiuSarasas, kuriElementaKoreguoti))
            {
                PranesimasKadPrekeNeegzistuoja();

            }
            else
            {

                Console.WriteLine(prekiuSarasas[kuriElementaKoreguoti - 1].Pavadinimas + " " + prekiuSarasas[kuriElementaKoreguoti - 1].Kiekis + " " + prekiuSarasas[kuriElementaKoreguoti - 1].KainaVieneto);
                Console.ReadLine();

                Console.WriteLine("Iveskite nauja koreguojamos prekes kieki");
                int naujasKiekis = Convert.ToInt16(Console.ReadLine());

                Preke tarpinePreke = new Preke(prekiuSarasas[kuriElementaKoreguoti - 1].Pavadinimas, naujasKiekis, prekiuSarasas[kuriElementaKoreguoti - 1].KainaVieneto);
                prekiuSarasas[kuriElementaKoreguoti - 1] = tarpinePreke;

                ParodytiKainaViso(prekiuSarasas);
                Console.ReadLine();
            }
        }

        private static void PranesimasKadPrekeNeegzistuoja()
        {
            Console.WriteLine("Tokia preke neegzistuoja");
            Console.ReadLine();
        }

        private static bool ArElementasEgzistuoja(List<Preke> prekiuSarasas, int numeris)
        {
            return (numeris < 0 && numeris > prekiuSarasas.Count);
        }
        private static void IstrintiPreke(List<Preke> prekiuSarasas)
        {
            Console.WriteLine("Iveskite prekes numeri, kuria norite istrinti.");
            int kuriElementaTrinti = Convert.ToInt16(Console.ReadLine());

            if (ArElementasEgzistuoja(prekiuSarasas, kuriElementaTrinti))
            {
                PranesimasKadPrekeNeegzistuoja();

            }

            else
            {
                prekiuSarasas.RemoveAt(kuriElementaTrinti - 1);
                ParodytiKainaViso(prekiuSarasas);
                Console.ReadLine();


            }
        }

        private static void PridetiNaujaPreke(List<Preke> prekiuSarasas)
        {
            Console.WriteLine("Iveskite prekes pavadinima");
            string pavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite prekes kieki");
            decimal kiekis = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Iveskite prekes kaina");
            decimal kaina = Convert.ToInt16(Console.ReadLine());
            prekiuSarasas.Add(new Preke(pavadinimas, kiekis, kaina));

            ParodytiKainaViso(prekiuSarasas);
            Console.ReadLine();
        }

        private static void NetinkamasVartotojoVeiksmas()
        {
            Console.WriteLine("Nezinomas veiksmas, paspauskite [ENTER], kad uzdarytumete langa");
            Console.ReadLine();
            Environment.Exit(0);
        }

        private static void ParodytiKainaViso(List<Preke> prekiuSarasas)
        {
            decimal kainaViso = 0;

            for (int i = 0; i < prekiuSarasas.Count; i++)
            {
                Console.WriteLine("Pavadinimas: {0}, Kiekis: {1}, Kaina: {2}.", prekiuSarasas[i].Pavadinimas, prekiuSarasas[i].Kiekis, prekiuSarasas[i].KainaVieneto);
                kainaViso += prekiuSarasas[i].KainaViso;
            }
            Console.WriteLine("Kaina Is Viso: {0}", kainaViso);
        }

    }
}
