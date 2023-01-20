using System;
using PG2Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Formats.Asn1.AsnWriter;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Drawing;
using System.ComponentModel;

namespace Lab1
{

    //
    //------------Lab Notes-------------
    //      Add sections A-1 through A-7 to the Input.cs file in the PG2Input project.
    //      Add any other methods in this file.
    //      Add the menu code to the Main method.
    //

    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeters = new char[] { ',', ';', '?', '?', '!', '.', '\"', '+', '\r', '\n', '-', ' ',':' };
            char[] sentence = new char[] { '.','!','?','"' };

            string Hello = "Please Make a Selection";
            string[] MenuChoices = new string[6];

            MenuChoices[0] = "1: The Speech";
            MenuChoices[1] = "2: List of Words";
            MenuChoices[2] = "3: Show Histogram";
            MenuChoices[3] = "4: Search for a word";
            MenuChoices[4] = "5: Remove a Word";
            MenuChoices[5] = "6: Exit";

            List<string>ListofWords=Splitter(speech, delimeters);
            List<string>ListofSentences=Splitter(speech,sentence);
            string TheSpeech=GetSpeech();
            Dictionary<string,int> Counts = SpeechCounts(ListofWords);
            int choice = 0;
            while(choice!=6)
            {
                Input.GetMenuChoice(Hello, MenuChoices, out choice);
                switch(choice)
                {
                    case 1:
                        choice = 1;
                        Console.Clear();
                        Console.WriteLine(speech);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        {
                            choice = 2;
                            Console.Clear();
                            for (int i = 0; i < ListofWords.Count; i++)
                            {
                                Console.WriteLine(ListofWords[i]);
                            }
                            Console.ReadKey();
                            Console.Clear();
                                
                        }
                        break;
                    case 3:
                        choice = 3;
                        Console.Clear();
                        foreach (KeyValuePair<string, int> kvp in Counts)
                            PrintKeyValueBar(kvp.Key, kvp.Value);
                        Console.ReadKey();
                        Console.Clear();

                        
                        break;

                    case 4:
                        choice = 4;
                        string answer = " ";
                        Console.Clear();
                        Input.GetString("What word do you want to find?",ref answer);
                        Counts.ContainsKey(answer);
                        if (Counts.ContainsKey(answer) == true)
                        {
                            PrintKeyValueBar(answer, Counts[answer]);
                            for(int i=0;i<ListofSentences.Count;i++)
                            {
                                foreach(string word in ListofSentences[i].Split(' '))
                                {
                                    bool equal=string.Equals(word, answer, StringComparison.OrdinalIgnoreCase);
                                    if (equal == true)
                                        Console.WriteLine(ListofSentences[i]);

                                       

                                }
                            }
                            
                        }


                        else
                            Console.WriteLine($"{answer} is not found");
                        Console.ReadKey ();
                        Console.Clear();
                        break;
                    case 5:
                        choice = 5;
                        string remove = "";
                        Console.Clear();
                        Input.GetString("Please enter a word to remove", ref remove);
                        if(Counts.Remove(remove) == true)
                        {
                            Counts.Remove(remove);
                            Console.WriteLine($"{remove} was removed ");
                                
                        }
                        else if(Counts.Remove(remove) == false)
                        {
                            Console.WriteLine($"{remove} was not found");
                        }
                        Console.ReadKey ();
                        Console.Clear ();
                        break;
                    case 6:
                        choice = 6;
                        break;
                        default: choice = 0;
                        break;
                        

                         
                        

                    
                }    
                  
            }
           
            


            // ---------------------------------------------------
            //
            //Part A-8: Menu Loop
            //
            //You will need to create a loop in Main that handles the menu options for lab 1. This 
            //should be a simple while loop that loops while the menu selection is NOT exit. Inside
            //the while loop, you should 1) call GetMenuChoice to show the menu and get the
            //user’s menu selection. 2) use a switch statement that has logic for each menu option.
          
            
            
            
            
            

        }


        // ---------------------------------------------------
        //
        //Part B-1: GetSpeech method
        //
        //Create a method called GetSpeech. Copy and paste the text from the
        //file to the method. NOTE: the data to use for this project in the speechString.txt file in the "Solution Items" in Solution Explorer.
        //The method should simply return the string.
        //
        static string speech = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
            "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
            "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
            "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
            "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
            "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
            "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
            "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
            "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
            "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
            "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
            "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
            "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
            "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";
        public static string GetSpeech()
        {
            
            return speech;
            
            
        }




        // ---------------------------------------------------
        //
        //Part B-2: Splitter method
        //
        //Create a method called Splitter that will split the string parameter into an array of
        //words using the delimiters parameter. Make sure you remove the empty entries
        //when splitting. Convert the array of words to a list of strings and return the list.
        //
        
        public static List<string> Splitter(string message, char[] delimeters)

        {
            List<string> result = message.Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToList();
            return result;
            
            

            

        }




        // ---------------------------------------------------
        //
        //Part C-1: SpeechCounts method
        //
        //Create a method called SpeechCounts. Now that you have the list of words, you need
        //to calculate how many times each word appears in the list of words.In the method,
        //create a Dictionary to store those counts.The key of the dictionary will be the words
        //and the value will be the counts. Loop over the List of words and put or update the
        //word in the dictionary.
        //
        public static Dictionary<string, int> SpeechCounts(List<string> list)
        {
            
            Dictionary<string,int> counts = new Dictionary<string,int>(StringComparer.OrdinalIgnoreCase);
            foreach (string s in list)
                if (counts.ContainsKey(s))
                    counts[s]++;
                else
                    counts.Add(s, 1);
            return counts;
                        

        }


        // ---------------------------------------------------
        //
        //Part C-2: PrintKeyValueBar method
        //Create a method called PrintKeyValueBar that will print a word, a bar, and a count.
        //The size of the bar should equal the count.
        //
        //Note: the bar should be printed at a fixed horizontal position in the console so that
        //the bars align properly in the chart.Use Console.CursorLeft to align the bars.
        //
        public static void PrintKeyValueBar(string key,int value)

        {
            
                Console.Write(key,Console.CursorLeft);
            Console.Write(" ");
            Console.CursorLeft = 15;
            
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(new string(' ', value));
                
                
                    Console.Write(" ");
                
                Console.ResetColor();
                Console.Write(" ");
            Console.WriteLine(value);
            





        }


    }
}
