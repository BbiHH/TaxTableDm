using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondHandHouse.Domain;

namespace SecondHandHouse.Domain.Test
{
    [TestClass]
    public class DeedTaxTest
    {
        [TestMethod]
        public void DeedTaxTest_IsFirstHouseAndSmall_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.NonNormal); // 80,smallHouse
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:1.0
            var expected = 4800.0;

            //actual
            var actual = transaction.DeedTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeedTaxTest_IsFirstHouseAndMediu_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(100, 6000, true, EstatePorperty.NonNormal); // 80,smallHouse
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:2.0
            var expected = 12000.0;

            //actual
            var actual = transaction.DeedTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeedTaxTest_IsFirstHouseAndLarge_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(160, 6000, true, EstatePorperty.NonNormal); // 160,LargeHouse
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:4.0
            var expected = 38400.0;

            //actual
            var actual = transaction.DeedTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeedTaxTest_IsNotFirstHouseAndLarge_Return()
        {
            Buyer buyer = new Buyer(false);
            House house = new House(160, 6000, true, EstatePorperty.NonNormal); // 160,LargeHouse
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:4.0
            var expected = 38400.0;

            //actual
            var actual = transaction.DeedTax;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}