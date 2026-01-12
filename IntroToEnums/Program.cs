namespace IntroToEnums
{
    internal class Program
    {
        enum Day
        {
            Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat
        }

        static void Main(string[] args)
        {
            Console.Write("Enter day number (1-7): ");
            Day day = (Day)int.Parse(Console.ReadLine());

            Console.WriteLine("\nIt is " + day);
        }
    }
}
