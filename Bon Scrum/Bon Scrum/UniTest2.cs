using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bon_Scrum
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethodFactorialUn()
        {
            int result = Factorial.Calculate(1);
            Assert.AreEqual(1, result);
        }

    }
}