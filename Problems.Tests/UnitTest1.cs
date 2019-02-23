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
            bool resultNUll = (Program.prefix(null)==null);
            bool resultHello = (Program.prefix("hello")=="5,1:hello");
            bool resultEmpty = (Program.prefix("")=="0,0:");
            bool resultWhat = (Program.prefix("what    ...  did you say?? ")=="27,5:what    ...  did you say?? ");

            //Assert.Pass(result, "Returned null given null");
            Assert.IsTrue(resultNUll, "Did not Return null given null");
            Assert.IsTrue(resultHello, "Did not Return null given null");
            Assert.IsTrue(resultEmpty, "Did not Return null given null");
            Assert.IsTrue(resultWhat, "Did not Return null given null");

        }
        /*[Test]
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
        }*/
    }
}