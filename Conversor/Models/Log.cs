using System;
using System.Collections.Generic;
using System.Text;


namespace Conversor.Models
{
    public class Log
    {

        private String Provider;
        private String HttpMethod;
        private int StatusCode;
        private String UriPath;
        private int TimeTaken;
        private int ResponseSize;
        private String CacheStatus;

        public Log(string provider, string httpMethod, int statusCode, string uriPath, int timeTaken, int responseSize, string cacheStatus)
        {
            this.Provider = provider;
            this.HttpMethod = httpMethod;
            this.StatusCode = statusCode;
            this.UriPath = uriPath;
            this.TimeTaken = timeTaken;
            this.ResponseSize = responseSize;
            this.CacheStatus = cacheStatus;
        }

        public string Provider1 { get => Provider; set => Provider = value; }
        public string HttpMethod1 { get => HttpMethod; set => HttpMethod = value; }
        public int StatusCode1 { get => StatusCode; set => StatusCode = value; }
        public string UriPath1 { get => UriPath; set => UriPath = value; }
        public int TimeTaken1 { get => TimeTaken; set => TimeTaken = value; }
        public int ResponseSize1 { get => ResponseSize; set => ResponseSize = value; }
        public string CacheStatus1 { get => CacheStatus; set => CacheStatus = value; }
    }
}
