using NUnit.Framework;
using Problems;
namespace Tests
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ReturnNULLIfGivenNULL()
        {
            bool result = (Program.prefix(null)==null);

            //Assert.Pass(result, "Returned null given null");
            Assert.IsTrue(result, "Did not Return null given null");
        }
        [Test]
        public void TestHello()
        {
            bool result = (Program.prefix("hello")=="5,1:hello");

            //Assert.Pass(result, "Returned null given null");
            Assert.IsTrue(result, "Did not Return Correctly");
        }
        [Test]
        public void TestBlank()
        {
            bool result = (Program.prefix("")=="0,0:");

            //Assert.Pass(result, "Returned null given null");
            Assert.IsTrue(result, "Did not Return Correctly");
        }
        [Test]
        public void TestWhatdidyouJustSay()
        {
            bool result = (Program.prefix("what    ...  did you say?? ")=="27,5:what    ...  did you say?? ");

            //Assert.Pass(result, "Returned null given null");
            Assert.IsTrue(result, "Did not Return correctly");
        }
    }
}