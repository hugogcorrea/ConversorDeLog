using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Conversor.Tests.Service;
using Conversor.Services;

namespace Conversor.Tests
{
    [TestClass]
    public class ReadWriteFileTests
    {
        [TestMethod]
        public void If_LogToObj_IsOk()
        {
            //ARRANGE
            String cmd = "convert https://s3.amazonaws.com/uux-itaas-static/minha-cdn-logs/input-01.txt ./output/minhaCdn1.txt";
            ServiceTest svc = new ServiceTest();

            // ACT
            IReadWriteFile service = new ReadWriteFile();
            String docPathSave = service.Inicialize(cmd);
            string text = File.ReadAllText(@docPathSave);

            // ASSERT
            Assert.AreEqual(text, svc.GenerateFinalLog().ToString());

        }
    }
}
