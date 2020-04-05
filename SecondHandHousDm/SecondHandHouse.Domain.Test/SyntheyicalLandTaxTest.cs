using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondHandHouse.Domain;

namespace SecondHandHouse.Domain.Test
{
    [TestClass]
    public class SyntheyicalLandTaxTest
    {
        [TestMethod]
        public void SyntheyicalLandTaxTest_FiveYearsHouseAndNormal_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.Normal); // FiveYears, NotAffordable
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:0.0
            var expected = 0.0;

            //actual
            var actual = transaction.SyntheyicalLandTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SyntheyicalLandTaxTest_NotFiveYearsHouseAndNormal_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, false, EstatePorperty.Normal); // NotFiveYears,NotAffordable
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:0.0
            var expected = 0.0;

            //actual
            var actual = transaction.SyntheyicalLandTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SyntheyicalLandTaxTest_FiveYearsHouseAndAffordable_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.Affordable); // FiveYears,Affordable
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:10.0
            var expected = 48000;

            //actual
            var actual = transaction.SyntheyicalLandTax;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}