using System;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = fa
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public void Show()
        {
            _isHidden = false;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            if (_isHidden)
            {
                // Replace letters/digits with underscores, keeping punctuation intact if preferred.
                // Here, we replace every character in the word with an underscore.
                return new string('_', _text.Length);
            }
            return _text;
        }
    }
}
