using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PostikaAO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Артем";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqua1
            Assert.AreEqual("Привет..., Артем", res);
        }
    }
}
