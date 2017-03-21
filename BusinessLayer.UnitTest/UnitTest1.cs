using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using BusinessLayer.Repositories;
using BusinessLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //primeiro teste com input "DART"
        [TestMethod]
        public void RunATest1()
        {
            TestMethod1("DART");
        }

        //segundo teste com input "LIVERPOOL"
        [TestMethod]
        public void RunATest2()
        {
            TestMethod2("LIVERPOOL");
        }

        //terceiro teste com input "KING CROSS"
        [TestMethod]
        public void RunATest3()
        {
            TestMethod3("KINGS CROSS");
        }

        //primeiro teste com "DARTFORD", "DARTMOUTH", "DERBY"
        public void TestMethod1(string input)
        {
            StationRepository stationRep = new StationRepository();
            StationsArray.stations = new string[] { "DARTFORD", "DARTMOUTH", "DERBY" };

            ResultSet set = new ResultSet(stationRep.GetAllStartedWithName(input));
            Assert.IsTrue(set.allNextCharacters.Any(c => c == 'F'));
            Assert.IsTrue(set.allNextCharacters.Any(c => c == 'M'));
            Assert.IsTrue(set.stations.Any(s => s == "DARTFORD"));
            Assert.IsTrue(set.stations.Any(s => s == "DARTMOUTH"));
        }

        //teste com "LIVERPOOL", "LIVERPOOL LIME STREET", "PADDINGTON"
        public void TestMethod2(string input)
        {
            StationRepository stationRep = new StationRepository();
            StationsArray.stations = new string[] { "LIVERPOOL", "LIVERPOOL LIME STREET", "PADDINGTON"};

            ResultSet set = new ResultSet(stationRep.GetAllStartedWithName(input));
            Assert.IsTrue(set.allNextCharacters.Any(r => r == ' '));
            Assert.IsTrue(set.stations.Any(r => r == "LIVERPOOL"));
            Assert.IsTrue(set.stations.Any(r => r == "LIVERPOOL LIME STREET"));
        }

        //teste com "EUSTON", "LONDON BRIDGE", "VICTORIA"
        public void TestMethod3(string input)
        {
            StationRepository stationRep = new StationRepository();
            StationsArray.stations = new string[] { "EUSTON", "LONDON BRIDGE", "VICTORIA" };

            ResultSet set = new ResultSet(stationRep.GetAllStartedWithName(input));
            Assert.IsTrue(set.allNextCharacters.Count == 0);
            Assert.IsTrue(set.stations.Count == 0);
        }
    }
}
