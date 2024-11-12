using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsRefresherAssignment
{
    public static class Assignments
    {
        public enum Role { Admin, User, Guest }

        public static string WeekDayNumberToText(int weekDay)
        {
            //Kirjoita algoritmi, joka kysyy käyttäjältä viikonpäivän numeron(1 - 7)
            //ja tulostaa vastaavan viikonpäivän nimen käyttäen switch-rakennetta.

            return "";
        }

        public static string GetUserGeneration(int birthYear)
        {
            //Tee algoritmi, joka palauttaa käyttäjän generaation johon hän kuuluu syntymävuoden perusteella
            //Esim 1980 palauttaa milleniaali 2000 palauttaa gen z
            //Riittää 1946-2024 vuodet


            return "";
        }

        public static bool CheckUserPrivliges(Role role, string password)
        {
            //Kirjoita algoritmi joka tarkistaa onko käyttäjällä oikeudet
            //Käyttäjällä on oikeudet, jos käyttäjä on Admin
            //tai jos käyttjä on user ja salasana on "1234"
            //guest roolilla ei ole oikeutta


            return false;
        }

        public static string ConvertGradeToDescription(int grade)
        {
            // Tee algoritmi, joka muuttaa numeron 1-5 sanalliseksi arvosanaksi
            // käyttäen switch-rakennetta.
            // 1 - "Heikko"
            // 2 - "Välttävä"
            // 3 - "Tyydyttävä"
            // 4 - "Hyvä"
            // 5 - "Kiitettävä"
            // Jos numero on jotain muuta kuin 1-5, palauta "Tuntematon arvosana".
            //Käytä tehtävässä Dictionarya

            return "";
        }

        public static List<string> GetCitiesWithPopulationOver(int populationThreshold)
        {
            //Kirjoita algoritmi, joka palauttaa kaupungit, jotka ylittävät paramerina tulevan asukasmäärän
            //Esim 600000 palauttaa vain Helsinki

            Dictionary<string, int> cityPopulations = new()
            {
                { "Helsinki", 655281 },
                { "Espoo", 292913 },
                { "Tampere", 244223 },
                { "Vantaa", 237231 },
                { "Oulu", 209648 },
                { "Mikkeli", 51000 },
                { "Iisalmi", 20000 }
            };

            foreach (var city in cityPopulations)
            {
                if (city.Value > populationThreshold)
                {
                    Console.WriteLine(city.Key);
                }
            }


            return new List<string>();
        }
    }
}
