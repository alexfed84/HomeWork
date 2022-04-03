
string[] array = new string[5] {"city", "qx", "hello", "world", "res"};
string[] array1 = new string[array.Length];
int res = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3);
        {
        array1[res] = array[i];
        res++;
        }
    }
Console.Write($"{res} ");



