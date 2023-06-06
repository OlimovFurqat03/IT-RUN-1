namespace First_prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            int dic = b * b - (4 * a * c);
            
        if (dic > 0)
        {
            double x1 = (-b - Math.Sqrt(dic)) / (2 * a);
            double x2 = (-b + Math.Sqrt(dic)) / (2 * a);
            Console.WriteLine("x1=" + x1);
            Console.WriteLine("x2=" + x2);
        }
            if (dic == 0)
            {
                int x = (-b / (2 * a));
                Console.WriteLine("x=" + x);
            }
                if (dic < 0)    
                {
                    Console.WriteLine("У этого уровнения нет решения потому что дискриминант меньще 0");
                }
        }
    }
}