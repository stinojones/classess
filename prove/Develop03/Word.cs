using System;
using System.Collections.Generic;

public class Word
{
    private string _word;
    private bool _isHidden;
    private string _hiddenWord;
    private int _roundHidden;

    public Word(string word, bool isHidden, string hiddenWord = "", int roundHidden = 0)
    {
        _word = word;
        _isHidden = isHidden;
        _hiddenWord = hiddenWord;
        _roundHidden = roundHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Unhide()
    {
        _isHidden = false;
    }

    public void SetRoundHidden(int roundHidden)
    {
        _roundHidden = roundHidden;
    }

    public int GetRoundHidden()
    {
        return _roundHidden;
    }

    public string GetValue()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Show()
    {
        if (!_isHidden)
        {
            foreach (char letter in _word)
            {
                Console.Write(letter);
            }
        }
    }

    public string GetHiddenValue()
    {
        if (_isHidden)
        {
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
        }
        return _word;
    }

    public void WriteHiddenValue()
    {
        if (_isHidden)
        {
            foreach (char letter in _word)
            {
                if (Char.IsPunctuation(letter) || Char.IsNumber(letter))
                {
                    Console.Write(letter);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }

    public void Display()
    {
    }
}