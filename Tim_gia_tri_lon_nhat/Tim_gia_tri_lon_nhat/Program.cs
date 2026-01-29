namespace Tim_gia_tri_lon_nhat
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
                return;
            }
            int[] numbers = new int[n];
            if (numbers == null) {
                Console.WriteLine("mang chua khoi tao");
            }
            for (int i = 0; i < n; i++) {
                Console.Write($"Nhap phan tu thu {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            for (int i = 1; i < n; i++) {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"gia tri lon nhat: {max}");
        }
    }
}
