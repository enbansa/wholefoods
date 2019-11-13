using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitCalculator;

namespace NUnitCalculator
{
    [TestFixture]
    class TestCalculator
    {
        [Test]
        public void PassAdd ()
        {

            Assert.AreEqual(5, new Calculator().Add(4,1));

        }

        [Test]
        public void FailAdd()
        {
            Assert.AreEqual(3, new Calculator().Add(4, 1));

        }
        [Test]
        public void PassMinus()
        {
            Assert.AreEqual(3, new Calculator().Minus(4, 1));

        }

        [Test]
        public void FailMinus()
        {
            Assert.AreEqual(2, new Calculator().Minus(4, 1));

        }
    }
}
