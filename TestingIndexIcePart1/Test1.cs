using IndexIceTaskPart1;

namespace TestingIndexIcePart1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestPackage()
        {
            Fitness fit = new Fitness(2, 500, "VirginActive", "Adidas", "GreenAcres");
            Assert.AreEqual(fit[0], 2);
        }

        [TestMethod]
        public void TestUpdatePackage()
        {
            Fitness fit = new Fitness(2, 500, "VirginActive", "Adidas", "GreenAcres");
            fit["fitPackage"] = 3; //string index
            Assert.AreEqual(fit["fitPackage"], 3);
        }

        [TestMethod]
        public void TestPrice()
        {
            Fitness fit = new Fitness(2, 500, "VirginActive", "Adidas", "GreenAcres");
            Assert.AreEqual(fit[1], 500);
        }

        [TestMethod]
        public void TestChain()
        {
            Fitness fit = new Fitness(2, 500, "VirginActive", "Adidas", "GreenAcres");
            fit[2] = "VirginActive";
            Assert.AreEqual(fit[2], "VirginActive");
        }

        [TestMethod]
        public void TestUpdateBrand()
        {
            Fitness fit = new Fitness(2, 500, "VirginActive", "Adidas", "GreenAcres");
            fit[3] = "Nike";
            Assert.AreEqual(fit[3], "Nike");
        }

        [TestMethod]
        public void TestLocation()
        {
            Fitness fit = new Fitness(2, 500, "VirginActive", "Adidas", "GreenAcres");
            fit[3] = "GreenAcres";
            Assert.AreEqual(fit[4], "GreenAcres");
        }
    }
}
