namespace chuaBaiTap;

public class HT : hinh2D
{
    public double banKinh;

    public override void nhap()
    {
        Console.Write("ban kinh = ");
        this.banKinh = double.Parse(Console.ReadLine());
    }

    public override void hienThi()
    {
        Console.WriteLine("Ban kinh: " + this.banKinh);
        Console.WriteLine("CV: " + this.chuVi);
        Console.WriteLine("DT: " + this.dienTich);
    }

    public override void tinhChuVi()
    {
        this.chuVi = 2 * this.banKinh * Math.PI;
    }

    public override void tinhDienTich()
    {
        this.dienTich = Math.PI * Math.Pow(this.banKinh, 2);
    }
}