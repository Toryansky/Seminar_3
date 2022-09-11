// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите координату x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату z1: ");
        int z1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату z2: ");
        int z2 = Convert.ToInt32(Console.ReadLine());

        double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            return distance;
        }
        Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2));
    }
}