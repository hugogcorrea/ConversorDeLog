using System;
using System.Collections.Generic;
using Conversor.Models;

namespace Conversor.Services
{
    public class ReadWriteFile : IReadWriteFile
    {      

        String IReadWriteFile.Inicialize(String cmd)
        {
            string[] cmdArr = cmd.Split(" ");
            IReadFile read = new ReadFile();
            IWriteFile write = new WriteFile();
            ILogToObject logToObject = new LogToObject();
            IReadWriteFile readWrite = new ReadWriteFile();
            List<Log> listOfLogs = logToObject.LogToObj(read,cmdArr[1]);
            String pathSaved = write.WriteFile(listOfLogs, cmdArr[2]);
            return pathSaved;
        }

    }
}
