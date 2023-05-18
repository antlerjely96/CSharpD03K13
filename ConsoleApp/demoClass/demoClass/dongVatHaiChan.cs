namespace demoClass;

//Khai báo class dongVatHaiChan kế thừa abstract class dongVatTrenCan
public class dongVatHaiChan : dongVatTrenCan
{
    private string ten;
    
    //getter lay du lieu cua thuoc tinh ten
    public string getTen()
    {
        return this.ten;
    }
    //setter de luu du lieu vao thuoc tinh ten
    public void setTen(string ten)
    {
        this.ten = ten;
    }
    
    public override void keu()
    {
        Console.WriteLine("Keu");
    }

    public override void keu(string tiengKeu)
    {
        
    }
}