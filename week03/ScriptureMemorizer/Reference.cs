using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    private string _book;
    private int _verse;
    private int _chapter;
    private int _endVerse;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _verse = verse;
        _chapter = chapter;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _verse = startVerse;
        _chapter = chapter;
        _endVerse = endVerse;
    }


    public string GetDisplayText()
    {
        
         if (_endVerse == -1 || _verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }   
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        
        
    }
}