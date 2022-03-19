using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string consonants = "BCDFHJKLMNPQRSTVWXYZ";
             
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }


            //int vowelCount = 0;
            //if (vowels.In(input)){
            //    values[1]++;
            //}

            //int countVowels = 

            var vowelsQuery =
                from Char in vowels
                join vowles in vowels on input.ToCharArray() equals vowels
                select new
                {
                    vQ = vowles,
                };

            

            values[1] = vowelsQuery.Count();
            



            //DEBUG
            Console.WriteLine("Sentence Count TBC." + values[0]);
            Console.WriteLine("Vowel Count? " + values[1]);
            Console.WriteLine("Consonats Count TBC." + values[2]);
            Console.WriteLine("Upper-Case Count TBC" + values[3]);
            Console.WriteLine("Lower-Case Count TBC" + values[4]);


       

            return values;
        }
    }
}
//IDictionary<stringint> analyseText = new Dictionary<stringint>();

//char[] alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXY".ToCharArray();
////foreach (char element in alfabeto)
////{

////}



