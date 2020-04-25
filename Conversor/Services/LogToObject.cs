using System;
using System.IO;
using System.Collections.Generic;
using Conversor.Models;

namespace Conversor.Services
{
    public class LogToObject : ILogToObject
    {
        List<Log> ILogToObject.LogToObj(IReadFile read, String url)
        {

            StreamReader reader = new StreamReader(read.Read(url));
            List<Log> listOfLogs = new List<Log>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lineOfLog = line.Split('|');
                string[] methodAndPath = lineOfLog[3].Split(" ");

                string provider = "\"MINHA CDN\"";
                string method = methodAndPath[0].Replace("\"", "");
                int statusCode = Convert.ToInt32(lineOfLog[1]);
                string uri = methodAndPath[1];
                int timeTaken = Convert.ToInt32(lineOfLog[0]);
                string cacheStatus = lineOfLog[2];
                int responseSize = Decimal.ToInt32(Convert.ToDecimal(lineOfLog[4].Replace(".", ",")));

                Log logExists = listOfLogs.Find(obj => obj.HttpMethod1 == method && obj.UriPath1 == uri);
                if (logExists != null)
                {
                    cacheStatus = "REFRESH_" + logExists.CacheStatus1;
                }
                Log log = new Log(provider, method, statusCode, uri, timeTaken, responseSize, cacheStatus);
                listOfLogs.Add(log);
            }
            reader.Close();
            return listOfLogs;
        }

    }
}
