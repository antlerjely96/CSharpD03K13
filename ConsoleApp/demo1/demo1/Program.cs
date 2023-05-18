// See https://aka.ms/new-console-template for more information

//Nhập số a. Kiểm tra a là âm hay dương

//Khai báo a
int a;
//Hiển thị dòng chữ a =
Console.Write("a = ");
//Nhập a
a = int.Parse(Console.ReadLine());
//Kiểm tra a
if (a > 0)
{
    Console.WriteLine(a + " la so duong");
}
else if (a < 0)
{
    Console.WriteLine(a + " la so am");
}
else
{
    Console.WriteLine(a + " la so khong duong khong am");
}
