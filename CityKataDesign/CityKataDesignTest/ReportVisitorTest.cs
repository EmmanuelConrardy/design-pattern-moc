using Microsoft.VisualStudio.TestTools.UnitTesting;
using CityKataDesign;

namespace CityKataDesignTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var visitor = new ReportingVisitor();

            var armyArea = new ArmyArea("RUBANS ROUGES", 200, null);
            var politicalArea = new PoliticalArea("RN", "Marine", null);
            var educationalArea = new EducationalArea("ESGI", "Sananes", null);

            armyArea.Accept(visitor);
            politicalArea.Accept(visitor);
            educationalArea.Accept(visitor);

            var result = visitor.Report();
            
            Assert.AreEqual("Nous sommes 200 RUBANS ROUGES, RN de Marine ont gagné et Sananes est directeur de l'ESGI.", result);
        }
    }
}
