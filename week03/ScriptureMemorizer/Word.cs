using System;

public class Word
{

    private string _text;
    private Boolean _isHidden;


    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;

    }

    public void Show()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string underscore = "";
            for (int i = 0; i <= _text.Length; i++)
            {
                underscore = "_";
            }
            return underscore;
        }
        else
        {
            return _text;
        }
        
    }

    public Boolean IsHidden()
    {
        return _isHidden;
    }
}