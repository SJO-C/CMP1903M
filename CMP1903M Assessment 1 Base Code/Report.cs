using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public Boolean outputConsole(List<int> values, Boolean ENyOrn)
        {
            try
            {
                if ((ENyOrn == true) ^ (ENyOrn == null)){//Outputs the Count of the measured metrics.

                
                    Console.WriteLine("Sentence Count." + values[0]);
                    Console.WriteLine("Vowel Count " + values[1]);
                    Console.WriteLine("Consonants Count." + values[2]);
                    Console.WriteLine("Upper-Case Count. " + values[3]);
                    Console.WriteLine("Lower-Case Count. " + values[4]);
                    Console.WriteLine("Long Word Count (<=7). " + values[5]);
                }
                else
                {//Outputs the Above Data in Esperanto.
                    Console.WriteLine("Nombro de Frazoj." + values[0]);
                    Console.WriteLine("Nombro de Vokaloj " + values[1]);
                    Console.WriteLine("Nombro de Konsonantoj. " + values[2]);
                    Console.WriteLine("Nombro de Majusklaj Literoj " + values[3]);
                    Console.WriteLine("Nombro de Minusklaj Literoj " + values[4]);
                    Console.WriteLine("Nombro de Granda Vortoj " + values[5]);


                }
                return true;

            }
            catch (Exception ex)//In the Event of any error on the Report, False is returned to indicate to the main program that report was not successful in running.
            {
                return false;
            }
        }

    }
}
