namespace demoClass;

//Khai báo abstract class dongVatTrenCan kế thừa interface dongVat
public abstract class dongVatTrenCan : dongVat
{
    //Khai báo thuộc tính số chân
    public int soChan;
    //Override abstract method keu
    public abstract void keu();
    public abstract void keu(String tiengKeu);
}