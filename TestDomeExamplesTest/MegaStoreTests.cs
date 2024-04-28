using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MegaStore;

namespace TestDomeExamplesTest.MegaStoreTesting
{
    [TestFixture]
    public class MegaStoreTests
    {
        double totalPrice = 100;

        [Test]
        public void ExampleCase()
        {
            Assert.That(GetDiscountedPrice(12, totalPrice, DiscountType.Weight),Is.EqualTo(82));
        }

        [Test]
        public void StandardDiscount()
        {
            double expectedValue = totalPrice - 6;
            Assert.That(GetDiscountedPrice(12, totalPrice, DiscountType.Standard),Is.EqualTo(expectedValue));
        }

        [Test]
        public void SeasonalDiscount()
        {
            double expectedValue = totalPrice - 12;
            Assert.That(GetDiscountedPrice(12, totalPrice, DiscountType.Seasonal), Is.EqualTo(expectedValue));
        }

        [Test]
        public void WeightedDiscount()
        {
            double expectedValue1 = totalPrice - 6;
            double expectedValue2 = totalPrice - 18;
            Assert.That(GetDiscountedPrice(8, totalPrice, DiscountType.Weight), Is.EqualTo(expectedValue1));
            Assert.That(GetDiscountedPrice(20, totalPrice, DiscountType.Weight), Is.EqualTo(expectedValue2));
        }
    }
}
