namespace _5_3
{
   
       public enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }

   
    public class Point
    {
       
        public double X { get; set; }
        public double Y { get; set; }
        public PointColor Color { get; set; }

       
        public Point()
        {
            X = 0;
            Y = 0;
            Color = PointColor.LightBlue; // Gán màu mặc định
        }

        
        public Point(double x, double y, PointColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        // 4. Phương thức hiển thị trạng thái (thông tin) của điểm
        public void HienThiThongTin()
        {
            Console.WriteLine($"Tọa độ: ({X}, {Y}) | Màu sắc: {Color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ in tiếng Việt có dấu

            // Khởi tạo các điểm bằng Constructor có tham số
            Point p1 = new Point(5.5, 10.2, PointColor.BloodRed);
            Point p2 = new Point(-3.0, 7.0, PointColor.Gold);
            
            // Khởi tạo điểm bằng Constructor mặc định
            Point p3 = new Point(); 

            // Hiển thị trạng thái các điểm
            Console.WriteLine("--- THÔNG TIN CÁC ĐIỂM ---");
            p1.HienThiThongTin();
            p2.HienThiThongTin();
            p3.HienThiThongTin();

            Console.ReadLine();
        }
    }
    
}
