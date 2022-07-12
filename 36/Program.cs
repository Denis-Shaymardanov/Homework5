//Задача 36: Задайте одномерный массив, заполненный случайными числами
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] InputArray(int number)
{
    int[] result = new int[number];
    Random random = new Random();
    for(int i=0;i<number;i++)
    {
        result[i]=random.Next(-1000,1000);
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

int SumOfElementsWithNotEvenPosition(int[] Arr)
{
    int N = Arr.Length;
    int result = 0;
    for(int i=0;i<N;i++)
    {
        if (i%2!=0) result = result + Arr[i];
    }
    
    return result;
}

int[] Array = InputArray(4);
OutputArray(Array);
Console.Write(" -> " + SumOfElementsWithNotEvenPosition(Array));