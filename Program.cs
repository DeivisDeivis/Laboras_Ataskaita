//// Sukurkite klasę Duona, kuri turėtų kintamuosius duonos miltų pavadinimui, kepaliuko svoriui ir 
//kainai saugoti. Kepykla kepa duoną iš 3 skirtingų rūšių miltų. Raskite, kuri kepama duona 
//mažiausiai sveria ir kurios duonos kaina didžiausia.
//Papildykite klasę Duona kintamuoju, skirtu duonos kepaliuko užimamam ant lentynos plotui saugoti. 
//Sukurkite klasę Kepykla, kuri turėtų kintamąjį kepyklos pavadinimui saugoti ir 3 kintamuosius 
//(kiekvienai duonos miltų rūšiai), skirtus saugoti per pamainą reikalingam iškepti duonos kepaliukų 
//kiekiui. Suskaičiuokite, kiek ploto lentynų kiekvienos rūšies duonai sudėti reikės.
//Papildykite klasę Kepykla kintamuoju, kuriame būtų saugoma informacija apie tai, kiek kg duonos 
//kepyklos automobilis gali vežti. Kiek kartų reikės važiuoti kepyklos automobiliui, kad išvežti į 
//parduotuves visą per pamainą iškeptą duoną?
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laboras_u223
{
    class Duona
    {
        private string pavadinimas;
        private double svoris;
        private double kaina;
        private double plotas;

        public Duona(string pavadinimas, double svoris, double kaina, double plotas)
        {
            this.pavadinimas = pavadinimas;
            this.svoris = svoris;
            this.kaina = kaina;
            this.plotas = plotas;

        }
        public string Getvardas() { return pavadinimas; } // Gražina duonos tipo pavadinimą 
        public double GetSvoris() { return svoris; } // Gražina duonos svorį
        public double Getkaina() { return kaina; } // Gražina duonos kainą

        public double Getplotas() { return plotas; } // Gražina duonos užimama plotą


    }

    class Kepykla
    {
        string kepyklospav;
        int kiek1rusies;
        int kiek2rusies;
        int kiek3rusies;
        int kiekduonos;

        public Kepykla(string kepyklospav, int kiek1rusies, int kiek2rusies, int kiek3rusies, int kiekduonos)
        {
            this.kepyklospav = kepyklospav;
            this.kiek1rusies = kiek1rusies;
            this.kiek2rusies = kiek2rusies;
            this.kiek3rusies = kiek3rusies;
            this.kiekduonos = kiekduonos;

        }

        public string Getkepyklospav() { return kepyklospav; } // Gražina kepyklos pavadinimą
        public int Getrusis1() { return kiek1rusies; } // Gražina 1 rūšies duonų skaičių
        public int Getrusis2() { return kiek2rusies; } // Gražina 2 rūšies duonų skaičių
        public int Getrusis3() { return kiek3rusies; } // Gražina 3 rūšies duonų skaičių
                                // Gražina kiek duonos daugiausia gali automobilis atvežti
        public int Getkiekduonos() { return kiekduonos; } 
    }

    class Program
    {
        static void Main()
        {               // pavadinimas, svoris, kaina, plotas
            Duona bread1 = new Duona("Kvietine Duona", 300, 4.99, 0.2);// bread1, bread2, bread3, Duonos klasės Objektai
            Duona bread2 = new Duona("Balta duona", 500, 6.99, 0.3);
            Duona bread3 = new Duona("Rugine Duona", 600, 4.49, 0.4);
            Kepykla kepykla1 = new Kepykla("Kepykla1", 70, 80, 90, 100);// kepykla1 Kepykla klasės Objektas
            // pavadinimas, kiekis 1 rūšies, kiekis 2 rūšies, kiekis 3 rūšies, kiek kg duonos automobilis gali vežti
            string L_Dpavadinimas = RastiLengviausiaDuona(bread1, bread2, bread3);
            double plotas1 = RastiKiekPlotoUzima1(bread1, kepykla1);
            double plotas2 = RastiKiekPlotoUzima2(bread2, kepykla1);
            double plotas3= RastiKiekPlotoUzima3(bread3, kepykla1);
            string B_Dpavadinimas = RastiBrangiausiaDuona(bread1, bread2, bread3);
            Console.WriteLine("Lengviausia Duona :");
            Console.WriteLine(L_Dpavadinimas);
            Console.WriteLine("Brangiausia Duona : ");
            Console.WriteLine(B_Dpavadinimas);
            Console.WriteLine("Lentynos uzimamas plotas 1 rūšies duonų  : ");
            Console.WriteLine(plotas1 + "m2");
            Console.WriteLine("Lentynos uzimamas plotas 2 rūšies duonų  : ");
            Console.WriteLine(plotas2 + "m2");
            Console.WriteLine("Lentynos uzimamas plotas 3 rūšies duonų  : ");
            Console.WriteLine(plotas3 + "m2");
            double kiekvaziuot = RastiKiekVaziuot(bread1, bread2, bread3, kepykla1);
            Console.WriteLine("Kiek kartu reiks vaziuot :");
            Console.WriteLine(kiekvaziuot);
        }
                   // Randa Lengviausios duonos pavadinimą 
        public static string RastiLengviausiaDuona(Duona bread1, Duona bread2, Duona bread3)
        {

            string L_Dpavadinimas = bread1.Getvardas();

            if (bread2.GetSvoris() < bread1.GetSvoris())
            {
                L_Dpavadinimas = bread2.Getvardas();

            }

            else if (bread3.GetSvoris() < bread2.GetSvoris())
            {
                L_Dpavadinimas = bread3.Getvardas(); // L_D pavadinimas - lengviausios duonos pavadinimas

            }
            else L_Dpavadinimas = bread1.Getvardas();
            return L_Dpavadinimas;

        }
                        // Randa brangiausios Duonos pavadinimą
        public static string RastiBrangiausiaDuona(Duona bread1, Duona bread2, Duona bread3)
        {
            double brangiausiaduona = bread1.Getkaina();
            string B_Dpavadinimas = bread1.Getvardas(); // B_Dpavadinimas - brangiausios duonos pavadinimas

            if (bread2.Getkaina() > bread1.Getkaina())
            {
                B_Dpavadinimas = bread2.Getvardas();
            }

            else if (bread3.Getkaina() > bread1.Getkaina())
            {
                B_Dpavadinimas = bread3.Getvardas();

            }

            else B_Dpavadinimas = bread1.Getvardas();
            return B_Dpavadinimas;
        }
                            // Apskaiciuoja 1 rūšies duonų užimama plotą
        public static double RastiKiekPlotoUzima1(Duona bread1, Kepykla kepykla1)
        {
            double plotas;
            plotas = bread1.Getplotas() * kepykla1.Getrusis1();
           
            return plotas;
        }                   // Apskaiciuoja 2 rūšies duonų užimama plotą
        public static double RastiKiekPlotoUzima2(Duona bread2,  Kepykla kepykla1)
        {
            double plotas;
            plotas = bread2.Getplotas() * kepykla1.Getrusis2();
            return plotas;

        }                   // Apskaiciuoja 3 rūšies duonų užimama plotą
        public static double RastiKiekPlotoUzima3( Duona bread3, Kepykla kepykla1)
        {
            double plotas;
            plotas = bread3.Getplotas() * kepykla1.Getrusis3();
            return plotas;


        }
        // Randa kiek kartų reikės važiuoti
        public static double RastiKiekVaziuot(Duona bread1, Duona bread2, Duona bread3, Kepykla kepykla1)
        {
            double kiekvaziuot;
            double kiekvaziuot1;
            double kiekkgisviso = ((bread1.GetSvoris() / 1000) * kepykla1.Getrusis1()) + ((bread2.GetSvoris() / 1000) * kepykla1.Getrusis2()) + ((bread3.GetSvoris() / 1000) * kepykla1.Getrusis3());
            kiekvaziuot = kiekkgisviso / kepykla1.Getkiekduonos();


            double liekana = kiekvaziuot % 1;

            if (liekana > 0)
            {
                double suapvalintas = Math.Ceiling(kiekvaziuot);
                kiekvaziuot1 = suapvalintas;
            }

            else {

                kiekvaziuot1 = kiekvaziuot;
            }

            return kiekvaziuot1;
        }
    }
}
