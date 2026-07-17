using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            // Split the text by spaces to populate the Word list
            string[] splitWords = text.Split(' ');
            foreach (string wordText in splitWords)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            
            // Exceeding Requirements / Stretch Challenge: 
            // We find only the words that are NOT already hidden.
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            // If there are fewer visible words than the requested number to hide, 
            // we will only hide what is left.
            int limit = Math.Min(numberToHide, visibleWords.Count);

            for (int i = 0; i < limit; i++)
            {
                int randomIndex = random.Next(visibleWords.Count);
                visibleWords[randomIndex].Hide();
                visibleWords.RemoveAt(randomIndex); // Ensure we don't pick the same word twice in one turn
            }
        }

        public string GetDisplayText()
        {
            string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
            return $"{_reference.GetDisplayText()} - {scriptureText}";
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
        }
    }
}