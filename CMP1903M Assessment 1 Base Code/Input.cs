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
            Console.Write("Please Input Text at the Prompt> ");//User 
            text = Console.ReadLine();//Reads User Input up to 1st Newline Character.
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("No text entered, using default string: 'nothing'");
                text = "nothing";
                return text;
            }
            else
            {
                return text;
            }
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            {
                if (fileName != null)
                {
                    try
                    {
                        text = File.ReadAllText(fileName); //Reads Text of File from Path provided.
                        //Checks if file is long, if so, asks if user wants it outputted.
                        int numLines = text.Split('\n').Length; //Thanks StackOverflow for this bit. https://stackoverflow.com/questions/11189331/how-to-count-lines-in-a-string
                        if (numLines > 15)
                        {
                            Console.Beep();
                            Console.WriteLine("This file looks to have a lot of lines in, are you sure you want to print it out on screen? (y/N)");
                            char longChoice = Console.ReadKey().KeyChar;
                            if (longChoice == 'y')
                            {
                                Console.WriteLine(text);//Outputs the Text for to confirm the text is what is wanted by the user.
                            }
                            else {; }

                        }
                        else
                        {
                            Console.WriteLine(text);
                        }
                         
                    }
                    catch (IOException)//Handles when the File Path is un-proccessable.
                    {
                        Console.Beep();
                        Console.WriteLine("File Open NOT Working.\nSwitching to Manual Mode.");
                        manualTextInput();
                    }
                    catch (ArgumentException
                    {
                        Console.Beep();
                        Console.WriteLine("File Path Erroneous or Not Entered.\nSwitching to Manual Mode.");
                        manualTextInput();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }


                }
                return text;
        }

    }
}
