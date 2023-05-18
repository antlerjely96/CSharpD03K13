namespace chuaBaiTap;

public class HV : hinh2D
{
    public double canh;

    public override void nhap()
    {
        Console.Write("Nhap canh: ");
        this.canh = double.Parse(Console.ReadLine());
    }

    public override void hienThi()
    {
        Console.WriteLine("Canh: " + this.canh);
        Console.WriteLine("CV: " + this.chuVi);
        Console.WriteLine("DT: " + this.dienTich);
    }

    public override void tinhChuVi()
    {
        this.chuVi = this.canh * 4;
    }

    public override void tinhDienTich()
    {
        this.dienTich = Math.Pow(this.canh, 2);
    }
}