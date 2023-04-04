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
            var isLeapYear = LeapYear.IsLeap(4);
            isLeapYear.Should().Be(true);
        }

        [Test]
        public void DetectYear8AsLeap()
        {
            var isLeapYear = LeapYear.IsLeap(8);
            isLeapYear.Should().Be(true);
        }

        [Test]
        public void DetectYear12AsLeap()
        {
            var isLeapYear = LeapYear.IsLeap(12);
            isLeapYear.Should().Be(true);
        }

        [Test]
        public void DetectYear400AsLeap()
        {
            var isLeapYear = LeapYear.IsLeap(400);
            isLeapYear.Should().Be(true);
        }
    }

    public class LeapYear
    {
        public static bool IsLeap(int year)
        {
            if (year == 400)
            {
                return true;
            }

            if (year % 4 == 0)
            {
                return true;
            }

            return false;
        }
    }
}