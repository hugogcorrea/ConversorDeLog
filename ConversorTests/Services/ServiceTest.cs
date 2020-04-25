using System;
using System.Text;
using System.Collections.Generic;
using Conversor.Models;

namespace Conversor.Tests.Service
{
    public class ServiceTest
    {

        public StringBuilder GenerateLog()
        {
            StringBuilder testLog = new StringBuilder();
            testLog.AppendLine("312|200|HIT|\"GET /robots.txt HTTP/1.1\"|100.2");
            testLog.AppendLine("101|200|MISS|\"POST /myImages HTTP/1.1\"|319.4");
            testLog.AppendLine("199|404|MISS|\"GET /not-found HTTP/1.1\"|142.9");
            testLog.AppendLine("312|200|INVALIDATE|\"GET /robots.txt HTTP/1.1\"|245.1");

            return testLog;
        }
        public List<Log> GenerateListOfLogs()
        {
            List<Log> listOfLogs = new List<Log>();
            Log log1 = new Log("\"MINHA CDN\"", "GET", 200, "/robots.txt", 312, 100, "HIT");
            Log log2 = new Log("\"MINHA CDN\"", "POST", 200, "/myImages", 101, 319, "MISS");
            Log log3 = new Log("\"MINHA CDN\"", "GET", 404, "/not-found", 199, 142, "MISS");
            Log log4 = new Log("\"MINHA CDN\"", "GET", 200, "/robots.txt", 312, 245, "REFRESH_HIT");
            listOfLogs.Add(log1);
            listOfLogs.Add(log2);
            listOfLogs.Add(log3);
            listOfLogs.Add(log4);

            return listOfLogs;
        }

        public StringBuilder GenerateFinalLog()
        {
            StringBuilder testLog = new StringBuilder();
            testLog.AppendLine("# Version: 1.0");
            String dt = DateTime.Now.ToString();
            testLog.AppendLine("# Date: " + dt);
            testLog.AppendLine("# Fields: provider http-method status-code uri-path time-taken response-size cache-status:");
            testLog.AppendLine("\"MINHA CDN\" GET 200 /robots.txt 312 100 HIT");
            testLog.AppendLine("\"MINHA CDN\" POST 200 /myImages 101 319 MISS");
            testLog.AppendLine("\"MINHA CDN\" GET 404 /not-found 199 142 MISS");
            testLog.AppendLine("\"MINHA CDN\" GET 200 /robots.txt 312 245 REFRESH_HIT");

            return testLog;
        }
    }
}
