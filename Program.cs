Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
double x = i % 2;
while (i <= N)
{
    if (x == 0)
        {
        Console.Write(i + " ");
        i++;
        }
    else
        {
        i++;
        }
}

// int[] numbers = new int[N] {};
// int index = 0;
// numbers[index] = i;

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Введите третье число");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[3] {num1, num2, num3};
// int index = 0;
// int max = 0;
// while (index < 3)
// {
//     if (numbers[index] > max)
//         {
//             max = numbers[index];
//             index++;
//         }
// }
// Console.WriteLine("Максимальное число: " + max);