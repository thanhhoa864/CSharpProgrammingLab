namespace Bai1_BTTL
{
    public class PhuongTrinhBacHai
    {
        private readonly double a, b, c;

        public PhuongTrinhBacHai(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        // Giải hx + k = 0
        private static string GiaiBacNhat(double h, double k)
        {
            if (h == 0)
                return k == 0 ? "Phương trình có vô số nghiệm"
                              : "Phương trình vô nghiệm";

            double x = -k / h + 0.0;   // +0.0 để tránh in ra "-0"
            return "Phương trình có một nghiệm: x = " + x;
        }

        public string GiaiBacNhat() => GiaiBacNhat(a, b);

        public string GiaiBacHai()
        {
            if (a == 0) return GiaiBacNhat(b, c);   // thành bx + c = 0

            double delta = b * b - 4 * a * c;

            if (delta < 0) return "Phương trình vô nghiệm";

            if (delta == 0)
                return "Phương trình có nghiệm kép: x = " + (-b / (2 * a) + 0.0);

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a) + 0.0;
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a) + 0.0;
            return "Phương trình có hai nghiệm: x1 = " + x1 + ", x2 = " + x2;
        }
    }
}