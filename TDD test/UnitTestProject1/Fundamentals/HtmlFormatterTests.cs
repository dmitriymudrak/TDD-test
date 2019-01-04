using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject1.Fundamentals
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEnclosedElementWithStrongTag()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("someString");

            //specific
            //Assert.That(result, Is.EqualTo("<strong>someString</strong>"));

            //more general
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("someString"));
        }
    }
}
