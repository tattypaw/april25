using System;
using System.Data;
using System.IO;
using System.Security;

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
                throw new Exception("Пустой путь к файлу");
            }
            _path = path;
        }

        private void WriteToFile(string message)
        {
            try
            {
                using (var file = new StreamWriter(_path, true)) ;
                file.WriteLine(message);
            }
            catch (UnauthorizedAccessException)
            {
                throw new Exception("Отказано в доступе");
            }
            catch (ArgumentException)
            {
                throw new Exception("Параметр path пуст или содержит имя системного устройства");
            }
            catch (DirectoryNotFoundException)
            {
                throw new Exception("Указан недопустимый путь");
            }
            catch (IOException)
            {
                throw new Exception("Параметр включает неверный или недопустимый синтаксис");
            }
            catch (PathTooLongException)
            {
                throw new Exception("Указанный путь слишком длинный");
            }
            catch (SecurityException)
            {
                throw new Exception("Отсутствуют необходимые разрешения");
            }
            catch (Exception)
            {
                throw new Exception("Неизвестная ошибка");
            }
        }

        public void LogInfo(string message)
        {
            WriteToFile($"{DateTime.Now:u} INFO {message}");
        }
        
        public void LogError(string message)
        {
            WriteToFile($"{DateTime.Now:u} ERROR {message}");
        }
        
        public void LogSuccess(string message)
        {
            WriteToFile($"{DateTime.Now:u} SUCCESS {message}");
        }
        
        public void LogWarning(string message)
        {
            WriteToFile($"{DateTime.Now:u} WARNING {message}");
        }
        public void LogCustom(string type, string message)
        {
            WriteToFile($"{DateTime.Now:u} {type} {message}");
        }
    }
}