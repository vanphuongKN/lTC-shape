namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi");
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("so tu: 0");

            }
            else
            {
                string[] cacTu = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int soTu = cacTu.Length;
                Console.WriteLine($"so tu: {soTu}");
            }
        }
    }
}

