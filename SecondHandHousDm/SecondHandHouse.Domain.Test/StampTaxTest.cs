using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondHandHouse.Domain;

namespace SecondHandHouse.Domain.Test
{
    [TestClass]
    public class StampTaxTest
    {
        [TestMethod]
        public void StampTest_ReturnZero()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.Normal); // FiveYears,Normal
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            // No Tax Cost
            var expected = 0.0;

            //actual
            var actual = transaction.StampTax;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}