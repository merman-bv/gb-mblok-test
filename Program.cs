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

Console.WriteLine("Формируем массив из строк, длина которых меньше, либо равна 3 символам.");
string[] resultArray = Array.Empty<string>();
foreach (string i in srcArray)
{
string text = "";
    if (i.Length<=3)
    {
        text = i;//text = i.Substring(0, 3);
        Array.Resize(ref resultArray, resultArray.Length+1);
        resultArray[resultArray.Length-1] = text;
    }
    //Console.WriteLine(text);
}
foreach (string i in resultArray)
{
    Console.WriteLine(i);
}