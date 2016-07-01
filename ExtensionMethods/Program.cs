namespace ExtensionMethods
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string value = "dot net tutorials";
            int nr = 5;
            nr = nr.Power();
            Console.WriteLine(nr);
           
            value = value.UppercaseFirstLetter();
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }

    public static class ExtensionMethods
    {
        public static int Power(this int number)
        {
            if (number == 0) return number;
            var power = number * number;
            return power;
        }

        public static string UppercaseFirstLetter(this string value)
        {
            //
            // Uppercase the first letter in the string.
            //
            if (value.Length <= 0) return value;

            char[] array = value.ToCharArray();
            array[0] = char.ToUpper(array[0]);
            return new string(array);
        }
    }
}
