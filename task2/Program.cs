
int[] array = new int [3];
int count = array.Length;
for (int index = 0; index < array.Length; index = index + 1)
{
    Console.WriteLine ($"Введите элемент массива под индексом: {index}:\t ");
    array[index] = Convert.ToInt32(Console.ReadLine());
}


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int result = Max(array[0], array[1], array[2]);

Console.WriteLine(result);



