
namespace Teglatest_Teszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeglaTest Tt = new TeglaTest();
            Console.WriteLine("Add meg a test méreteit");
            Console.WriteLine("A:");
            
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("B:");

            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("C:");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine($"Térfogat: {Tt.Terfogat(A,B,C)} \n Felszín: {Tt.Felszin(A,B,C)}, \ns Átló: {Math.Round(Tt.Atlo(A,B,C))}");
            Console.ReadLine();
        }

     
        
    }
}