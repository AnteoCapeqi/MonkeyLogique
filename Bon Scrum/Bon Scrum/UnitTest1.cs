using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bon_Scrum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodFactorialZero()
        {
            int result = Factorial.Calculate(0);
            Assert.AreEqual(1,result);
        }
        
        public void TestMethodFactorialDeux()
        {
            int result = Factorial.Calculate(2);
            Assert.AreEqual(2, result);
        }
    }
}
