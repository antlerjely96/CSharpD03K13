// See https://aka.ms/new-console-template for more information

//Nhập mảng có n phần tử là số nguyên. Tính tổng các phần tử

//Khai báo n
int n;
//Nhập n
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
//Khai báo mảng số nguyên có n phần tử
int[] arr = new int[n];
//Nhập mảng
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Khai báo biến tong
int tong = 0;
//Tính tổng các phần tử
for (int i = 0; i < n; i++)
{
    tong += arr[i];
}
//Hiển thị tổng
Console.WriteLine("Tổng các phần tử của mảng: " + tong);