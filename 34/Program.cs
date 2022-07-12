//Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] InputArray(int number)
{
    int[] result = new int[number];
    Random random = new Random();
    for(int i=0;i<number;i++)
    {
        result[i]=random.Next(100,1000);
    }
    return result;
}

void OutputArray(int[] Arr)
{
    int N = Arr.Length;
    for(int i=0;i<N;i++)
    {
        if(i==0) Console.Write("[" + Arr[i]);
        else Console.Write("," + Arr[i]);
    }
    Console.Write("]");
}

int CountEven(int[] Arr)
{
    int N = Arr.Length;
    int result = 0;
    for(int i=0;i<N;i++)
    {
        if (Arr[i]%2==0) result++;
    }
    
    return result;
}

int[] Array = InputArray(4);
OutputArray(Array);
Console.Write(" -> " + CountEven(Array));
