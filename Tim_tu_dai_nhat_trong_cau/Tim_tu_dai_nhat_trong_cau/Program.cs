namespace Tim_tu_dai_nhat_trong_cau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vo Van Phuong 2415053122230");
            Console.WriteLine("Nhap vao mot cau:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("chuoi null hoac rong");
            }
            string[] words = input.Split([' '], StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0) return;
            string longesword = words[0];
            foreach (string word in words)
            {
                if (word.Length > longesword.Length)
                {
                    longesword = word;
                }
            }
            Console.WriteLine($"tu dai nhat: {longesword} do dai {longesword.Length} ");

        }

    }
}
