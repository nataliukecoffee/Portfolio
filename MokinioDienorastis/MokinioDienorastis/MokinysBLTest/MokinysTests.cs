using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MokinysBL;

namespace MokinysBLTest
{
    [TestClass]
    public class MokinysTests
    {
        [TestMethod]
        public void TestforAverageCountWhenthereAreNoAnyCongnite()
        {
            //Assign
            Mokinys mokinys = new Mokinys(9, "Petras", true);

            int expected = 0;
            int actual = 0;
            //Act

            actual = mokinys.PazymiuVidurkis();
            //Asert

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestforAverageCountWhenthereAreOneCongnite()
        {
            //Assign
            Mokinys mokinys = new Mokinys(9, "Petras", true);
            mokinys.PazymiuSarasas.Add(10);

            int expected = 10;
            int actual = 0;
            //Act

            actual = mokinys.PazymiuVidurkis();
            //Asert

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestforAverageCountWhenthereAreTwoCongnites()
        {
            //Assign
            Mokinys mokinys = new Mokinys(9, "Petras", true);
            mokinys.PazymiuSarasas.Add(10);
            mokinys.PazymiuSarasas.Add(8);

            int expected = 9;
            int actual = 0;
            //Act

            actual = mokinys.PazymiuVidurkis();
            //Asert

            Assert.AreEqual(expected, actual);


        }
    }
}
