// See https://aka.ms/new-console-template for more information
string[] array = new string[5] {"city", "qx", "hello", "world", "res"};
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array[count] = array[i];
        count++;
        }
    }
Console.Write($"{array[i]} ");
