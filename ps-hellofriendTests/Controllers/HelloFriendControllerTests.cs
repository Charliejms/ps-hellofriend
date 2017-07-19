using Microsoft.VisualStudio.TestTools.UnitTesting;
using ps_hellofriend.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubSub;


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
            Assert.IsTrue(true);
            HelloFriendController controller = new HelloFriendController();
            this.Publish(controller);

        }

        [TestMethod()]
        public void DetailsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EditTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EditTest1()
        {
            Assert.Fail();
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