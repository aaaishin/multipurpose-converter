using System.Threading.Tasks;
internal class Program {
    public static void Print(string text, int speed = 20)
    {

        foreach (char c in text)
        {

            Console.Write(c);
            System.Threading.Thread.Sleep(speed);
        }

        Console.WriteLine(" ");
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("------------------------------------------------------------");
        Program.Print("\tMULTIPURPOSE CONVERTER");
        Console.WriteLine("------------------------------------------------------------");

        Program.Print("\t[1] Currency");
        Program.Print("\t[2] Temperature");
        Program.Print("\t[3] Time");
        Console.WriteLine("------------------------------------------------------------");

        int Converter;

        Console.Write("Choose a Converter: ");
        Converter = int.Parse(Console.ReadLine());

        Console.Clear();

        switch (Converter)
        {
            case 1:
                int value;
                double num, phUsd, phSG, phJP, phEU;

                Console.WriteLine("------------------------------------------------------------");
                Program.Print("\tCurrency Conversion");
                Program.Print("\t[PH Peso - US Dollar - SG Dollar - Euro - JP Yen]");

                Console.WriteLine("------------------------------------------------------------");
                Program.Print("\tWhat kind of currency you want to convert? \n");
                Program.Print("\t[1] PH Peso to US Dollar");
                Program.Print("\t[2] PH Peso to SG Dollar");
                Console.WriteLine("\t[3] PH Peso to Euro");
                Program.Print("\t[4] PH Peso to JP Yen");
                Console.WriteLine("------------------------------------------------------------");

                Console.WriteLine(" ");
                Console.Write("\tNumber: ");
                value = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("------------------------------------------------------------");

                if (value == 1)
                {
                    Program.Print("\tConverting PH Peso to US Dollar...");
                    Console.Write("\tCurrency Number: ");
                    num = double.Parse(Console.ReadLine());
                    phUsd = num * 0.018;
                    Program.Print("\tConverted Currency (PHP to USD): " + phUsd);
                }
                else if (value == 2)
                {
                    Program.Print("\tPH Peso to SG Dollar...");
                    Console.Write("\tCurrency Number: ");
                    num = double.Parse(Console.ReadLine());
                    phSG = num * 0.024;
                    Program.Print("\tConverted Currency (PHP to SGD): " + phSG);
                }
                else if (value == 3)
                {
                    Program.Print("\tPH Peso to Euro...");
                    Console.Write("\tCurrency Number: ");
                    num = double.Parse(Console.ReadLine());
                    phEU = num * 0.017;
                    Program.Print("\tConverted Currency (PHP to EU): " + phEU);
                }
                else if (value == 4)
                {
                    Program.Print("\tPH Peso to JP Yen...");
                    Console.Write("\tCurrency Number: ");
                    num = double.Parse(Console.ReadLine());
                    phJP = num * 2.46;
                    Program.Print("\tConverted Currency (PHP to JPY): " + phJP);
                }
                else
                {
                    Program.Print("\tInvalid!");
                }

                Console.WriteLine("------------------------------------------------------------");
                break;

            case 2:
                int k;
                double val, cf, kf, fc, ck, kc, fk;

                Console.WriteLine("------------------------------------------------------------");
                Program.Print("\tTemperature Conversion");
                Program.Print("\t[Celsius - Fahrenheit - Kelvin]");

                Console.WriteLine("------------------------------------------------------------");
                Program.Print("\tWhat kind of temperature you want to convert? \n");
                Program.Print("\t[1] Celsius to Fahrenheit");
                Program.Print("\t[2] Kelvin to Fahrenheit");
                Program.Print("\t[3] Fahrenheit to Celsius");
                Program.Print("\t[4] Celsius to Kelvin");
                Program.Print("\t[5] Kelvin to Celsius");
                Program.Print("\t[6] Fahrenheit to Kelvin");
                Console.WriteLine("------------------------------------------------------------");

                Console.WriteLine(" ");
                Console.Write("\tNumber: ");
                k = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("------------------------------------------------------------");

                if (k == 1)
                {
                    Program.Print("\tConverting Celsius to Fahrenheit...");
                    Console.Write("\tTemperature Number: ");
                    val = int.Parse(Console.ReadLine());
                    cf = (val * 9 / 5) + 32;
                    Program.Print("\tConverted Temperature (Fahrenheit): " + cf);
                }
                else if (k == 2)
                {
                    Program.Print("\tConverting Kelvin to Fahrenheit...");
                    Console.Write("\tTemperature Number: ");
                    val = int.Parse(Console.ReadLine());
                    kf = (val - 273.15) * 9 / 5 + 32;
                    Program.Print("\tConverted Temperature (Fahrenheit): " + kf);
                }
                else if (k == 3)
                {
                    Program.Print("\tConverting Fahrenheit to Celsius...");
                    Console.Write("\tTemperature Number: ");
                    val = int.Parse(Console.ReadLine());
                    fc = (val - 32) * 5 / 9;
                    Program.Print("\tConverted Temperature (Celsius): " + fc);
                }
                else if (k == 4)
                {
                    Program.Print("\tConverting Celsius to Kelvin...");
                    Console.Write("\tTemperature Number: ");
                    val = int.Parse(Console.ReadLine());
                    ck = val + 273.15;
                    Program.Print("\tConverted Temperature (Kelvin): " + ck);
                }
                else if (k == 5)
                {
                    Program.Print("\tConverting Kelvin to Celsius...");
                    Console.Write("\tTemperature Number: ");
                    val = int.Parse(Console.ReadLine());
                    kc = val - 273.15;
                    Program.Print("\tConverted Temperature (Celsius): " + kc);
                }
                else if (k == 6)
                {
                    Program.Print("\tConverting Fahrenheit to Kelvin...");
                    Console.Write("\tTemperature Number: ");
                    val = int.Parse(Console.ReadLine());
                    fk = (val - 32) * 5 / 9 + 273.15;
                    Program.Print("\tConverted Temperature (Kelvin): " + fk);
                }
                else
                {
                    Program.Print("\tInvalid!");
                }

                Console.WriteLine("------------------------------------------------------------");
                break;

            case 3:
                int n;
                double sm, sh, sd, ms, mh, md, hs, hm, hd, ds, dm, dh;

                Console.WriteLine("\n************************************************************");
                Program.Print("\tTime Conversion");
                Program.Print("\t[Second - Minute - Hour - Day]");

                Console.WriteLine("\n************************************************************");
                Program.Print("\tWhat kind of time you want to convert? \n");
                Program.Print("\t[1] Second to Minute");
                Program.Print("\t[2] Second to Hour");
                Program.Print("\t[3] Second to Day");
                Program.Print("\t[4] Minute to Second");
                Program.Print("\t[5] Minute to Hour");
                Program.Print("\t[6] Minute to Day");
                Program.Print("\t[7] Hour   to Second");
                Program.Print("\t[8] Hour   to Minute");
                Program.Print("\t[9] Hour   to Day");
                Program.Print("\t[10] Day   to Second");
                Program.Print("\t[11] Day   to Minute");
                Program.Print("\t[12] Day   to Hour");
                Console.WriteLine("------------------------------------------------------------");

                Console.WriteLine(" ");
                Console.Write("\tNumber: ");
                n = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("------------------------------------------------------------");

                if (n == 1)
                {
                    Program.Print("\tConverting Second to Minute...");
                    Console.Write("\tSecond : ");
                    num = int.Parse(Console.ReadLine());
                    sm = (num / 60);
                    Program.Print("\tMinute : " + sm);
                }
                else if (n == 2)
                {
                    Program.Print("\tConverting Second to Hour...");
                    Console.Write("\tSecond : ");
                    num = int.Parse(Console.ReadLine());
                    sh = (num / 3600);
                    Program.Print("\tHour : " + sh);
                }
                else if (n == 3)
                {
                    Program.Print("\tConverting Second to Day...");
                    Console.Write("\tSecond : ");
                    num = int.Parse(Console.ReadLine());
                    sd = (num / 86400);
                    Program.Print("\tDay : " + sd);
                }
                else if (n == 4)
                {
                    Program.Print("\tConverting Minute to Second...");
                    Console.Write("\tMinute : ");
                    num = int.Parse(Console.ReadLine());
                    ms = (num * 60);
                    Program.Print("\tSecond : " + ms);
                }
                else if (n == 5)
                {
                    Program.Print("\tConverting Minute to Hour...");
                    Console.Write("\tMinute : ");
                    num = int.Parse(Console.ReadLine());
                    mh = (num / 60);
                    Program.Print("\tHour : " + mh);
                }
                else if (n == 6)
                {
                    Program.Print("\tConverting Minute to Day...");
                    Console.Write("\tMinute : ");
                    num = int.Parse(Console.ReadLine());
                    md = (num / 1440);
                    Program.Print("\tDay : " + md);
                }
                else if (n == 7)
                {
                    Program.Print("\tConverting Hour to Second...");
                    Console.Write("\tHour : ");
                    num = int.Parse(Console.ReadLine());
                    hs = (num * 3600);
                    Program.Print("\tSecond : " + hs);
                }
                else if (n == 8)
                {
                    Program.Print("\tConverting Hour to Minute...");
                    Console.Write("\tHour : ");
                    num = int.Parse(Console.ReadLine());
                    hm = (num * 60);
                    Program.Print("\tMinute : " + hm);
                }
                else if (n == 9)
                {
                    Program.Print("\tConverting Hour to Day...");
                    Console.Write("\tHour : ");
                    num = int.Parse(Console.ReadLine());
                    hd = (num / 24);
                    Program.Print("\tDay : " + hd);
                }
                else if (n == 10)
                {
                    Program.Print("\tConverting Day to Second...");
                    Console.Write("\tDay : ");
                    num = int.Parse(Console.ReadLine());
                    ds = (num * 86400);
                    Program.Print("\tSecond : " + ds);
                }
                else if (n == 11)
                {
                    Program.Print("\tConverting Day to Minute...");
                    Console.Write("\tDay : ");
                    num = int.Parse(Console.ReadLine());
                    dm = (num * 1440);
                    Program.Print("\tMinute : " + dm);
                }
                else if (n == 12)
                {
                    Program.Print("\tConverting Day to Hour...");
                    Console.Write("\tDay : ");
                    num = int.Parse(Console.ReadLine());
                    dh = (num * 24);
                    Program.Print("\tHour : " + dh);
                }
                else
                {
                    Program.Print("\tInvalid!");
                }

                Console.WriteLine("------------------------------------------------------------");
                break;

            default:
                Program.Print("\t\t INVALID!");
                break;



        }

    }
}