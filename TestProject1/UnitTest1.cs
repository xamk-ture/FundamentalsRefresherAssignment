using FundamentalsRefresherAssignment;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "Maanantai")]
        [InlineData(2, "Tiistai")]
        [InlineData(3, "Keskiviikko")]
        [InlineData(4, "Torstai")]
        [InlineData(5, "Perjantai")]
        [InlineData(6, "Lauantai")]
        [InlineData(7, "Sunnuntai")]
        [InlineData(0, "Virheellinen päivä")]
        [InlineData(8, "Virheellinen päivä")]
        public void WeekDayNumberToText_ReturnsCorrectDayName(int weekDay, string expected)
        {
            var result = Assignments.WeekDayNumberToText(weekDay);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1980, "Milleniaali")]
        [InlineData(2000, "Gen Z")]
        [InlineData(1995, "Gen Z")]
        [InlineData(1965, "Baby Boomer")]
        [InlineData(2023, "Alpha")]
        public void GetUserGeneration_ReturnsCorrectGeneration(int birthYear, string expectedGeneration)
        {
            var result = Assignments.GetUserGeneration(birthYear);
            Assert.Equal(expectedGeneration, result);
        }

        [Theory]
        [InlineData(Assignments.Role.Admin, "anyPassword", true)]
        [InlineData(Assignments.Role.User, "1234", true)]
        [InlineData(Assignments.Role.User, "wrongPassword", false)]
        [InlineData(Assignments.Role.Guest, "anyPassword", false)]
        public void CheckUserPrivileges_ReturnsCorrectPrivileges(Assignments.Role role, string password, bool expectedPrivilege)
        {
            var result = Assignments.CheckUserPrivliges(role, password);
            Assert.Equal(expectedPrivilege, result);
        }

        [Theory]
        [InlineData(1, "Heikko")]
        [InlineData(2, "Välttävä")]
        [InlineData(3, "Tyydyttävä")]
        [InlineData(4, "Hyvä")]
        [InlineData(5, "Kiitettävä")]
        [InlineData(6, "Tuntematon arvosana")]
        public void ConvertGradeToDescription_ReturnsCorrectDescription(int grade, string expectedDescription)
        {
            var result = Assignments.ConvertGradeToDescription(grade);
            Assert.Equal(expectedDescription, result);
        }

        [Theory]
        [InlineData(600000, new[] { "Helsinki" })]
        [InlineData(250000, new[] { "Helsinki", "Espoo" })]
        [InlineData(50000, new[] { "Helsinki", "Espoo", "Tampere", "Vantaa", "Oulu" })]
        [InlineData(200000, new[] { "Helsinki", "Espoo", "Tampere", "Vantaa" })]
        [InlineData(0, new[] { "Helsinki", "Espoo", "Tampere", "Vantaa", "Oulu", "Mikkeli", "Iisalmi" })]
        public void GetCitiesWithPopulationOver_ReturnsCorrectCities(int populationThreshold, string[] expectedCities)
        {
            var result = Assignments.GetCitiesWithPopulationOver(populationThreshold);
            Assert.Equal(expectedCities.OrderBy(c => c), result.OrderBy(c => c));
        }
    }
}