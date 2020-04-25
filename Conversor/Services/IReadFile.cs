using System;
using System.IO;
using System.Net;

namespace Conversor.Services
{
    public interface IReadFile
    {
        public Stream Read(String url);

    }
}
