using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using WebApplication1;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_sayJenkins_1()
        {
            TextClass testClass = new TextClass();
            string result = testClass.sayJenkins(3);
            Assert.AreEqual("Jenkins Jenkins Jenkins ", result);
        }
        [Test]
        public void Test_sayJenkins_2()
        {
            TextClass testClass = new TextClass();
            string result = testClass.sayJenkins(1);
            Assert.AreEqual("Jenkins ", result);
        }
    }
}