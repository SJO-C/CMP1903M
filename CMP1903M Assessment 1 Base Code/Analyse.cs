using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1903M_Assessment_1_Base_Code
{
    ////Courtsey of Michael Pakhantsov of Stack Overflow.
    //static class SqlStyleExtensions
    //{
    //    public static bool In(this string me, params string[] set)
    //    {
    //        return set.Contains(me);
    //    }
    //}
    ////END OF BORROWED CODE
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            char[] vowels = "AEIOU".ToCharArray();

            //3. Number of consonants
            string consonants = "BCDFGHJKLMNPQRSTVWXYZ";
             
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<6; i++)
            {
                values.Add(0);
            }


            //int vowelCount = 0;
            //if (vowels.In(input)){
            //    values[1]++;
            //}

            //int countVowels = 

            //var vowelsQuery =
            //    from Char in vowels
            //    join vowles in vowels on input.ToCharArray() equals vowels
            //    select new
            //    {
            //        vQ = vowles,
            //    };
            //values[1] = vowelsQuery.Count();

            Regex rxSentence = new Regex(@"^\w+[A-Za-z,;'s]+[.?!]$");
            MatchCollection matches = rxSentence.Matches(input);
            Regex rxUpper = new Regex(@"[A-Z]^\.");
            Regex rxLower = new Regex(@"[a-z]");
            Regex rxLongWord = new Regex(@"([A-Za-z]{7,})");
            Regex rxElispses = new Regex(@"(\.{3,})");
            
            
            foreach(var i in input.ToUpper())
            {
                if (i == ((char)42)) { break; }
                else if (vowels.Contains(i))
                {
                    values[1]++;
                }
                else if (consonants.Contains(i))
                {
                    values[2]++;
                }
                else if (i == ((char)46))
                {
                    if (rxElispses.IsMatch(i.ToString()))
                    {
                        ;
                    }
                    else { values[3]++; }

                }  
            }

            foreach (var j in input)
            {
                Console.WriteLine(j.ToString());
                if (rxUpper.IsMatch(j.ToString()) == true)
                {
                    values[3]++;
                }
                else if (rxLower.IsMatch(j.ToString()) == true)
                {
                    values[4]++;
                }
                else if (rxLongWord.IsMatch(j.ToString()) == true)
                {
                    values[5]++;
                }

            }




            //Converts the String to an Array of Bytes.
            //byte[] inputASCII = Encoding.ASCII.GetBytes(input);
            ////Loops through the Array of Bytes and if the Byte is in the range of a Capital Letter, Increments the 
            ////Capital Letter Counter by 1 or if it is in the range of a Lower Case, it increments the Lower Case Counter
            ////by 1.
            //foreach (var j in inputASCII)
            //{
            //    int inputASCII2Int = BitConverter.ToInt32(inputASCII, 0);
            //    if (inputASCII2Int == 42) { break; }
            //    else if (inputASCII2Int >= 65 && inputASCII2Int <= 90)
            //    {
            //        values[3]++;
            //    }
            //    else if (inputASCII2Int >= 92 && inputASCII2Int <= 122)
            //    {
            //        values[4]++;
            //    }

            //}


            //DEBUG
            //Console.WriteLine("Sentence Count TBC." + values[0]);
            //Console.WriteLine("Vowel Count? " + values[1]);
            //Console.WriteLine("Consonants Count TBC." + values[2]);
            //Console.WriteLine("Upper-Case Count TBC. " + values[3]);
            //Console.WriteLine("Lower-Case Count TBC. " + values[4]);


       

            return values;
        }
    }
}
//IDictionary<stringint> analyseText = new Dictionary<stringint>();

//char[] alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXY".ToCharArray();
////foreach (char element in alfabeto)
////{

////}



