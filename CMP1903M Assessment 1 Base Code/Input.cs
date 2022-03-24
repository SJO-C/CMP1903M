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
            Console.Write("Please Input Text at the Prompt> ");//User Prompt
            text = Console.ReadLine();//Reads User Input up to 1st Newline Character.
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            {
                text = File.ReadAllText(fileName); //Reads Text of File from Path provided.
                Console.WriteLine(text); //Outputs the Text for to confirm the text is what is wanted by the user.
            }
            return text;
        }

    }
}
