using System;
using System.IO;
using System.Collections.Generic;
using Conversor.Models;

namespace Conversor.Services
{
    public class WriteFile : IWriteFile
    {
        String IWriteFile.WriteFile(List<Log> listOfLogs, String fileName)
        {
            string[] filNameArr = fileName.Split("/");
            // Set a variable to the Documents path.
            string docPath = Path.Combine(
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), filNameArr[1]);
            // Creates the directory if it doesn't exist.
            Directory.CreateDirectory(docPath);

            string docPathSave = Path.Combine(docPath, filNameArr[2]);
            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(docPathSave))
            {
                String localDate = DateTime.Now.ToString();
                outputFile.WriteLine("# Version: 1.0");
                outputFile.WriteLine("# Date: " + localDate);//15/12/2017 23:01:06 
                outputFile.WriteLine("# Fields: provider http-method status-code uri-path time-taken response-size cache-status:");

                foreach (Log log in listOfLogs)
                {
                    outputFile.WriteLine(log.Provider1 + " " + log.HttpMethod1 + " " + log.StatusCode1 + " " +
                        log.UriPath1 + " " + log.TimeTaken1 + " " + log.ResponseSize1 + " " + log.CacheStatus1);
                }
            }
            return docPathSave;
        }
    }
}
