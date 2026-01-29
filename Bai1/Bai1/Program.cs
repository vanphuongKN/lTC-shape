namespace Bai1
{
    internal class Program
    {
            static void Main()
            {
                Console.Write("Nhap ho ten: ");
                string hoTen = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(hoTen))
                {
                    Console.WriteLine(" Chuoi ho ten khong duoc đe trong!");
                    return;
                }

              string[] cacTu = hoTen.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string hoTenChuanHoa = "";

                for (int i = 0; i < cacTu.Length; i++)
                {
                    string tu = cacTu[i];
                    string tuMoi = tu.Substring(0, 1).ToUpper() + tu.Substring(1).ToLower();
                    hoTenChuanHoa += tuMoi;
                    if (i < cacTu.Length - 1)
                    {
                        hoTenChuanHoa += " ";
                    }
                }

                Console.WriteLine($"Ho ten chuan hoa: {hoTenChuanHoa}");
            }
        }
    }
