/* Итоговая контрольная работа по основному блоку

Написать программу, которая из имеющегося массива строк формирует новый массив 
из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Console.WriteLine("Hello, World!");


[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System.Security.Principal;

string[] srcArray = new string[]{"Hello", "2", "world", ":-)"};
//["1234", "1567", "-2", "computer science"]
//["Russia", "Denmark", "Kazan"] 


string [] selectArray(string[] wrkArray){
    string[] resArray = Array.Empty<string>();
    foreach (string text in wrkArray)
    {
        if (text.Length<=3)
        {
            Array.Resize(ref resArray, resArray.Length+1);
            resArray[resArray.Length-1] = text;
        }
    }
    return resArray;
}

void showArray(string[] wrkArray){
    Console.WriteLine("Формируем массив из строк, длина которых меньше, либо равна 3 символам.");
    foreach (string i in wrkArray)
    {
        Console.WriteLine(i);
    }
}

showArray(selectArray(srcArray));