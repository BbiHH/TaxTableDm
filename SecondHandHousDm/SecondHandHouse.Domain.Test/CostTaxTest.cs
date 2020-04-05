using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondHandHouse.Domain;

namespace SecondHandHouse.Domain.Test
{
    [TestClass]
    public class CostTaxTest
    {
        [TestMethod]
        public void CostTaxTest_ReturnFive()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.Normal); // FiveYears,Normal
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //static Cost 5
            var expected = 5.0;

            //actual
            var actual = transaction.CostTax;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}