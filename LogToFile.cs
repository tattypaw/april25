using System;

namespace april25
{
    public class LogToFile
    {
        private string _path;

        public LogToFile()
        {
            _path = "log.log";
        }
        public LogToFile(string path)
        {
            if (path == string.Empty)
            {
                throw new Exception("Пустой путь к файлу")
            }
            _path = path;
        }
    }
}