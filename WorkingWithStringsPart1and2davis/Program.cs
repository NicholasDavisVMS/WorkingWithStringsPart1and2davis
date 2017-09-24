using System;

namespace WorkingWithStringsPart1and2davis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //There are a number of applications that work with text and other data types
            //so string manipulation is vital skill

            //Where to find file on hard drive, with backslash
            // string mySting = "go to your c:\\ drive";
            //string myString = "My \"so called\" life ";
            //string myString = "What if I need \n a new line?";
            //string myString = string.Format("{0}!", "Bonzai"); The '{}' will substituate a 
            //string into another string with replacement characters
            //Can put multiple strings into a string, see below,
            //string myString = string.Format("Make:D {0} (Model:D {1})", "BMW", "760li");
            //Format can also format numbers
            //string myString = string.Format("{0:C}", 123.45);
            //The :C will format the number as currency, here US currency
            //string myString = string.Format("{0:N}", 123456789);
            //:N will put commas and two decimals with period in the number automatically
            //string myString = string.Format("{0:P}", .123);
            //:P will make number a percent with percenage sign
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);
            //Pound symbol(#) can be used for phone numbers and the like
            //but be careful since too big a number will print improper number, extra values 
            //will be at the beginning

            //Console.WriteLine(myString);
            //Console.ReadLine();

            //There is a squigly line with a '\' because it is used to denote a folder on a
            //file system; and the backslash is an escape character that is used to 
            //create other special characters and commands. Have to do 2 '\'

            //To embed a quotation inside a string: use backslash before quotations
            //The '\n' will move rest of string to next line
            //There a a number of excape sequences available which are very helpful

            ////PART 2!!!!
            /// How to manipulate strings

            string myString = " That summer we took threes across the board ";

            //myString = myString.Substring(5, 14);
            //Substring will cut/pull inside string from a start(5) with a number of characters(14)
            //myString = myString.ToUpper();
            //toUpper will make string all upper case, great for when you don't want capitalization
            //to be an issue when comparing things
            //myString = myString.Replace(" ", "--");
            //Replace will place all of one+ character and replace them with another 1+ characters
            //(space to 2 dashes). Great of quickly changing values
            myString = String.Format("Length before:D {0} -- After: {1}", 
                                     myString.Length, myString.Trim().Length);
            //the Trim will trim off any extra space at beginning & end of string
            //Since trim will return a new string, you can chain it with the next property of Length
            //Great for using less code
            //Length will give use the length of the string in a number
            Console.WriteLine(myString);
            Console.ReadLine();

            //these are only a small number of all possible string manipulations
        }
    }
}
