using NUnit.Framework;
using TestNinja.Fundamentals;


namespace UnitTestProject1
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(3, 3, 3)]
        [TestCase(5, 1, 5)]
        public void Max_WhenCalled_ReturnGreater(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
