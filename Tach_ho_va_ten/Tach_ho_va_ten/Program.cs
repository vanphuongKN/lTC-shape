namespace Tach_ho_va_ten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vo Van Phuong 2415053122230");
            Console.WriteLine("Nhap ho ten");
            string fullName = Console.ReadLine();
            if (string.IsNullOrEmpty(fullName))
            {
                Console.WriteLine(("khong tach"));
            }
            string[] words = fullName.Split([' '], StringSplitOptions.RemoveEmptyEntries);
            if (words == null || words.Length == 0)
            {
                Console.WriteLine("mang kh duoc null");
            }
            else
            {
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}