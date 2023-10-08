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

### Console::
Write(string);
WriteLine(string);
string Read();

### Math::

Pow(d,2);
Round(d, 2);
Round(d, 2, MidpointRounding.ToZero);

### Random::

Random rnd = new Random();
rnd.Next(min, max) - int random number from min to max - 1 -> [min, max)
rnd.NextDouble() * (max - min) + min - float random number from min to max -> [min, max]

### Convert::

int ToInt32(string);

### int::

int int.Parse(string);


## Языковые структуры

#### Строки

1. $"{number} -> {square}" - интераолированные строки (аналог f-string в python)
2. $"{(double):F2}" float с 2мя знаками после запятой
3. Строковые литералы verbatim @"C:\Test\Test1\"; - не интерпретирует  '\' как начало спецсимвола


### Тернарный оператор
{condition} ? {if true} : {if false}

//#define в C# не умеет объявлять константы

### Массивы

int[] array = new int[8];
int[] array1 = {1, 2, 3, 4, 5, 6, 7, 8};
int[] array2 = new int[8]{1, 2, 3, 4, 5, 6, 7, 8};
int[] array3 = new int[]{1, 2, 3, 4, 5, 6, 7, 8};

var array4 = new int[]{1, 2, 3, 4, 5, 6, 7, 8};

var ttt = 6/4;

array.Length - отдает длинну массива
int[] array = new int[10];
new int[]{x,y,z} - отдает массив составленный из переменных x,y,z

### Многомерные массивы

var[,] array = new string[2, 5];

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Test2"); - указание имени аргумента при вызове метода

int sum;
checked
{
    sum += i;
} - кидает исключение, если происходит в том числе переполнение int

### Однострочные методы

bool IsEven(int value)
{
    return value % 2 == 0;
}
         |
         V
bool IsEven(int value) => value % 2 == 0;
         |
         V
var IsEven = (int v) => v % 2 == 0;


## Полезности

using System.Globalization; //добавить глобально
CultureInfo.CurrentCulture = new CultureInfo("en-US");  //добавить в метод Main
//для вывода в т.ч. точки вместо запятой в разделителе дробных чисел.

(int a = 12;) var a = 12;
Console.WriteLine(a.GetType()); -> System.Int32

## Как клучшить свой код

1. Имена переменных
1. Имена методов
1. Имена аргументов

*Код чаще читают, чем пишут*

*Не использовать хитрые сокращения кроме общепринятых*

*Не использовать запрещенные слова*

*Не надо сокращать, там где это не требуется. Ex:*
1. GetWin vs GetWindow
1. SendPM(int i, string t) vs SendPrivatMessage(int id, string text)
1. ConvertToUnsignedChar vs ConvertToByte

*Переносить длинные строки (ex: длина строки не превышает 100 символов)*

*Автоформатирование в VS Code: Alt-Shift-F*

b == false -> !b

GetStreamAsync() - для асинхронных методов




