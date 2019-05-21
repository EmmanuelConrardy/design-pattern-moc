using System;
using System.Reflection;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JusticeLeague.Test
{
    [TestClass]
    public class JusticeLeagueTest
    {
        [TestMethod]
        public void GetHeroes_()
        {
            //Arrange
            var serviceHero = new ServiceHero();
            //Act
            var result = serviceHero.GetHeroes();
            //Assert

            Assert.IsTrue(result.Contains("Deadpool"));
        }

        [TestMethod]
        public void GetCachedHeroes_WithProxy()
        {
            //Arrange
            var serviceHero = new ServiceHero();
            var proxy = new CacheProxyHero(serviceHero);
            proxy.GetHeroes(); // mise en cache
            Assert.IsFalse(proxy.CacheIsUsed);

            //Act
            var result = proxy.GetHeroes();

            //Assert
            Assert.IsTrue(proxy.CacheIsUsed);
            Assert.IsTrue(result.Contains("Deadpool"));
        }

        public class CacheProxyHero: IJusticeLeague {
            private ServiceHero serviceHero;
            private Dictionary<string, List<string>> Cache = new Dictionary<string, List<string>>();
            public bool CacheIsUsed;

            public CacheProxyHero(ServiceHero serviceHero) {
                this.serviceHero = serviceHero;
            }

            public List<string> GetHeroes(){
                if (Cache.ContainsKey("Heroes")) {
                    CacheIsUsed = true;
                    return Cache["Heroes"];
                }

                var heroes = serviceHero.GetHeroes();
                
                Cache.Add("Heroes", heroes);

                return heroes;
            }
        }
    }

    public interface IJusticeLeague{
        List<string> GetHeroes();
    }

    public class ServiceHero : IJusticeLeague{
        private List<string> heroes;

        public ServiceHero()
        {
            this.heroes = new List<string>(){"Ant-Man","Blade", "Black Widow","Bucky",
            "Cable","Captain America","Captain Britain","Captain Marvel","Dr Fatalis",
            "Spiderman","Deadpool" };
        }

        public List<string> GetHeroes(){
            return heroes;
        }
    }
}
