using System.Runtime.CompilerServices;

class EquilateralTriangleArea
{
    enum color
    {
        red, green, blue
    }

    static void Main()
    {

        /*
        static int W = 160;
        static int H = 60;
        static float x1 = -3.0f;
        static float x2 = 3.0f;
        static float y1 = -0.10f;
        static float y2 = 1.2f;

        static int II(float x)
        {
            return (int)(0 + (x - x1) * W / (x2 - x1));
        }
        static int JJ(float y)
        {
            return (int)(0 + (y - y2) * H / (y1 - y2)); 
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(W, H);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            float h = (x2 - x1) / W;
            float x = x1 - h;

            for (int i = 0; i < H; i++)
            {
                Console.SetCursorPosition(II(0), i);
                Console.Write('|');
            }
            for (int i = 0; i < W; i++)
            {
                x = x + h;
                Console.SetCursorPosition(II(x), JJ(0));
                Console.Write('-');
                float y = (float)Math.Exp(-x * x);
                int b = JJ(y);
                if (b >= 0 && b < H)
                {
                    Console.SetCursorPosition(II(x), b);
                    Console.Write("*");
                }
            }
            Console.ReadKey();
            */

        Console.WriteLine("Введите периметр равностороннего треугольника: ");
        float perimeter = float.Parse(Console.ReadLine());
        float halfOfPerimeter = perimeter / 2;
        float side = perimeter / 3;
        float result = MathF.Sqrt(halfOfPerimeter * MathF.Pow(halfOfPerimeter - side, 3));
        Console.WriteLine("{0,-13} {1,-13}", "Сторона:", "Площадь:");
        Console.WriteLine("{0,-13:N2} {1,-13:N2}", side, result);
        Console.ReadLine();
    }
}
    
