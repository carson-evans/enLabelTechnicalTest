using System;
using System.Collections.Generic;
using System.Linq;
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


            // C# Part 2 
            /*
             * Edit the GetTrueCount function so that it returns the count  of strings in an array that will evaluate as "true" when cast to a boolean variable.
             */
            string[] truthArray = new string[] { "0", "", "true", "Foobar", "False", "1", "True", "test", "1", "FALSE" };
            int count = GetTrueCount(truthArray);


            // C# Part 3
            /* 
             * Edit the CompressString function so that it returns a compressed version of a string by 
             * replacing repeated characters with that character and then a count of repeated characters. 
             * For instance the string "aaaabbccccdddeeeef" should return "a4b2c4d3e4f1". 
             */
            string uncompressedInput = "aaaabbccccdddeeeef";
            string compressedOutput = CompressString(uncompressedInput);
            Console.WriteLine(compressedOutput);

            // C# Part 4
            /*
             * The ClearList1 and ClearList2 functions were created to remove all elements from a List object.
             * After some testing we have determined that these functions cause different results.
             * Explain why these functions cause different behavior.
             */
            /*
             * Insert explaination here:
             * 
             * 
             * 
             * 
             */
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
            string output = string.Empty;
            return output;
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
    }
}

 