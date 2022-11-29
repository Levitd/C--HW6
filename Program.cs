using System;
using static System.Console;

Clear();


//Задача 41
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

try
{
    WriteLine("Введите через пробел массив: ");
    int[] Array = GetArrayString(ReadLine());

    WriteLine($"[{String.Join(",", Array)}]");

    WriteLine($"Элементов больше 0:  {PositivInArray(Array)}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}

//Создание массива из строки, элементы через пробел
int[] GetArrayString(string strangArray)
{
    string[] nums = strangArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(nums[i]);
    }
    return result;
}
//Подсчет кол-ва элементов больше 0
int PositivInArray(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

//---------------------------------------------------------------------------------------------------------------
//Задача 43
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//x=(b2-b1)/(k1-k2)
//y=k1*x+b1

/*

try
{
    WriteLine("Ищем точку пересечения двух прямых заданных уравнениями y = k1 * x + b1 и y = k2 * x + b2");
    WriteLine("Введите через пробел числа b1 k1 b2 k2: ");
    decimal[] Array = GetDecArrayString(ReadLine());

    WriteLine($"{String.Join(" ", Array)}");

    decimal[] pointOfCross = getPointOfCross(Array);

    WriteLine($"Пересекутся в точке: {String.Join(" ", pointOfCross)}");

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}

//Создание массива из строки, элементы через пробел
decimal[] GetDecArrayString(string strangArray)
{
    string[] nums = strangArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    decimal[] result = new decimal[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToDecimal(nums[i]);
    }
    return result;
}
//Решение уравнения
decimal[] getPointOfCross(decimal[] a)
{   //0  1  2  3
    //2  5  4  9
    //b1 k1 b2 k2
    //x=(b2-b1)/(k1-k2)
    //y=k1*x+b1
    decimal[] xy = new decimal[2];
    xy[0] = Math.Round(((a[2] - a[0]) / (a[1] - a[3])),2);
    xy[1] = Math.Round(a[1] * xy[0] + a[0],2);
    return xy;

}
*/
/*
// --------------------------------------------------------------------------------------------------------------------
//задание из чата.
//из массива удалить элементы, встречающиеся более 2-х раз


int[] DelArray(int[] inArray, int coldel)
{
    //сколько элементов встречается не более, чем coldel раз
    int newSize=0;
    for (int i = 0; i < inArray.Length; i++)
    {
        int cs=countNum(inArray, inArray[i]);
        if (cs<=coldel && cs!=0) newSize++;
    }

    //новый массив без "лишних цифр"
    int[] newArray = new int [newSize];
       int x=0; 
    for (int i = 0; i < inArray.Length; i++)
    {
        int cs=countNum(inArray, inArray[i]);
        if (cs<=coldel && cs!=0) {
            newArray[x]=inArray[i];
            x++;
        }
    }
    return newArray;
}

//Создание массива размером N элементов, полученных рандомно в указанном диапазоне
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int countNum(int[] inArray, int num)
{
    int count = 0;
    foreach (var item in inArray)
    {
        if (item == num) count++;
    }
    return count;
}


try
    {

        Write("Введите размер массива ");
        int N = Convert.ToInt32(ReadLine());
        int min = 5;
        int max = 10;
        int coldel=2; // сколько раз допустимо встретить число в массиве

        int[] newArray = GetArray(N, min, max);
        WriteLine("Исходный массив:");
        WriteLine($"[{String.Join(",", newArray)}]");

        WriteLine($"Массив без часто встречающихся элементов (более {coldel} раз):");
        int[] delArray = DelArray(newArray, coldel);
        WriteLine($"[{String.Join(",", delArray)}]");
   
}
    catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}

catch
{
    Write("Ошибка выполнения!");
}
*/

