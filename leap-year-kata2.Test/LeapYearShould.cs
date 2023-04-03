using FluentAssertions;

namespace leap_year_kata2.Test
{
    public class LeapYearShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DetectYear1AsNoLeap()
        {
            var isLeapYear = LeapYear.IsLeap(1);
            isLeapYear.Should().Be(false);
        }

        [Test]
        public void DetectYear4AsLeap()
        {
            var isLeapYear = LeapYear.IsLeap(1);
            isLeapYear.Should().Be(true);
        }
    }

    public class LeapYear
    {
        public static bool IsLeap(int year)
        {
            return false;
        }
    }
}