# Logging (april25) - система логирования событий в файл

## API

Для работы с системой логирования используется класс 'LogToFile'

### Конструкторы

- 'LogToFile()' конструктор по умолчанию задает значение имени файла как "log.log"
- 'LogToFile(string path)' конструктор с параметром пути файла - 'path'. Параметр имеет тип 'string' 

### Методы

-LogInfo Метод записи информационных сообщений
-LogError Метод записи сообщений об ошибке
-LogSuccess Метод записи сообщений об успехе
-LogWarning Метод записи сообщений предепреждений
-LogCustom Метод записи информационных сообщений пользователя



