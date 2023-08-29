using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Main method to test your functions.'
            int[] array = { 1, 7, 20, 3, 2 };
            //Console.WriteLine(Add(5, 5));
            //Console.WriteLine(IsEven(3));
            // Console.WriteLine(MaxOfThree(10,3,2));
            // Console.WriteLine(StringLength("Gavin"));
            //Console.WriteLine(StartsHello("HelloGavin"));
            //Console.WriteLine(ReverseString("Gavin"));
            // Console.WriteLine(Factorial(5));
            //Console.WriteLine(IsPrime(15));

            //Console.WriteLine(LargestInArray(array));
            //Console.WriteLine(ArraySum(array));
            //Console.WriteLine(CharCount("Martineeeeee", 'e'));
            //Console.WriteLine(ConcatenateStrings("Hello", "World"));
            Console.WriteLine(SwapEnds("Gavin"));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            // TODO: Implement this method.
            int answer = 0;

            answer = a + b;
            return answer;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            // TODO: Implement this method.

            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.



            int high = Math.Max(a, b);
            int high1 = Math.Max(b, c);

            int answer = Math.Max(high, high1);



            return answer;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            int stringLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                stringLength++;
            }
            return stringLength;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            // TODO: Implement this method.

            if (s.StartsWith("Hello"))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            // TODO: Reverse the charArray.

            Array.Reverse(charArray);

            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            // TODO: Calculate the factorial.
            int num = n;



            for (int i = n - 1; i > 0; i--)
            {
                num *= i;

            }


            return num;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            int check = 0;
            if (number <= 1) return false;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    check++;
                }
            }

            // TODO: Return the correct boolean value.
            if (check == 2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            // TODO: Calculate the nth Fibonacci number.
            return 0;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            // TODO: Determine if the string is a palindrome.
            return false;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            char[] charArray = s.ToCharArray();
            int count = 0;
            // TODO: Count how many times character c appears in string s.
            for(int i = 0; i < s.Length; i++)
            {
                if(charArray[i] == c)
                {
                    count++;
                }
            }

            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            // TODO: Concatenate the two strings with a space in between.
            
            string str = str1 + " " + str2;

            

            return  str;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            // TODO: Swap the first and last characters and return the modified string.

            string replaced = s.Replace(firstChar,lastChar);
           
            return replaced;
        }
    }
}
