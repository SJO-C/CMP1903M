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
            try
            {
                text = File.ReadAllText(fileName);

            }
            catch (FileNotFoundException)
            {
                Console.Write("File NOT Found: Please re-enter your File Path. > ");
                fileName = Console.ReadLine();
                fileTextInput(fileName);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path Not Valid.");
                Console.Write("Please re-enter your File Path. > ");
                fileName = Console.ReadLine();
                fileTextInput(fileName);

            }

            return text;
        }

    }
}
