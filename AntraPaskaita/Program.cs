using System;
using System.Security.Cryptography.X509Certificates;


namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main(string[] args)
        {
            //    1 uzduotis************************************************************

            //Console.WriteLine("Iveskite sveikaji skaiciu");

            //int sveikasSk = int.Parse(Console.ReadLine());

            //Console.WriteLine(ArTeigiamas(sveikasSk));




            //     2 uzduotis*************************************************************

            //Console.WriteLine("irasykite 3 sveikuosius skaicius");

            //int skaicius1 = int.Parse(Console.ReadLine());
            //int skaicius2 = int.Parse(Console.ReadLine());
            //int skaicius3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Didziausias skaicius yra: " + DidziausiasSkaicius(skaicius1, skaicius2, skaicius3));

            // 3 uzduotis***************************************************************

            //Console.WriteLine("Iveskite simboli");

            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //char symbol = keyInfo.KeyChar;
            //symbol = char.ToLower(symbol);

            //Console.WriteLine();
            //Console.WriteLine(ArBalse(symbol));

            // 4 uzduotis***************************************************************

            //Console.WriteLine("Iveskite metus");

            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine(year + " " + ArKeliamieji(year));

            // 5 uzduotis***************************************************************

            //Console.WriteLine("Iveskite simboli");
            //string simbolis = Console.ReadLine();

            //TikrintiArSkaicius(simbolis);


            // 6 uzduotis*****************************************************

            //Console.WriteLine("Iveskite valandas");
            //int valandos = int.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite minutes");
            //int minutes = int.Parse(Console.ReadLine());

            //Console.WriteLine(TikrintiIvesti(valandos, minutes));

            // 7 uzduotis*****************************************************

            //Console.WriteLine("Iveskite sveikaji skaiciu");

            //int sveikasSk = int.Parse(Console.ReadLine());

            //Console.WriteLine(TikrintiArTriju(sveikasSk));

            // BONUS uzduotis *********************************************************

            //Console.WriteLine("Iveskite simboli");

            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //char simbolis = keyInfo.KeyChar;

            //Console.WriteLine();
            //Console.WriteLine(ArDidzioji(simbolis));

            // 8 uzduotis**********************************************************

            //Console.WriteLine("Iveskite kvadrato krastines ilgi");

            //float kvadKrast = float.Parse(Console.ReadLine());

            //Console.WriteLine("Kvadrato perimetras yra: " + KvadratoPerimetras(kvadKrast));

            // 9 uzduotis**********************************************************

            //Console.WriteLine("Iveskite trikampio pagrindo ilgi");
            //float trikPag = float.Parse(Console.ReadLine());

            //Console.WriteLine("Iveskite trikampio auksti");
            //float trikAukstis = float.Parse(Console.ReadLine());

            //Console.WriteLine("Trikampio plotas yra: " + TrikampioPlotas(trikPag, trikAukstis));

            // 10 uzduotis*******************************************************

            //Console.WriteLine("Iveskite apskritimo spinduli");
            //float spindulys = float.Parse(Console.ReadLine());

            //ApskritimoPlotas(spindulys);
            //ApskritimoPerimetras(spindulys);

            // 11 uzduotis*******************************************************

            //Console.WriteLine("Iveskite kubo krastines ilgi");
            //float kuboKrastine = float.Parse(Console.ReadLine());

            //RastiKuboTuri(kuboKrastine);

            // 12 uzduotis**************************************************

            //Console.WriteLine("Iveskite temperatura Celsijaus skaleje");
            //double celsijus = double.Parse(Console.ReadLine());

            //TurnToFarenheit(celsijus);



        }



        public static int DidziausiasSkaicius(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }

            else if (b > a && b > c)
            {
                return b;
            }

            else if (c > a && c > b)
            {
                return c;
            }
            return 0;


        }

        public static string ArBalse(char characteris)
        {
            switch (characteris)
            {
                case 'a':
                    return "simbolis yra balse";
                   
                case 'e':
                    return "simbolis yra balse";

                case 'i':
                    return "simbolis yra balse";

                case 'y':
                    return "simbolis yra balse";

                case 'o':
                    return "simbolis yra balse";

                case 'u':
                    return "simbolis yra balse";

                default:
                    return "simbolis yra priebalse";

            }
        }

        public static string ArTeigiamas(int a)
        {
            if (a > 0)
            {
                return "Skaicius teigiamas";
            }

            else if (a == 0)
            {
                return "Skaicius lygus 0";
            }
            return "Skaicius neigiamas";
        }

        public static string ArKeliamieji(int a)
        {
            if (a % 4 == 0)
            {
                return "yra keliamieji metai";
            }
            return "nera keliamieji metai";
        }

        public static void TikrintiArSkaicius(string a)
        {
            if (int.TryParse(a, out int b))
            {
                Console.WriteLine("Simbolis yra skaicius");
            }
            else
            {
                Console.WriteLine("Simbolis nera skaicius");
            }
        }

        public static string TikrintiIvesti(int a, int b)
        {
            if (a >= 24 || b >= 60)
            {
                return "Neteisinga ivestis";
            }
            else
            {
                return "Teisinga ivestis";
            }

        }

        public static string TikrintiArTriju(int a)
        {
            if (a >= 100 && a <= 999)
            {
                return "Triju skaitmenu skaicius";
            }
            else
            {
                return "Ne triju skaitmenu skaicius";
            }
        }

        public static string ArDidzioji(char a)
        {
            if (char.IsUpper(a) == true)
            {
                return "Didzioji raide";
            }
            else
            {
                return "Ne didzioji raide";
            }
        }

        public static float KvadratoPerimetras(float a)
        {
            float perimetras = a * 4;
            return perimetras;
        }

        public static float TrikampioPlotas(float a, float b)
        {
            float plotas = a / 2 * b;
            return plotas;
        }

        public static void ApskritimoPlotas(float a)
        {
            double plotas = Math.PI * Math.Pow(2, a);
            Console.WriteLine("Apskritimo plotas yra: " + Math.Round(plotas,2));
        }

        public static void ApskritimoPerimetras(float a)
        {
            double perimetras = 2 * Math.PI * a;
            Console.WriteLine("Apskritimo perimetras yra: " + Math.Round(perimetras, 2));
        }

        public static void RastiKuboTuri(float a)
        {
            double turis = Math.Pow(3, a);
            Console.WriteLine("Kubo turis yra: " + Math.Round(turis, 2));
        }

        public static void TurnToFarenheit(double a)
        {
            double farenheit = a * 1.8 + 32;
            Console.WriteLine("Temperatura Farenheito skaleje: " + Math.Round(farenheit,1));
        }
    }
}