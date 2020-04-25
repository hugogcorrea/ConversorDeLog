using System;
using System.Collections.Generic;
using Conversor.Models;

namespace Conversor.Services
{
    public interface IWriteFile
    {
        public String WriteFile(List<Log> listOfLogs, String fileName);
    }
}
