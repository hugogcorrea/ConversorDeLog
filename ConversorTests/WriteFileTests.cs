using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using Conversor.Models;
using Conversor.Services;
using Conversor.Tests.Service;

namespace Conversor.Tests
{
    [TestClass]
    public class WriteFileTests
    {

        [TestMethod]
        public void If_WriteFile_IsOK()
        {
            //ARRANGE
            ServiceTest svc = new ServiceTest();
            List<Log> listOfLogs = svc.GenerateListOfLogs();
            String fileName = "./output/test.txt";

            // ACT
            IWriteFile service = new WriteFile();
            String docPathSave = service.WriteFile(listOfLogs, fileName);
            string text = File.ReadAllText(@docPathSave);

            // ASSERT
            Assert.AreEqual(text, svc.GenerateFinalLog().ToString());

        }

      

    }
}
