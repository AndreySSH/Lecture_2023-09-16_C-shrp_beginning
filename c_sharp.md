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

int[] array = {1,12,53,24,52,6,47,18};
array.Length - отдает длинну массива
int[] array = new int[10];
new int[]{x,y,z} - отдает массив составленный из переменных x,y,z


Math.Round(d,2);
Math.Pow(d,2);

Math.Round(lenght,2);
Math.Round(lenght,2,MidpointRounding.ToZero);

using System.Globalization; //добавить глобально
CultureInfo.CurrentCulture = new CultureInfo("en-US");  //добавить в метод Main
//для вывода в т.ч. точки вместо запятой в разделителе дробных чисел.
