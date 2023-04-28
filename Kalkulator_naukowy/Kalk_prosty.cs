using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_naukowy
{
    internal class Kalk_prosty
    {
        private double _wynik = 0;
        public Kalk_prosty()
        {

        }
        ~Kalk_prosty()
        {

        }

        public double Wynik { get => _wynik; set => _wynik = value; }

        public void oblicz(string dzia) //działanie
        {
            dzia += " ";
            string numb = "";
            var list_ofn = new List<string>();
            char sight = ' ';
            for (int i=0;i<dzia.Length;i++)
            {
                if (dzia[i] == ' ' && numb != "")
                {
                    list_ofn.Add(numb);
                    numb = "";
                }
                else if (dzia[i] == '+'
                    || dzia[i] == '-'
                    || dzia[i] == '*'
                    || dzia[i] == '/')
                {
                    sight = dzia[i];
                }
                else if (dzia[i] == '.' || dzia[i] == ',')
                {
                    numb += ',';
                }
                else
                {
                    numb += dzia[i];
                }
            }
            switch(sight)
            {
                default:
                    return;
                case '+':
                    Wynik = Convert.ToDouble(list_ofn[0]) + Convert.ToDouble(list_ofn[1]);
                    break;
                case '-':
                    Wynik = Convert.ToDouble(list_ofn[0]) - Convert.ToDouble(list_ofn[1]);
                    break;
                case '*':
                    Wynik = Convert.ToDouble(list_ofn[0]) * Convert.ToDouble(list_ofn[1]);
                    break;
                case '/':
                    Wynik = Convert.ToDouble(list_ofn[0]) / Convert.ToDouble(list_ofn[1]);
                    break;
            }
            return;
        }
    }
}
