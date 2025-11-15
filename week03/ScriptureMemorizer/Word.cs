using System;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() => _isHidden = true;
    public void Show() => _isHidden = false;
    public bool IsHidden() => _isHidden;

    public string GetDisplayText()
    {
        if (!_isHidden) return _text;

        var sb = new StringBuilder();
        foreach (char c in _text)
            sb.Append(char.IsLetter(c) ? '_' : c);

        return sb.ToString();
    }

    public bool ContainsLetter()
    {
        foreach (char c in _text)
            if (char.IsLetter(c))
                return true;
        return false;
    }
}
