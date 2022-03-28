using System;
using System.IO;

namespace Generics
{
    public class LocalFileLogger<T> : ILogger
    {
        string _path;

        public LocalFileLogger(string path)
        {
            _path = path;
        }
        public void LogInfo(string message)
        {
            File.AppendAllText(_path, $"[Info] : [{typeof(T).Name}] : {message}\n");
        }

        public void LogWarning(string message)
        {
            File.AppendAllText(_path, $"[Warning] : [{typeof(T).Name}] : {message}\n");
        }

        public void LogError(string message, Exception ex)
        {
            File.AppendAllText(_path, $"[Error] : [{typeof(T).Name}] : {message}.{ex.Message}");
        }
    }
}