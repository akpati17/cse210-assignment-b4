
using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    /*
     * SHOWING CREATIVITY & EXCEEDING REQUIREMENTS:
     * 1. Added a Scripture Library: Instead of hardcoding a single scripture, the program contains a curated 
     *    list (library) of scriptures and selects one at random each time the program starts.
     * 2. Smart Word-Hiding (Stretch Challenge): The Scripture class filters words to only randomly select 
     *    from those that are NOT already hidden. This ensures the program finishes efficiently and never wastes 
     *    turns attempting to hide already-hidden words.
     * 3. Seamless UI: Handled custom console clearing and exit state validation.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a library of scriptures (Supports single verses and ranges)
            List<Scripture> scriptureLibrary = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only Son that whoever believes in him should not perish but have eternal life"),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight"),
                new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me"),
                new Scripture(new Reference("Joshua", 1, 9), "Have I not commanded you Be strong and courageous Do not be afraid do not be discouraged for the Lord your God will be with you wherever you go")
            };

            // Select a random scripture from the library
            Random random = new Random();
            Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            // Main game loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine();

                if (selectedScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("Congratulations! You have memorized the scripture!");
                    break;
                }

                Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "quit")
                {
                    break;
                }

                // Hide 3 random words each turn
                selectedScripture.HideRandomWords(3);
            }

            Console.WriteLine("\nGoodbye!");
        }
    }
}