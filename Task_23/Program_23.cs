// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        CubeTheNumber(Number);

        void CubeTheNumber(int anyNumber)
        {
            int count = 1;
            while (count <= Math.Abs(anyNumber))
            {
                Console.WriteLine($"Куб числа {count} = {count * count * count}");
                count++;
            }
        }
    }
}