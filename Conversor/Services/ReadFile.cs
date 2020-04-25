using System;
using System.IO;
using System.Net;

namespace Conversor.Services
{
    public class ReadFile : IReadFile
    {

        Stream IReadFile.Read(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            // execute the request
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // we will read data via the response stream
            Stream resStream = response.GetResponseStream();
            return resStream;
        }
    }
}
