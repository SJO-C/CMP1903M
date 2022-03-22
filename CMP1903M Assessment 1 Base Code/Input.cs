using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.Write("Please Input Text at the Prompt> ");
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            
            {
                text = File.ReadAllText(fileName);
                //using (var sr = new StreamReader(fileName))
                //{
                //    // Read the stream as a string, and write the string to the console.
                //    Console.WriteLine("Text File as Found:");

                //    Console.WriteLine(sr.ReadToEnd());

                //    text = sr.ReadToEnd();
             

            }
       

            return text;
        }

    }
}
