namespace FundamentalsRefresherAssignment
{
    internal class Answers
    {
        public enum Role { Admin, User, Guest }

        public static string WeekDayNumberToText(int weekDay)
        {
            switch (weekDay)
            {
                case 1: return "Maanantai";
                case 2: return "Tiistai";
                case 3: return "Keskiviikko";
                case 4: return "Torstai";
                case 5: return "Perjantai";
                case 6: return "Lauantai";
                case 7: return "Sunnuntai";
                default: return "Virheellinen päivä";
            }
        }

        public static string GetUserGeneration(int birthYear)
        {
            if (birthYear >= 1980 && birthYear <= 1996) 
                return "Milleniaali";
            if (birthYear >= 1997 && birthYear <= 2012)
                return "Gen Z";
            if (birthYear >= 1946 && birthYear <= 1964) 
                return "Baby Boomer";
            if (birthYear >= 2013) 
                return "Alpha";

            return "Tuntematon sukupolvi";
        }

        public static bool CheckUserPrivliges(Role role, string password)
        {
            if (role == Role.Admin)
                return true;
            if (role == Role.User && password == "1234")
                return true;

            //Toinen tapa yhdellä rivillä
            if (role == Role.Admin || (role == Role.User && password == "1234"))
                return true;

            return false;
        }

        public static string ConvertGradeToDescription(int grade)
        {
            var gradeDescriptions = new Dictionary<int, string>
            {
                {1, "Heikko"},
                {2, "Välttävä"},
                {3, "Tyydyttävä"},
                {4, "Hyvä"},
                {5, "Kiitettävä"}
            };

            if (gradeDescriptions.TryGetValue(grade, out string description))
            {
                return description;
            }

            return "Tuntematon arvosana";
        }

        static List<string> GetCitiesWithPopulationOver(int populationThreshold)
        {
            //Kirjoita algoritmi, joka palauttaa kaupungit, jotka ylittävät paramerina tulevan asukasmäärän
            //Esim 600000 palauttaa vain Helsinki
            //Palauta kaupungit siinä muodossa, joka on funktion palautusarvo

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

            List<string> cities = new();

            foreach (var city in cityPopulations)
            {
                if (city.Value > populationThreshold)
                {
                    cities.Add(city.Key);
                }
            }

            return cities;
        }

    }
}
