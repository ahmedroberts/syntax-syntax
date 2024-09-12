namespace RaikageAhmed1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1,  2, 3, 4, 5 };
            var sum = numbers.Sum();

            Console.WriteLine("Hello, XRDS!");
            Console.WriteLine(sum);

            Console.WriteLine($"\n\nSo the sum was {sum} of {numbers}.\n\n");

            /* Collection Initializers */
            string[] oldStooges = new string[] { "Moe", "Larry", "Curly" };  // Old Way
            
            foreach (var s in oldStooges)
            {
                Console.WriteLine(s);
            }

            /* 
             * C# 12
             * .NET 8
             * Collection Expressions &
             * spread operators
             * 
             * Spread operator allows the collection to reference other collections
             * and that all values from the referenced collections should be used to initalize
             * that collection.
             * 
             */

            string[] twoStooges  = ["Moe", "Larry"];
            string[] moreStooges = ["Curly", "Shump"];
            string[] fourStooges = [.. twoStooges, .. moreStooges]; // Collection Spread Operator

        }
    }
}
