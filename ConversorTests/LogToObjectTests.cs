using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Moq;
using Conversor.Tests.Service;
using Conversor.Services;
using Conversor.Models;


namespace Conversor.Tests
{
    [TestClass]
    public class LogToObjectTests
    {
        [TestMethod]
        public void If_LogToObj_IsOk()
        {
            //ARRANGE
            String url = "test";
            var mock = new Mock<IReadFile>();
            ServiceTest svc = new ServiceTest();
            StringBuilder content = svc.GenerateLog();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content.ToString()));
            mock.Setup(library => library.Read(url)).Returns(ms);

            // ACT
            ILogToObject service = new LogToObject();
            List<Log> listOfLogs = service.LogToObj(mock.Object, url);

            // ASSERT
            mock.Verify(library => library.Read(url), Times.AtMostOnce());
            Assert.AreEqual(listOfLogs.Count, 4);

        }

    }
}
