// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine($"{i + 1}. " + msg);
//         i++;
//     }
// }

// Method2(msg: "Test2");
// Method21(count: 5, msg: "Test21");

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// Console.WriteLine(Method3());

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = "";
//     while(i < count)
//     {
//         result += text;
//         i++;
//     }
//     return result;
// }


// string Method4(int count, string text)
// {
//     string result = "";
//     for(int i = 0; i < count; i++)
//         result += text;

//     return result;
// }

// Console.Write(Method4(count: 5, text: "Hello"));


// for (int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {(i * j)}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


// string Replace(string text, char oldChar, char newChar)
// {
//     string newText = "";
//     for(int i = 0; i < text.Length; i++)
//     {
//         if(text[i] == oldChar)
//             newText += newChar;
//         else
//             newText += text[i];
//     }    
//     return newText;
// }

// string testText = "— Я думаю, — сказал князь, улыбаясь, — что,"
//                 + "ежели бы вас послали вместо нашего милого Винценгероде,"
//                 + "вы бы взяли приступом согласие прусского короля."
//                 + "Вы так красноречивы. Вы дадите мне чаю?";


// string editedText;
// editedText = Replace(testText, ' ', '-');
// editedText = Replace(editedText, 'к', 'К');
// editedText = Replace(editedText, 'с', 'С');

// Console.WriteLine(testText);
// Console.WriteLine(editedText);

int[] arr = { 1, 4, 4, 3, 2, 6, 7, 1 };

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
                minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);