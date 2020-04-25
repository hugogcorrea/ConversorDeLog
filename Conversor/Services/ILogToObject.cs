using System;
using System.Collections.Generic;
using Conversor.Models;

namespace Conversor.Services
{
    public interface ILogToObject
    {
        public List<Log> LogToObj(IReadFile read, String url);
    }
}
