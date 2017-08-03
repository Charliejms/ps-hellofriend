using Microsoft.VisualStudio.TestTools.UnitTesting;
using ps_hellofriend.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubSub;

using System.Collections.Generic;


namespace ps_hellofriend.Controllers.Tests
{
    [TestClass()]
    public class HelloFriendControllerTests
    {
        //using Albite.Test;
        //using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
        //private readonly Test.CollectionTest _test = new Test.CollectionTest();
        [TestMethod()]
        public void IndexTest()
        {

            HelloFriendController controller = new HelloFriendController();
            this.Publish(controller);
            Assert.IsTrue(true);

        }

        [TestMethod()]
        public void DetailsTest()
        {

            List<string> first = new List<string>();
            first.Add("0");

            List<string> second = new List<string>();

            second.Add("0");
            CollectionAssert.AreEqual(first,second);
            //Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CreateTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CreateTest1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void EditTest()
        {


            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void EditTest1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest1()
        {
            Assert.Fail();
        }
    }
}