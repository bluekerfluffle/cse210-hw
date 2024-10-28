using System;
    class ScriptureReference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public int verseBegin { get; private set; }
        public int VerseEnd { get; private set; }

        public ScriptureReference(string reference)
        {
            string[] parts = reference.Split(' ');
            Book = parts[0];
            Chapter = int.Parse(parts[1]);
            if (parts.Length == 3)
            {
                verseBegin = int.Parse(parts[2]);
                VerseEnd = verseBegin;
            }
            else
            {
                string[] verseParts = parts[2].Split('-');
                verseBegin = int.Parse(verseParts[0]);
                VerseEnd = int.Parse(verseParts[1]);
        }
    }
}