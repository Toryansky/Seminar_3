// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        var Number = Convert.ToString(Console.ReadLine());

        void VerifyNumber(string number)
        {
            if (Number[0] == Number[4] || Number[1] == Number[3])
            {
                Console.WriteLine($"Число {Number} - палиндром.");
            }
            else Console.WriteLine($"Число {Number} - не палиндром.");
        }

        if (Number!.Length == 5)
        {
            VerifyNumber(Number);
        }
        else Console.WriteLine($"Введите пятизначное число");
    }
}
