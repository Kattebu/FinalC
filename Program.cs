// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

string[] firstArray = new string[6] {"=)", "cats", "321", "44", "!", "@#$&"};
string[] secondArray = new string[firstArray.Length];

void GetResultArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i=0; i<firstArray.Length; i++)
    {
        if (firstArray[i].Length<=3)
        {
            secondArray[count]=firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
  for (int i=0; i<array.Length; i++)  
  {
    Console.Write($"{array[i]}" + " ");
  }
  Console.WriteLine();
}

GetResultArray(firstArray, secondArray);
PrintArray(secondArray);

