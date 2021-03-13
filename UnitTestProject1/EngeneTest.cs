using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldCore;

namespace HelloWorldTests
{
    [TestClass]
    public class EngeneTest
    {
        Engene engene = new Engene();
        

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(engene.isThisCorectStreeng("5x5 (1,4)(1,4)(1,4)(4,4)(4,1)"), "5x5 (1,4)(1,4)(1,4)(4,4)(4,1)");
            //Assert.AreEqual(engene.Run("5x5 (1, 3) (4, 4)"), "ENNNDEEEND");
        }
    }
}