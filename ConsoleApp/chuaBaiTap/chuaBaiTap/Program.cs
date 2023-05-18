// See https://aka.ms/new-console-template for more information

using chuaBaiTap;

public class Program
{
    public static void Main()
    {
        HCN[] hcn = new HCN[3];
        for (int i = 0; i < 3; i++)
        {
            hcn[i] = new HCN();
            Console.WriteLine("Nhap thong tin hcn thu " + (i+1));
            hcn[i].nhap();
            hcn[i].tinhChuVi();
            hcn[i].tinhDienTich();
        }
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Thong tin hcn thu " + (i + 1));
            hcn[i].hienThi();
        }
        Console.WriteLine("=========================================");
        HV[] hv = new HV[4];
        for (int i = 0; i < 4; i++)
        {
            hv[i] = new HV();
            Console.WriteLine("Nhap thong tin hv thu " + (i + 1));
            hv[i].nhap();
            hv[i].tinhChuVi();
            hv[i].tinhDienTich();
        }
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Thong tin hv thu " + (i + 1));
            hv[i].hienThi();
        }
        Console.WriteLine("=========================================");
        HT[] ht = new HT[5];
        for (int i = 0; i < 5; i++)
        {
            ht[i] = new HT();
            Console.WriteLine("Nhap thong tin hv thu " + (i + 1));
            ht[i].nhap();
            ht[i].tinhChuVi();
            ht[i].tinhDienTich();
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thong tin hv thu " + (i + 1));
            ht[i].hienThi();
        }
    }
}