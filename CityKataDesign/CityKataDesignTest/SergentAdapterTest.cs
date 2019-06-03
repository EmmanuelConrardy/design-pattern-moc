using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CityKataDesign;

namespace CityKataDesignTest
{
    [TestClass]
    public class sergentAdapterTest
    {
        [TestMethod]
        public void Should_adapt_sergent_into_educator()
        {
            //initialisation
            List<Sergent> sergents = new List<Sergent> {
                new Sergent("Garcia", 20),
                new Sergent("Ryan", 10),
                new Sergent("Sananes", 1000)
            };
            ArmyArea area = new ArmyArea("RUBANS ROUGES", 200, sergents);

            SergentAdapter adapter = new SergentAdapter(area);

            EducationalArea educationalArea = new EducationalArea("ESGI", "HENNOU", new List<Educator>());

            educationalArea.AddEducator(adapter.GetEducators());

            var result = educationalArea.GetEducator().Select(e => e.Name);

            Assert.IsTrue(result.Contains("Garcia"));
            Assert.IsTrue(result.Contains("Sananes"));
            Assert.IsTrue(result.Contains("Ryan"));
        }

        public class SergentAdapter: IEducationalService {
            ArmyArea armyArea;
            public SergentAdapter(ArmyArea area) {
                this.armyArea = area;
            }
            public List<Educator> GetEducators() {
                List<Educator> educators = new List<Educator>();
                foreach (Sergent item in armyArea.GetSergents())
                {
                    educators.Add(new Educator(item.Name, item.Seniority));
                }

                return educators;
            }
        }
    }
}
