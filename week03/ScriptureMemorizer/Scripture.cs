using System;


public class Scripture
{

    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(' ');
        _words = new List<Word>();

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
        _random = new Random();
    }

    public string GetDisplayText()
    {
        string wordText="";
        foreach (Word word in _words)
        {
            wordText += word.GetDisplayText() + " ";
        }
        return wordText;
    }

    public void HideRandomWord(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
        

    }

    public Boolean IsCompletelyHidden()
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
