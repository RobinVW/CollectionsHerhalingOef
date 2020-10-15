using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionsHerhalingOef;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef.Tests
{
    
    [TestClass()]
    public class RederijTests
    {

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Executes once before the test run. (Optional)
        }

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            // Executes once for the test class. (Optional)
        }

        [TestInitialize]
        public void Setup()
        {
            // Runs before each test. (Optional)
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // Executes once after the test run. (Optional)
        }

        [ClassCleanup]
        public static void TestFixtureTearDown()
        {
            // Runs once after all tests in this class are executed. (Optional)
            // Not guaranteed that it executes instantly after all tests from the class.
        }

        [TestCleanup]
        public void TearDown()
        {
            // Runs after each test. (Optional)
        }

        [TestMethod()]
        public void RederijTest()
        {
            // Arrange 

            SortedSet<Vloot> vlote = new SortedSet<Vloot>();
            ///Vloot vloot1 = new Vloot("vloot1", HashSet < schip > shepen);

                // Act 


                // Assert           

        }

        [TestMethod()]
        public void voegVlootToeTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void verwijderVlootTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void ZoekVlootOpTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void berekenTotaleCargoTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void berekenBeschikbareSleepbotenTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void toonSchipInfoTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void berekenTotaalVolumeTankersTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void berekenTonnagePerVlootTest()
        {
            throw new NotImplementedException();
        }
    }
}