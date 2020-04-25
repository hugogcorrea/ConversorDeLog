using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using Conversor.Services;
using Conversor.Tests.Service;

namespace Conversor.Tests
{
    [TestClass]
    public class ReadFileTest
    {

        [TestMethod]
        public void If_ReadFile_ReturnElements()
        {
            //Arrange
            String url = "https://s3.amazonaws.com/uux-itaas-static/minha-cdn-logs/input-01.txt";
            string line;
            StringBuilder testLog = new StringBuilder();
            ServiceTest svc = new ServiceTest();
            StringBuilder logReal = svc.GenerateLog();

            //Act
            IReadFile read = new ReadFile();
            Stream resStream = read.Read(url);
            StreamReader reader = new StreamReader(resStream);
            while ((line = reader.ReadLine()) != null)
            {
                testLog.AppendLine(line);
            }

            //Assert
            Assert.AreEqual(testLog.ToString(), logReal.ToString());

        }

    }
}
