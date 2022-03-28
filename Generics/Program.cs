using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFileLogger<int> log1 = new LocalFileLogger<int>("logs.txt");
            LocalFileLogger<string> log2 = new LocalFileLogger<string>("logs.txt");
            LocalFileLogger<bool> log3 = new LocalFileLogger<bool>("logs.txt");

            log1.LogInfo("Information");
            log2.LogWarning("Warning!");
            log3.LogError("ERROR", new IndexOutOfRangeException());
        }
    }
}
