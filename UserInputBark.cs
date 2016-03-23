using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetB
{
    class UserInputBark
    {
        
        
        

        List<string> wordList = new List<string>();
        public string choice;
        public bool found;

    
        public UserInputBark()
        {
            wordList.Add(" ");
        }
        public void GetUserInput()
        {
            Console.WriteLine("Please enter a unique word");
            choice = Console.ReadLine();
           
        }

        public void CompareWords()
        {
            
            foreach (string word in wordList)
            {
                if (choice == word)
                {
                    found = true;
                    Console.WriteLine("Bark!!");
                    Console.Beep();
                    break;
                }
                else
                {
                    found = false;
                    
                }

            }

            if (found == false)
            {
                Console.WriteLine("Good Word!");
                wordList.Add(choice);
            }
        }

        }
    }

