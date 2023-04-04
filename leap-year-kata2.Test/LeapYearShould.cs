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
        public void DetectYear100AsNoLeap()
        {
            var isLeapYear = LeapYear.IsLeap(100);
            isLeapYear.Should().Be(false);
        }

        [Test]
        public void DetectYear200AsNoLeap()
        {
            var isLeapYear = LeapYear.IsLeap(200);
            isLeapYear.Should().Be(false);
        }

        [Test]
        public void DetectYear300AsNoLeap()
        {
            var isLeapYear = LeapYear.IsLeap(300);
            isLeapYear.Should().Be(false);
        }
    }

    public class LeapYear
    {
        public static bool IsLeap(int year)
        {
            if (year % 100 == 0)
            {
                return false;
            }

            if (year % 4 == 0)
            {
                return true;
            }

            return false;
        }
    }
}