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
            _path = path;
        }
    }
}