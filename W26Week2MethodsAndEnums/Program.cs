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

            ChangeValues(num, str, arr);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("arr[0] = " + arr[0]);
        }

        static void ChangeValues(int n, string s, int[] a)
        {
            n = 100;
            s = "bye";
            a[0] = 100;
        }
    }
}
