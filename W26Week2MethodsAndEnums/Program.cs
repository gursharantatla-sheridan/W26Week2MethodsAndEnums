using System.Xml.Serialization;

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
            //double area, circum;

            AreaAndCircum(rad, out double area, out double circum);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Circum = " + circum);
            Console.WriteLine("\n\n");



            //Console.Write("Enter a number: ");
            ////int n;

            //if (int.TryParse(Console.ReadLine(), out int n))
            //    Console.WriteLine("n = " + n);
            //else
            //    Console.WriteLine("Invalid input, please try again");

            //Console.WriteLine("\n\n");



            // parameter arrays
            int a = 4, b = 6;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine("a = {0} b = {1}", a, b);


            int[] myArr = { 3, 45, 6, 8, 6, 5, 43, 3 };
            PrintArray(myArr);
            PrintArray(3, 4, 5, 6, 76, 8, 9, 87, 76, 65, 5, 4, 3, 4, 5, 66, 7, 6, 8);



            PersonInfo("John", 23);
            PersonInfo(name: "John", age: 23);
            PersonInfo(age: 32, name: "John");
            PersonInfo("John");
        }


        // named arguments / optional args
        static void PersonInfo(string name, int age = 18)
        {
            // method body
        }



        // parameter array
        static void PrintArray(params int[] arr)
        {
            Console.WriteLine("\nNumber of items: " + arr.Length);

            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
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
