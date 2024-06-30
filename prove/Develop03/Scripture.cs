using System.ComponentModel;
using Microsoft.CSharp.RuntimeBinder;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split();
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        int visibleWordsCount = _words.Count(word => !word.IsHidden());

        if (numberToHide > visibleWordsCount)
        {
            numberToHide = visibleWordsCount;
        }

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount ++;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()}";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }

    public bool IsCompletlyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}