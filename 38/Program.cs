//Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] InputArray(int number)
{
    double[] result = new double[number];
    Random random = new Random();
    for(int i=0;i<number;i++)
    {
        result[i]=Math.Round(random.NextDouble(), 2);
    }
    return result;
}

void OutputArray(double[] Arr)
{
    int N = Arr.Length;
    for(int i=0;i<N;i++)
    {
        if(i==0) Console.Write("[" + Arr[i]);
        else Console.Write("; " + Arr[i]);
    }
    Console.Write("]");
}

double Max(double[] Array)
{
    double result = Array[0];
    int count = Array.Length;
    for(int i=1;i<count;i++)
    { 
        if(Array[i]>result) result = Array[i];
    }
    return result;

}

double Min(double[] Array)
{
    double result = Array[0];
    int count = Array.Length;
    for(int i=1;i<count;i++)
    { 
        if(Array[i]<result) result = Array[i];
    }
    return result;
}

double DifferenceMaxMin(double[] Array)
{  
    double result = Max(Array) - Min(Array);
    return result;
}

Console.WriteLine("Введите количество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
double[] Array = InputArray(number);
OutputArray(Array);
Console.Write(" -> " + DifferenceMaxMin(Array));