//  Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28

/*
// N1 задаем размер масива, вводим цифры вручную
int[] num = new int[5];
for(int i=0;i<num.Length;i++)
{
   Console.WriteLine(string.Format("Введите {0}й элемент массива:",i+1));
   num[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
    for (int i = 0; i <num.Length / 2; i++)
    {
        sum += num[i] * num[num.Length - 1 - i];
    }
    Console.WriteLine($"сумма произведений пар: {sum}"); 

 */
 // N2 задаем размер масива, цифры Рандом 
 Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i <numbers.Length / 2; i++)
    sum += numbers[i] * numbers[numbers.Length - 1 - i];

    Console.WriteLine($"сумма произведений пар:{sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}