public class Word
{
// ---------------------------------variables----------------------------------------
private string _word;
private bool _isHidden;
private string _hiddenWord;
// --------------------------------constructor----------------------------------------
public Word(string word, bool isHidden = false)
{
_word = word;
_isHidden = isHidden;
_hiddenWord = word;

}

// ----------------------------------methods----------------------------------------

public void HideWord()
{
    _isHidden = true;

}
public void ShowWord()
{
    _isHidden = false;
}

public void Display()
{

if (_isHidden == true)
{
    foreach(char letter in _word)
    {
        if (char.IsPunctuation(letter))
        {
            Console.WriteLine(letter);
        }
        else
        {
            Console.Write("-");
        }
    }
}
else
{
    Console.Write(_word);
}

}

}