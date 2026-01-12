namespace W26Week2MethodsAndEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string str = "hello";
            int[] arr = { 1, 2, 3 };

            Console.WriteLine("Before changes:");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("arr[0] = " + arr[0]);

            ChangeValues(ref num, str, arr);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("arr[0] = " + arr[0]);
            Console.WriteLine("\n\n");

            // output paramaters example
            int rad = 5;
            double area, circum;

            AreaAndCircum(rad, out area, out circum);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Circum = " + circum);
        }

        // output parameters
        static void AreaAndCircum(int r, out double area, out double circum)
        {
            area = Math.PI * r * r;
            circum = 2 * Math.PI * r;
        }



        static void ChangeValues(ref int n, string s, int[] a)
        {
            n = 100;
            s = "bye";
            a[0] = 100;
        }
    }
}
