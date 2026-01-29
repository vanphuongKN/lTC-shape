using System.Runtime.CompilerServices;

namespace ktchuoidoixung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi");
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("khong co chuoi");


            }
            string chuoiKhongSpace = input.Replace(" ", "");

            bool laDoiXung = true;
            int doDai = chuoiKhongSpace.Length;
            for (int i = 0; i < doDai / 2; i++)
            {
                if (chuoiKhongSpace[i] != chuoiKhongSpace[doDai - 1 - i])
                {
                    laDoiXung = false;
                    break;
                }
            }

            if (laDoiXung)
                Console.WriteLine("chuoi doi xung");
            else
                Console.WriteLine("khong doi xung");
        }
    }
}
