using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondHandHouse.Domain;

namespace SecondHandHouse.Domain.Test
{
    [TestClass]
    public class PersonalIncomeTaxTest
    {
        [TestMethod]
        public void PersonalIncomeTaxTest_FiveYearsHouseAndIsOnlyHours_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.NonNormal); // FiveYears,IsOnlyHouse
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:0.0
            var expected = 0.0;

            //actual
            var actual = transaction.PersonalIncomeTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PersonalIncomeTaxTest_NotFiveYearsHouseAndIsOnlyHours_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, false, EstatePorperty.Normal); // NotFiveYears, IsOnlyHouse
            Seller seller = new Seller(house, true);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:3.0
            var expected = 14400;

            //actual
            var actual = transaction.PersonalIncomeTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PersonalIncomeTaxTest_FiveYearsHouseAndIsNotOnlyHours_Return()
        {
            Buyer buyer = new Buyer(true);
            House house = new House(80, 6000, true, EstatePorperty.NonNormal); // FiveYears,IsNotOnlyHouse
            Seller seller = new Seller(house, false);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:3.0
            var expected = 14400;

            //actual
            var actual = transaction.PersonalIncomeTax;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PersonalIncomeTaxTest_NotFiveYearsHouseAndIsNotOnlyHours_Return()
        {
            Buyer buyer = new Buyer(false);
            House house = new House(80, 6000, false, EstatePorperty.NonNormal); // NotFiveYears,IsNotOnlyHouse
            Seller seller = new Seller(house, false);
            Transaction transaction = new Transaction(seller, buyer);

            //rate:3.0
            var expected = 14400;

            //actual
            var actual = transaction.PersonalIncomeTax;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}