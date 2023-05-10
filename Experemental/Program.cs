namespace Experemental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = '1';

            double db = (double)Char.GetNumericValue(ch);

            Console.WriteLine(db);
        }
    }
}