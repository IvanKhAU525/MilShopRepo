using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MilShop.Domain.Abstract;
using System.Collections.Generic;
using MilShop.Domain.Entities;
using MilShop.WebUI.Controllers;
using System.Reflection;

namespace MilShop.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IShopRepository> mock = new Mock<IShopRepository>();
            mock.Setup(x => x.Snikers).Returns(new List<Sniker>());
            mock.Setup(x => x.Sizes).Returns(new List<Size>());
            mock.Setup(x => x.Colors).Returns(new List<Color>());

            NavController nav = new NavController(mock.Object);

            nav.Menu();
        }

        [TestMethod]
        public void TestMethod2()
        {
            TestClass testClass = new TestClass() { Prop1 = new Class1(),
            Prop2 = new Class2(), Prop3 = new Class3()};
            var propCol = testClass.GetType().GetProperties();
            var prop = propCol[0].GetValue(testClass);
            prop.GetType().GetProperty("Prop").SetValue(prop, 23);

            Assert.AreEqual(23, testClass.Prop1.Prop);
        }

        [TestMethod]
        public void TestingHomeController()
        {
            Mock<IShopRepository> mock = new Mock<IShopRepository>();
            mock.Setup(x => x.Snikers).Returns(new List<Sniker> { new Sniker() { Id = 0, Color = 2, ModelName = "model1", Size = 23, Price = 234, Count = 20 } });

            HomeController controller = new HomeController(mock.Object);
            var objects = controller.Index("Snikers");
            Assert.AreEqual(2, 2);
        }
    }

    #region testclass
    public class TestClass
    {
        public Class1 Prop1 { get; set; }
        public Class2 Prop2 { get; set; }
        public Class3 Prop3 { get; set; }
    }

    public class Class1
    {
        public int Prop { get; set; }
    }

    public class Class2
    {
        public int Prop { get; set; }
    }

    public class Class3
    {
        public int Prop { get; set; }
    }
    #endregion
}
