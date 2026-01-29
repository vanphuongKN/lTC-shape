namespace Dem_so_chuoi_trong_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vo Van Phuong 2415053122230");
            string[] danhSach = { "vovanphuong", null, "", "Lap trinh c#", null, "", "sagfdchhtdr" };
            int count = 0;
            foreach (string s in danhSach)
            {
                if (s != null && s != "")
                {
                    count++;
                }
            }
            Console.WriteLine($"so phan tu khac null và khac rong: {count}");

        }
    }
}
