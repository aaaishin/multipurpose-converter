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
        try
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Program.Print("\tMULTIPURPOSE CONVERTER");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Program.Print("\t[1] Currency");
            Program.Print("\t[2] Temperature");
            Program.Print("\t[3] Time");
            Console.ResetColor();

            Console.WriteLine("------------------------------------------------------------");


            int Converter;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Choose a Converter: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Converter = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.Clear();

            switch (Converter)
            {
                case 1:
                    int value;
                    double num, phUsd, phSG, phJP, phEU;

                    Console.WriteLine("------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program.Print("\tCurrency Conversion");
                    Program.Print("\t[PH Peso - US Dollar - SG Dollar - Euro - JP Yen]");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program.Print("\tWhat kind of currency you want to convert? \n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Program.Print("\t[1] PH Peso to US Dollar");
                    Program.Print("\t[2] PH Peso to SG Dollar");
                    Console.WriteLine("\t[3] PH Peso to Euro");
                    Program.Print("\t[4] PH Peso to JP Yen");
                    Console.ResetColor();

                    Console.WriteLine("------------------------------------------------------------");

                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\tNumber: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    value = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Clear();

                    Console.WriteLine("------------------------------------------------------------");

                    if (value == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting PH Peso to US Dollar...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tCurrency Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = double.Parse(Console.ReadLine());
                        Console.ResetColor();
                        phUsd = num * 0.018;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Currency (PHP to USD): " + phUsd);
                        Console.ResetColor();
                    }
                    else if (value == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting PH Peso to SG Dollar...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tCurrency Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = double.Parse(Console.ReadLine());
                        Console.ResetColor();
                        phSG = num * 0.024;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Currency (PHP to SGD): " + phSG);
                        Console.ResetColor();
                    }
                    else if (value == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting PH Peso to Euro...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tCurrency Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = double.Parse(Console.ReadLine());
                        Console.ResetColor();
                        phEU = num * 0.017;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Currency (PHP to EU): " + phEU);
                        Console.ResetColor();
                    }
                    else if (value == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting PH Peso to JP Yen...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tCurrency Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = double.Parse(Console.ReadLine());
                        Console.ResetColor();
                        phJP = num * 2.46;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Currency (PHP to JPY): " + phJP);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Program.Print("\t\t\t INVALID!");
                        Console.ResetColor();
                    }

                    Console.WriteLine("------------------------------------------------------------");
                    break;

                case 2:
                    int k;
                    double val, cf, kf, fc, ck, kc, fk;

                    Console.WriteLine("------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program.Print("\tTemperature Conversion");
                    Program.Print("\t[Celsius - Fahrenheit - Kelvin]");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program.Print("\tWhat kind of temperature you want to convert? \n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Program.Print("\t[1] Celsius to Fahrenheit");
                    Program.Print("\t[2] Kelvin to Fahrenheit");
                    Program.Print("\t[3] Fahrenheit to Celsius");
                    Program.Print("\t[4] Celsius to Kelvin");
                    Program.Print("\t[5] Kelvin to Celsius");
                    Program.Print("\t[6] Fahrenheit to Kelvin");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------------");

                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\tNumber: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    k = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Clear();

                    Console.WriteLine("------------------------------------------------------------");

                    if (k == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Celsius to Fahrenheit...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tTemperature Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        val = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        cf = (val * 9 / 5) + 32;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Temperature (Fahrenheit): " + cf);
                        Console.ResetColor();
                    }
                    else if (k == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Kelvin to Fahrenheit...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tTemperature Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        val = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        kf = (val - 273.15) * 9 / 5 + 32;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Temperature (Fahrenheit): " + kf);
                        Console.ResetColor();
                    }
                    else if (k == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Fahrenheit to Celsius...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tTemperature Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        val = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        fc = (val - 32) * 5 / 9;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Temperature (Celsius): " + fc);
                        Console.ResetColor();
                    }
                    else if (k == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Celsius to Kelvin...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tTemperature Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        val = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        ck = val + 273.15;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Temperature (Kelvin): " + ck);
                        Console.ResetColor();
                    }
                    else if (k == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Kelvin to Celsius...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tTemperature Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        val = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        kc = val - 273.15;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Temperature (Celsius): " + kc);
                        Console.ResetColor();
                    }
                    else if (k == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Fahrenheit to Kelvin...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tTemperature Number: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        val = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        fk = (val - 32) * 5 / 9 + 273.15;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tConverted Temperature (Kelvin): " + fk);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Program.Print("\t\t\t INVALID!");
                        Console.ResetColor();
                    }

                    Console.WriteLine("------------------------------------------------------------");
                    break;

                case 3:
                    int n;
                    double sm, sh, sd, ms, mh, md, hs, hm, hd, ds, dm, dh;

                    Console.WriteLine("\n************************************************************");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program.Print("\tTime Conversion");
                    Program.Print("\t[Second - Minute - Hour - Day]");
                    Console.ResetColor();
                    Console.WriteLine("\n************************************************************");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program.Print("\tWhat kind of time you want to convert? \n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
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
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------------");

                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\tNumber: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    n = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------");

                    if (n == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Second to Minute...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tSecond : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        sm = (num / 60);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tMinute : " + sm);
                        Console.ResetColor();
                    }
                    else if (n == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Second to Hour...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tSecond : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        sh = (num / 3600);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tHour : " + sh);
                        Console.ResetColor();
                    }
                    else if (n == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Second to Day...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tSecond : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        sd = (num / 86400);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tDay : " + sd);
                        Console.ResetColor();
                    }
                    else if (n == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Minute to Second...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tMinute : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        ms = (num * 60);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tSecond : " + ms);
                        Console.ResetColor();
                    }
                    else if (n == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Minute to Hour...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tMinute : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        mh = (num / 60);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tHour : " + mh);
                        Console.ResetColor();
                    }
                    else if (n == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Minute to Day...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tMinute : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        md = (num / 1440);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tDay : " + md);
                        Console.ResetColor();
                    }
                    else if (n == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Hour to Second...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tHour : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        hs = (num * 3600);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tSecond : " + hs);
                        Console.ResetColor();
                    }
                    else if (n == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Hour to Minute...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tHour : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        hm = (num * 60);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tMinute : " + hm);
                        Console.ResetColor();
                    }
                    else if (n == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Hour to Day...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tHour : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        hd = (num / 24);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tDay : " + hd);
                        Console.ResetColor();
                    }
                    else if (n == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Day to Second...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tDay : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        ds = (num * 86400);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tSecond : " + ds);
                        Console.ResetColor();
                    }
                    else if (n == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Day to Minute...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tDay : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        dm = (num * 1440);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tMinute : " + dm);
                        Console.ResetColor();
                    }
                    else if (n == 12)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Program.Print("\tConverting Day to Hour...", 60);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\tDay : ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        num = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        dh = (num * 24);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.Print("\tHour : " + dh);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Program.Print("\t\t\t INVALID!");
                        Console.ResetColor();
                    }

                    Console.WriteLine("------------------------------------------------------------");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program.Print("\t\t\t INVALID!");
                    Console.ResetColor();
                    break;



            }
        }
        catch {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Program.Print("\t\t\t INVALID!");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------");
        }

    }
}