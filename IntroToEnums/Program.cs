namespace IntroToEnums
{
    internal class Program
    {
        enum Day
        {
            Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat
        }

        enum CardValue
        {
            Two = 2,
            Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Jack, Queen, King, Ace
        }

        enum Suit
        {
            Heart, Diamond, Club, Spade
        }


        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                CardValue cardValue = (CardValue)rnd.Next(2, 15);
                Suit suit = (Suit)rnd.Next(4);

                Console.WriteLine(cardValue + " of " + suit);
            }


            //Console.Write("Enter day number (1-7): ");
            //Day day = (Day)int.Parse(Console.ReadLine());

            //Console.WriteLine("\nIt is " + day);
        }
    }
}
