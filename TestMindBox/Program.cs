using MindBoxLibrary;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Задайте длину массива и нажмите Enter:");
            int nLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Задайте число m(m<n) и нажмите Enter:");
            int mPart = int.Parse(Console.ReadLine());
            EnterData data = new EnterData(nLength, mPart);
            data.Calculate();
            Console.WriteLine();
        } while (true);
    }
}