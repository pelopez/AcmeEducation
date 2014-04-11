using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Web.Models;
using NUnit.Framework;

namespace Acme.Web.Tests
{
    [TestFixture]
    public class SuperComplexModelTests
    {
        [Test]
        public void FullName_Returns_FirstName_And_LastName_Properly_Spaced()
        {
            var model = new SuperComplexModel {FirstName = "Pete", LastName = "Lopez"};

            var expected = "Pete Lopez";

            Assert.AreEqual(expected, model.FullName);
        }

        [Test]
        public void PerformComplexAddition_When_Given_2_and_2_Returns_4()
        {
            var theFirstNum = 2;
            var theSecondNum = 2;

            var expected = 4;

            Assert.AreEqual(expected, SuperComplexModel.PerformComplexAddition(theFirstNum, theSecondNum));
        }

        [Test]
        public void PerformComplexAddition_When_Given_3_and_3_Returns_6()
        {
            var theFirstNum = 3;
            var theSecondNum = 3;

            var expected = 6;

            Assert.AreEqual(expected, SuperComplexModel.PerformComplexAddition(theFirstNum, theSecondNum));
        }
    }
}
