public class Scripture : Reference
{
    private List<Word> _words = new List<Word>();
    private List<Word> _hiddenWords = new List<Word>();
    private Reference _reference;
    private string _verse;
    private int _hideWordsRound = 0;
    private int _highestRound = -1;
    private int _randomNumber = 2;
    private bool _allHidden = true;

    public Scripture(Reference reference, string verse)
    {
        _verse = verse;
        _reference = reference;
    }

    public void PrintVerse()
    {
        Console.WriteLine(_verse);
    }

    public void DisplayReference()
    {
        _reference.Display();
    }

    public void ConvertStringToList()
    {
        string[] individualWords = _verse.Split(" ");
        foreach (string word in individualWords)
        {
            _words.Add(new Word(word, false));
        }
    }

    public void WriteOutWords()
    {
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetValue()} ");
        }
    }

    public void UnhideWords()
    {
        foreach (Word word in _hiddenWords)
        {
            word.Unhide();
        }
    }

    public bool CheckAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                _allHidden = false;
                return false;
            }
        }
        return true;
    }

    public void TestHideWords()
    {
        foreach (Word word in _words)
        {
            int wordRoundHidden = word.GetRoundHidden();
            if (wordRoundHidden > 0)
            {
                if (wordRoundHidden > _highestRound)
                {
                    word.Hide();
                    _highestRound = wordRoundHidden;
                }
            }
        }

        if (_hideWordsRound + 1 > _highestRound)
        {
            foreach (Word word in _words)
            {
                if (word.GetRoundHidden() > 0)
                {
                    word.WriteHiddenValue();
                }
                else
                {
                    Random random = new Random();
                    if (_randomNumber < 3)
                    {
                        int thisRound = _hideWordsRound + 1;
                        word.Hide();
                        word.WriteHiddenValue();
                        if (word.GetRoundHidden() > 0)
                        {
                            // Do nothing
                        }
                        else
                        {
                            word.SetRoundHidden(thisRound);
                        }
                    }
                    else
                    {
                        word.WriteHiddenValue();
                    }
                    int randomNumber = random.Next(0, 11);
                    _randomNumber = randomNumber;
                }
            }
        }
        else
        {
            foreach (Word word in _words)
            {
                if (word.GetRoundHidden() == _hideWordsRound + 1)
                {
                    word.Hide();
                }
                word.WriteHiddenValue();
            }
        }
        _randomNumber = 2;
    }

    public void HideWords()
    {
        Console.Clear();
        DisplayReference();
        WriteOutWords();

        while (true)
        {
            if (CheckAllWordsHidden())
            {
                Console.WriteLine("\nAll words have been hidden. [U]ndo to show previously hidden words - [Q]uit to exit program");
            }
            else
            {
                Console.WriteLine("\n[RETURN] to hide more words - [U]ndo to show previously hidden words - [Q]uit to exit program");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '\r')
            {
                Console.Clear();
                DisplayReference();
                TestHideWords();
                _hideWordsRound++;
            }
            else if (keyInfo.Key == ConsoleKey.U)
            {
                Console.Clear();
                DisplayReference();

                foreach (Word word in _words)
                {
                    if (word.GetRoundHidden() == _hideWordsRound)
                    {
                        word.Unhide();
                    }
                }

                foreach (Word word in _words)
                {
                    word.WriteHiddenValue();
                }

                if (_hideWordsRound > 0)
                {
                    _hideWordsRound--;
                }
            }
            else if (keyInfo.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
        }
    }
}