using System;

namespace Freq
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            double Freqkhz, FreqHz, FreqMHz, FreqGHz, Peris, Perims, Perimus, Perins;
            Console.WriteLine("\t**************************************");
            Console.WriteLine("\t*    Berechnung von f und i          *");
            Console.WriteLine("\t**************************************");
            Console.WriteLine("");
            Console.Write("\tGeben sie die Frequenz in kHz ein:  ");
            eingabe = Console.ReadLine();
            Freqkhz = Convert.ToDouble(eingabe);

            FreqHz = Freqkhz * 1000;
            FreqMHz = Freqkhz / 1000;
            FreqGHz = Freqkhz / 1000000;

            Peris = 1 / FreqHz;
            Perims = Peris * 1000;
            Perimus = Perims * 1000;
            Perins = Perimus * 1000;
            Console.WriteLine("");
            Console.WriteLine("\tFrequenz in Hz                 {0,20:F3}      Hz", FreqHz);
            Console.WriteLine("\tFrequenz in kHz                {0,20:F3}        KHz", Freqkhz);
            Console.WriteLine("\tFrequenz in MHz                {0,20:F5}         MHz", FreqMHz);
            Console.WriteLine("\tFrequenz in GHz                {0,20:F5}         GHz", FreqGHz);
            Console.WriteLine("\tPeriodendauer in s             {0,20:F6}          s", Peris);
            Console.WriteLine("\tPeriodendauer in ms            {0,20:F6}         ms", Perims);
            Console.WriteLine("\tPeriodendauer in µs            {0,20:F3}           µs", Perimus);
            Console.WriteLine("\tPeriodendauer in ns            {0,20:F3}          ns", Perins);
            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            double Zinsen;
            double Endkapital;
            int Jahre;

            double Anfangskapital;
            int Prozentsatz;

            double TempPSatz;
            double ErgPSatz;

            Console.WriteLine("Geben Sie das Startkapital ein.");
            Anfangskapital = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie den Zinssatz ein.");
            Prozentsatz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die Jahre ein.");
            Jahre = Convert.ToInt32(Console.ReadLine());

            TempPSatz = 1 + ((double)Prozentsatz / 100);
            ErgPSatz = Math.Pow(TempPSatz, Jahre);

            Endkapital = Anfangskapital * ErgPSatz;
            Zinsen = Endkapital - Anfangskapital;

            Console.WriteLine("Das Startkapital war: {0}", Anfangskapital);
            Console.WriteLine("Das Endkapital ist: {0:0.###}", Endkapital);
            Console.WriteLine("Die angereiften Zinsen sind: {0:0.###}", Zinsen);


            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            int num;
            int erg;
            int.TryParse(Console.ReadLine(), out num);

            if(num.ToString().Length == 5)
            {
                erg = num / 10000 + (num % 10000) / 1000 + ((num % 10000) % 1000) / 100 + (((num % 10000) % 1000) % 100) / 10 + ((((num % 10000) % 1000) % 100) % 10);

                Console.WriteLine("Die Quersumme von {0} ist {1}", num, erg);
                Console.WriteLine("{0} / {1} = {2}", num, erg, (float)num / erg);
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        static void Main4(string[] args) //Aufgabe1
        {
            string eingabe;

            Console.Write("Geben sie die Ampere ein  ");
            eingabe = Console.ReadLine();

            if (eingabe == "0")
            {
                Console.WriteLine("Amepere cannot be null");
            }
            else
            {

            }
        }

        static void Main5(string[] args) //Aufgabe2
        {
            double NettoAutragsvolumen = 0;
            int Rabatt = 0;

            if(NettoAutragsvolumen < 10000)
            {
                Rabatt = 5;
                Console.WriteLine("Du bekommst: " + Rabatt + "% Rabatt");
            }
            else
            {
                Console.WriteLine("Du bekommst keinen Rabatt");
            }
        }

        static void Main6(string[] args) //Aufgabe3
        {
            double NettoAutragsvolumen = 0;
            int Rabatt = 0;

            if (NettoAutragsvolumen > 4999.99)
            {
                if(NettoAutragsvolumen > 5000)
                {
                    Rabatt = 3;
                    Console.WriteLine("Du bekommst: " + Rabatt + "% Rabatt");
                }
                if(NettoAutragsvolumen > 10000)
                {
                    Rabatt = 5;
                    Console.WriteLine("Du bekommst: " + Rabatt + "% Rabatt");
                }
            }
            else
            {
                Console.WriteLine("Du bekommst keinen Rabatt");
            }
        }

        static void auto(string[] args)
        {
            string eingabe;
            double altKm, neueKm, Liter, verbrauch, gefahreneKm;

            Console.Clear();

            Console.WriteLine("\n\t Mit diesem Programm wird der durchschnittliche");
            Console.WriteLine("\t Benzinverbrauch auf 100km berechnet. \n");

            Console.Write("\t Kilometerstand beim vorletzten tanken?");
            eingabe = Console.ReadLine();
            altKm = Convert.ToDouble(eingabe);

            if (altKm < 0)
            {
                Console.WriteLine("Ungültige eingabe!");
            }

            Console.Write("\t Kilometerstand beim letzten tanken?");
            eingabe = Console.ReadLine();
            neueKm = Convert.ToDouble(eingabe);

            if (neueKm < 0 || neueKm < altKm)
            {
                Console.WriteLine("Ungültige eingabe!");
            }
            else
            {
                Console.Write("\t Wie viele Liter haben sie getankt?");
                eingabe = Console.ReadLine();
                Liter = Convert.ToDouble(eingabe);

                gefahreneKm = neueKm - altKm;
                verbrauch = Liter / gefahreneKm * 100;

                Console.Write("\n\n\t Der Benzinverbrauch auf 100 km betrug:");
                Console.Write("{0:0.00}", verbrauch);
                Console.Write(" Liter.\n");
                Console.Read();
            }
        }
    }
}
