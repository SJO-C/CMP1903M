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
                if ((ENyOrn == true) ^ (ENyOrn == null)){

                
                    Console.WriteLine("Sentence Count TBC." + values[0]);
                    Console.WriteLine("Vowel Count? " + values[1]);
                    Console.WriteLine("Consonants Count TBC." + values[2]);
                    Console.WriteLine("Upper-Case Count TBC" + values[3]);
                    Console.WriteLine("Lower-Case Count TBC" + values[4]);
                }
                else
                {
                    Console.WriteLine("Nombro de Frazoj." + values[0]);
                    Console.WriteLine("Nombro de Vokaloj " + values[1]);
                    Console.WriteLine("Nombro de Konsonantoj." + values[2]);
                    Console.WriteLine("Nombro de Majusklaj Literoj" + values[3]);
                    Console.WriteLine("Nombro de Minusklaj Literoj" + values[4]);
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
