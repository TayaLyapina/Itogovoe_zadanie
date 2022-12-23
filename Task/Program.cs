/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Пример
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
*/

Console.Write("Введите значение строк через пробел: "); 
string? input = Console.ReadLine();

char symbol = ' ';

string[] inputArray = input.Split(symbol, StringSplitOptions.RemoveEmptyEntries);

Console.Write($"[{String.Join("; ", inputArray)}] ->");

int size = 0; 
string[] resultArray = new string [size];

for( int i = 0; i < inputArray.Length; i++)
{
    if(inputArray[i].Length <= 3)
    {
        Array.Resize(ref resultArray, resultArray.Length + 1);
        resultArray[resultArray.Length - 1] = inputArray[i];
    }
}

if(resultArray.Length <= 0)
{
    Console.WriteLine("В массиве нет строк длина которых была бы меньше либо равна 3 символам");
}
else
Console.WriteLine($"[{String.Join("; ", resultArray)}]");

