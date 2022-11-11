// очищаем консоль
Console.Clear(); 
// спрашиваем у пользователя размер массива
Console.WriteLine("Введите размермерость массива ");
// узнали размер массива
int size  = Convert.ToInt32(Console.ReadLine());

// создаем новый пустой массив с точным кол-вом элементов
string[] arrayString = new string[size];
  for (int i=0; i<size; i++)
{
  Console.WriteLine($"Введите {i+1}-й элемент: ");
  string element = Convert.ToString(Console.ReadLine()??"");
  arrayString[i] = element;
}
// Создаем массив 
string[] arrayTotal = new string[size];
int len = 3;
int pos = 0;
  for (int j=0; j<size; j++)
{
  if (arrayString[j].Length<=len)
  {
    arrayTotal[pos] = arrayString[j]; // разбор по позициям
    pos++;
  }
  Console.Write("");
}
 
PrintArray(arrayTotal);
// метод печати массива
void PrintArray(string[] array)
{
  for (int i=0; i<array.Length;i++)
  {
    Console.Write(array[i] + " ");    
  }
}


