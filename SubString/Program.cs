using System;

namespace SubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testString = "this is some string to use it for our example.";

            string partWithoutLength = testString.Substring(10);
            string partWithLength = testString.Substring(5, 10);

            //Console.WriteLine(partWithoutLength);
            //Console.WriteLine(partWithLength);

            int charPosition = testString.IndexOf('i');
            //Console.WriteLine(charPosition);

            int stringPosition = testString.IndexOf("some");
            //Console.WriteLine(stringPosition);

            int charPosWithStartIndex = testString.IndexOf('s', 10);
            //Console.WriteLine(charPosWithStartIndex);

            int lastPosition = testString.LastIndexOf('o');
            //Console.WriteLine(lastPosition);

            int stringLastPosition = testString.LastIndexOf("is");
            //Console.WriteLine(stringLastPosition);

            bool containsResult = testString.Contains("for");
            //Console.WriteLine(containsResult);

            bool startsWithResult = testString.StartsWith("is");
            //Console.WriteLine(startsWithResult);

            bool endWithResult = testString.EndsWith("example.");
            //Console.WriteLine(endWithResult);

            string lowerdString = testString.Remove(10);
            //Console.WriteLine(lowerdString);

            string loweredStringWithCount = testString.Remove(10, 9);
            //Console.WriteLine(loweredStringWithCount);

            string stringWithInsert = testString.Insert(13, "Updated ");
            //Console.WriteLine(stringWithInsert);

            string lowerCaseString = testString.ToLower();
            //Console.WriteLine(lowerCaseString);

            string upperCaseString = testString.ToUpper();
            Console.WriteLine(upperCaseString);

            Console.ReadKey();
        }
    }
}
