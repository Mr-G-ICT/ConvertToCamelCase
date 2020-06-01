using System;
using System.Text.RegularExpressions;

namespace ConvertToCamelCaase
{
    public class ConvertToCamel
    {
        private string StringToConvert;
        public string GetStringToConvert
        {
            //get the string we are going to convert, do not use a get 
            //method as we don't ever need to get the string
            set { StringToConvert = value; }
        }

        public string ToCamelCase()
        {
            //use a regex to split based on if it contains hypens OR it contains underscores
            string[] arraystring = Regex.Split(StringToConvert, @"(-)|(_)");
            //finalstring is what we hold the final converted name in
            //put the first word in the array into the final string as we don't edit/convert that to camel
            string finalstring = arraystring[0];

            //start looping until end of string
            for (int count = 2; count < arraystring.Length; count++)
            {
                //funky line of code that converts the first letter of the word to upper then tack that onto the end of the string
                arraystring[count] = char.ToUpper(arraystring[count][0]) + arraystring[count].Substring(1);
                //add the converted word into the final string
                finalstring = finalstring + arraystring[count];
                //we know that every other word is an underscore, so skip over the next word.(build in error checking)
                count++;
            }

            return finalstring;
        }

    }
}
