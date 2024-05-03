internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so a, b va c");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0 && c == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            } else if (b == 0 && c != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            } else
            {
                float x = -c *1.0f / b;
                Console.WriteLine("Phuong trinh co nghiem la x = " + x);
            }
        } else
        {
            int delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo ngiem");
            } else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep x = " + (-b * 1.0f / (2 * a)));
            } else
            {
                Console.WriteLine($"Phuong trinh co nghiem x1 = {(-b + Math.Sqrt(delta))/(2 * a)} , x2 = {(-b - Math.Sqrt(delta))/(2 * a)}");
            }
        }
    }
}