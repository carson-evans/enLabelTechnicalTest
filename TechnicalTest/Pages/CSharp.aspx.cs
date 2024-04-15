using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechnicalTest.Pages
{
    public partial class CSharp : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // C# Part 1 - Put code to change the label's text here
            lblCSharpPart1.Text = "Text has been changed!";

            // C# Part 2 
            /*
             * Edit the GetTrueCount function so that it returns the count  of strings in an array that will evaluate as "true" when cast to a boolean variable.
             */
            string[] truthArray = new string[] { "0", "", "true", "Foobar", "False", "1", "True", "test", "1", "FALSE" };
            int trueCount = GetTrueCount(truthArray);
            Console.WriteLine($"Count of 'true' values: {trueCount}");

            // C# Part 3
            /* 
             * Edit the CompressString function so that it returns a compressed version of a string by 
             * replacing repeated characters with that character and then a count of repeated characters. 
             * For instance the string "aaaabbccccdddeeeef" should return "a4b2c4d3e4f1". 
             */
            string uncompressedInput = "aaaabbccccdddeeeef";
            string compressedOutput = CompressString(uncompressedInput);
            Console.WriteLine($"Compressed string: {compressedOutput}");

            // C# Part 4
            /*
             * The ClearList1 and ClearList2 functions were created to remove all elements from a List object.
             * After some testing we have determined that these functions cause different results.
             * Explain why these functions cause different behavior.
             */
            /*
             * Insert explaination here:
             * ClearList1 calls the Clear method on the passed List object. This method modifies the existing list by removing all its elements. 
             * As a result, any references to this list outside the ClearList1 function will point to an empty list, reflecting the changes.
             *
             * ClearList2, on the other hand, creates a new List<int> instance and assigns it to the local variable 'list'. 
             * This reassignment does not affect the original list passed to the function; it merely changes the local reference to a new, empty list.
             * Therefore, the original list remains unchanged outside of ClearList2.
             *
             * In summary, ClearList1 modifies the original list directly, while ClearList2 only changes the local reference to a new list without affecting the original.
             */

            TestGetTrueCount();
            TestCompressString();

            List<int> myList = new List<int>() { 1, 2, 3 };
            ClearList1(myList); // Clears myList
            
            List<int> myList2 = new List<int>() { 1, 2, 3 };
            ClearList2(myList2); // Clears myList2
            
            // Convert the values of myList and myList2 into strings
            string result1 = string.Join(", ", myList);
            string result2 = string.Join(", ", myList2);
            // Compare results
            if (result1 == result2)
            {
                Console.WriteLine("The values are equal!");
            }
            else
            {
                Console.WriteLine("The values are not equal");
            }
        }

        /// <summary>
        /// Write code to count the amount of strings in an array will evaluate as "true" when cast to a boolean variable.
        /// Return the count
        /// </summary>
        protected int GetTrueCount(string[] truthArray)
        {
            int count = 0;
            foreach (var value in truthArray)
            {
                bool parsed = bool.TryParse(value, out bool result) ? result : value == "1";
                if (parsed) count++;
            }
            return count;
        }



        /// <summary>
        ///  Write a function that takes a string and returns a compressed version of that string by 
        ///  replacing repeated characters with that character and then a count of repeated characters.
        ///  For instance the string "aaaabbccccdddeeeef" should return "a4b2c4d3e4f1". 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var sb = new StringBuilder();
            int count = 1;
            char last = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == last)
                {
                    count++;
                }
                else
                {
                    sb.Append(last);
                    sb.Append(count);
                    last = input[i];
                    count = 1;
                }
            }

            // Append the last set of characters
            sb.Append(last);
            sb.Append(count);

            return sb.ToString();
        }


        /// <summary>
        /// Wrapper for the List's Clear function
        /// </summary>
        /// <param name="list"></param>
        protected void ClearList1(List<int> list)
        {
            list.Clear();
        }

        /// <summary>
        /// Custom clearing function for a List
        /// </summary>
        /// <param name="list"></param>
        protected void ClearList2(List<int> list)
        {
            list = new List<int>();
        }

        // Test methods to verify functionality
        private void TestGetTrueCount()
        {
            string[] testArray = { "0", "false", "False", "FALSE", "true", "True", "TRUE", "1", "not true", "yes" };
            int result = GetTrueCount(testArray);
            Console.WriteLine($"Test GetTrueCount: Expected 4, Got {result}");
        }

        private void TestCompressString()
        {
            string testInput = "aaaabbccccdddeeeef";
            string expected = "a4b2c4d3e4f1";
            string actual = CompressString(testInput);
            Console.WriteLine($"Test CompressString: Expected {expected}, Got {actual}");
        }
    }
}

 