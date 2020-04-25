using System;
using Conversor.Services;

namespace Conversor
{
    class Inicialize
    {
        static void Main()
        {
              Console.WriteLine("teste");
            string cmd = Console.ReadLine();

            IReadWriteFile readWrite = new ReadWriteFile();
            String ret = "Log file save at:" + readWrite.Inicialize(cmd);
            Console.WriteLine(ret);
        }
    }
}
