using System;

namespace Kalkulator_naukowy
{
    class Kalkulator
    {
        static void Main(string[] args)
        {
            bool program = true;
            string case_switch ="";
            while (program)
            {
                //Console.ReadKey();
                Console.Clear();
                case_switch = "";
                Console.WriteLine("podaj tryb kalkulatora \n" +
                    "1. tryb prosty \n" +
                    "2. tryb naukowy \n" +
                    "3. tryb programistyczny");
                if (case_switch == null || case_switch == "")
                {
                    case_switch = Console.ReadLine();
                }
                switch(case_switch)
                { 
                    default:
                        Console.WriteLine("podałeś błędną opcję");
                        break;

                    case "1":
                        prosty();
                        break;
                    case "2":
                        Console.WriteLine("wybrałeś tryb naukowy");
                        break;
                    case "3":
                        Console.WriteLine("wybrałeś tryb programistyczny");
                        break;
                }
            }
        }

        static void prosty()
        {
            Console.Clear();
            string case_s = "";
            Kalk_prosty obj = new Kalk_prosty();
            while (true)
            {
                Console.WriteLine("napisz diałanie \n" +
                    "q -  wyjście \n" +
                    "enter - wyświetl wynik");
                case_s = Console.ReadLine();
                Console.Clear();
                switch (case_s)
                {
                    default:
                        obj.oblicz(case_s);
                        break;
                    case "":
                        Console.WriteLine("wynik to: " + obj.Wynik);
                        Console.WriteLine("______________________");
                        Console.WriteLine();
                        break;
                    case "q":
                        return;
                }
            }

        }
    }
}