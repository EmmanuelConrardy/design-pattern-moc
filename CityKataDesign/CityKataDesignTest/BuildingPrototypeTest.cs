using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CityKataDesign;

namespace CityKataDesignTest
{
    [TestClass]
    public class BuildingPrototypeTest
    {
        [TestMethod]
        public void should_clone_house()
        {
           //Arrange
           var housePrototype = new House("t1", 10);
           var city = new CityPlan();
           city.HouseRegistry["t1"] = housePrototype;
           
           var cloneHouse = (House)city.HouseRegistry["t1"].Clone();
           cloneHouse.Dimension = 30;

           var otherClone = (House)city.HouseRegistry["t1"].Clone();
           
           Assert.AreEqual(30, cloneHouse.Dimension);
           Assert.AreEqual(10, otherClone.Dimension);
        }

        abstract class Prototype {
            public virtual Prototype Clone() {
                throw new NotImplementedException();
            }
        }

        class House: Prototype {
            public int Dimension { get; set; }
            public string Name { get; set; }

            public House(string name, int dimension) {
                this.Dimension = dimension;
                this.Name = name;
            }

           public override Prototype Clone() {
                return new House(this.Name, this.Dimension);
            }
        }

        class CityPlan {
            public Dictionary<string, Prototype> HouseRegistry { get; set; }

            public CityPlan() {
                HouseRegistry = new Dictionary<string, Prototype>();
            }
        }
    }
}
