namespace Dem_so_pt_chan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vo Van Phuong 2415053122230");
            Console.WriteLine("nhap so phan tu");
            int n;
            if(!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("hay nhap lai so phan tu");

            }
            int[] numbers = new int[n];
            if (numbers == null) {
                Console.WriteLine("so phan tu chan là : 0");

            }
                
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"nhap phan tu {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($" So phan tu chan la : {count}");
        }
    }
}
