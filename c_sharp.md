# C#

90 - 00 аналог java vm - .net

язык - инструмент

*надо учиться программированию, а не синтаксису языка*

надо научиться мыслить алгоритмически

программиств пишут код и воплощают алгоритм на языкае программирования


_3 слоя:_
* интерфейс (gui, cli)
* логика
* данные

Программа: входные данные -> оработка алгоритмом -> входные данные

Надо набросать алгоритм в виде блок схеммы.

## Пишем Hello World


## Настройка VS Code

autosave

## .net
 
* dotnet new console - создать в текущем каталоге новый пустой проект консольного приложения
* dotnet run - компиляция и запуск

## Шаблон кнсольной программы

class Program{
    static void Main(string[] args){

    }
}

## Описание методов классов

класс Console:
Write(string);
WriteLine(string);
string Read();

new Random().Next(min, max) - int random number from min to max-1

$"{number} -> {square}" - аналог f-string в python

тернарный оператор {condition} ? {if true} : {if false}

#define в C# не может объявлять константы