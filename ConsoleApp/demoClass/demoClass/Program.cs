// See https://aka.ms/new-console-template for more information

using demoClass;

public class Program
{
    public static void Main()
    {
        dongVatHaiChan conCho = new dongVatHaiChan();
        conCho.soChan = 4;
        conCho.setTen("con cho");
        Console.WriteLine("Loai: cho, ten: " + conCho.getTen());
        Console.WriteLine("So chan: " + conCho.soChan);
    }
}