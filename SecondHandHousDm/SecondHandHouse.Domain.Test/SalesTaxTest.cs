using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondHandHouse.Domain;

namespace SecondHandHouse.Domain.Test
{
    [TestClass]
    public class SalesTaxTest
    {
        [TestMethod]
        public void SalesTaxTest_FiveYearsHouseAndNormal_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.Normal); // FiveYears,Normal
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:0.0
            var expected = 0.0;

            //actual
            var actual = transaction.SalesTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTaxTest_NotFiveYearsHouseAndNormal_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, false, EstatePorperty.Normal); // NotFiveYears,Normal
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:5.6
            var expected = 26880;

            //actual
            var actual = transaction.SalesTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTaxTest_FiveYearsHouseAndNonNormal_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.NonNormal); // FiveYears,NonNormal
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:5.6
            var expected = 26880;

            //actual
            var actual = transaction.SalesTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalesTaxTest_NotFiveYearsHouseAndNonNormal_Return()
        {
            Buyer buyer = new Buyer(false);
            House house = new House(80, 6000, false, EstatePorperty.NonNormal); // NotFiveYears,NonNormal
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:5.6
            var expected = 26880;

            //actual
            var actual = transaction.SalesTax;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}