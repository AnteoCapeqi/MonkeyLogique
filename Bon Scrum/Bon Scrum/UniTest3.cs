using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bon_Scrum
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]

        public void TestMethodFactorialDeux()
        {
            int result = Factorial.Calculate(2);
            Assert.AreEqual(2, result);
        }
    }
}
