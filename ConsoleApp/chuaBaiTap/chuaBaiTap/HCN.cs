namespace chuaBaiTap;

public class HCN : hinh2D
{
    public double chieuDai;
    public double chieuRong;

    public override void nhap()
    {
        Console.Write("Nhap chieu dai: ");
        this.chieuDai = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong: ");
        this.chieuRong = double.Parse(Console.ReadLine());
    }

    public override void hienThi()
    {
        Console.WriteLine("CD: " + this.chieuDai);
        Console.WriteLine("CR: " + this.chieuRong);
        Console.WriteLine("CV: " + this.chuVi);
        Console.WriteLine("DT: " + this.dienTich);
    }

    public override void tinhChuVi()
    {
        this.chuVi = (this.chieuDai + this.chieuRong) * 2;
    }

    public override void tinhDienTich()
    {
        this.dienTich = this.chieuDai * this.chieuRong;
    }
}