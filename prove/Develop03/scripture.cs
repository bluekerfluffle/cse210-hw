using System;
    class Scripture
    {
        public string Reference { get; private set; }
        public string Text { get; private set; }
        public string[] Words { get; private set; }
        public int WordCount { get; private set; }
        public HashSet<int> HideWords { get; private set; }

        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
            Words = text.Split(' ');
            WordCount = Words.Length;
            HideWords = new HashSet<int>();
        }
    }

