# ConsoleReader2
Консольное приложение на C#, которое на вход принимает большой текстовый файл (например можно взять отсюда http://az.lib.ru/). На выходе создает текстовый файл с перечислением всех уникальных слов встречающихся в тесте и количеством их употреблений, отсортированный в порядке убывания количества употреблений.

## Описание кода

```c#
    string inputText = "tolstoj_lew_nikolaewich-text_0040.fb2";
```

В переменной `inputText` находится точное имя файла который неходится в `\bin\Debug\net6.0\`. Если необходимо выбрать файл из другого места, тогда необходимо указать точный путь до этого файла и точное имя файла.
 - - -

```c#
    string result = "dict.txt";
```

В переменной `result` находится название файла который создастся при первом запуске, в котором будет содержаться словарь уникальных слов которые встречаются в тексте, а также их кол-во в тексте. 
> Если указать только название файла и его расширение, тогда файл создастся в `\bin\Debug\net6.0\`. Также можно в переменную `result` указать точный путь в какой папке необходимо создать данный файл. 
> > Если путь к файлу после первого запуска программы остался неизменным, тогда файл перезапишется.
