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
    }
}
