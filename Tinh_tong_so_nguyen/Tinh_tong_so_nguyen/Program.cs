namespace Tinh_tong_so_nguyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vo Van Phuong 2415053122230");
            Console.WriteLine("Nhap so phan tu n:");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("hay nhap so phan tu");
            }
            int[] numbers = new int[n];
            if (numbers == null)
            {
                Console.WriteLine("Mang chua khoi tao");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"nhap pt thu {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0;i < numbers.Length; i++) {
                sum += numbers[i];
                }
            Console.WriteLine($"Tpng la: {sum}");
        }
    }
}
