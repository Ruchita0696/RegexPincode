namespace Regex_Pincode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter pincode :");
            long pin = Convert.ToInt64(Console.ReadLine());
            RegexPattern.Pattern(pin);

        }
    }
}