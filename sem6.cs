//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray=ReversArray2(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray1(array);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];

    }
    return result;
}














Console.Clear();
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int C = Convert.ToInt32(Console.ReadLine());

if (A < B + C && B < A + C && C < A + B)
{
    Console.WriteLine("треугольник может существовать");
}
else
{
    Console.WriteLine("треугольника нет");
}









// Задача 44 Не используйте рекурсию , введите .


int Nextfib(int praded, int ded)
{
    return praded + ded;
}
Console.Write("Введите первое число : ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
 array[0]= 0;
 array[1]= 1;







//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");

string[] st = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

if(IsTriangle(int.Parse(st[0]),int.Parse(st[1]),int.Parse(st[2])))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}



bool IsTriangle(int a,int b,int c)
{
    return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
}






// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int x = 1;
// while (N > 0)
// {
//     if (N % 2 == 0)
//     {
//         x++;
//         N = N / 2;
//     }
//     else
//     {
//         x++;
//         N = N / 2;
// }
// }

// int [] array = new int[x];
// int I = 0;
// while (N > 0)
// {
//     if (N % 2 == 0)
//     {
//         array[I] = 0;
//         I++;
//         N = N / 2;
//     }
//     else
//     {
//         array[I] = 1;
//         I++;
//         N = N / 2;156
// }
// }

// Console.Write(array);





