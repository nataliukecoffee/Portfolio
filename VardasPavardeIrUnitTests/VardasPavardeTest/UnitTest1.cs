using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VardasPavardeBL;

namespace VardasPavardeTest
{
    [TestClass]
    public class VardasPavardeTests
    {
        [TestMethod]
        public void GetAgeShouldReturnHumanAge()
        {
            // Assign
            VardasPavarde vardasPavarde = new VardasPavarde("Natalija",
                "Griadovskaja",
                new DateTime(2000, 01, 01));
            // Act
            int metai = vardasPavarde.GetAge();
            // Asert
            Assert.AreEqual(19, metai);
        }

        [TestMethod]
        public void GetAgeWithBorderValue()
        {
            // Assign
            VardasPavarde vardasPavarde = new VardasPavarde("Natalija",
                "Griadovskaja",
                new DateTime(2019, 01, 01));
            // Act
            int metai = vardasPavarde.GetAge();
            // Asert
            Assert.AreEqual(0, metai);
        }

        [TestMethod]
        public void GetAgeWithNegativeValue()
        {
            // Assign
            VardasPavarde vardasPavarde = new VardasPavarde("Natalija",
                "Griadovskaja",
                new DateTime(2021, 01, 01));
            // Act
            int metai = vardasPavarde.GetAge();
            // Asert
            Assert.AreEqual(0, metai);
        }
    }
}
