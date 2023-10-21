// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] sourceArray = { "Hello", "2", "world", ":-)" };
string[] newArray = FormingNewArray(size:DeterminingSizeNewArray(sourceArray), sarray:sourceArray);
PrintArray(snarray:sourceArray);
PrintArray(snarray:newArray);


int DeterminingSizeNewArray(string[] sarray)
{
    int length = 0;
    foreach (string element in sarray)
        if (element.Length <= 3) length++;

    return length;
}

string[] FormingNewArray(int size, string[] sarray)
{
    int position = 0;
    string[] threeArr = new string[size];
    for (int i = 0; i < sarray.Length; i++)
    {
        if (sarray[i].Length <= 3)
        {
            threeArr[position] = sarray[i];
            position++;
        }
    }

    return threeArr;
}

void PrintArray(string[] snarray)
{
    Console.Write("[");
    Console.Write(string.Join(", ", snarray));
    Console.WriteLine("]");
}