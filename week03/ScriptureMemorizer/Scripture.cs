using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rng = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] tokens = Regex.Split(text.Trim(), @"\s+");
        foreach (var token in tokens)
            _words.Add(new Word(token));
    }

    public string GetDisplayText()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_reference.GetDisplayText());
        sb.AppendLine();
        sb.AppendLine(string.Join(" ", _words.Select(w => w.GetDisplayText())));
        return sb.ToString();
    }

    public void HideRandomWords(int numberToHide)
    {
        var visibleIndices = _words
            .Select((w, i) => new { Word = w, Index = i })
            .Where(wi => !wi.Word.IsHidden() && wi.Word.ContainsLetter())
            .Select(wi => wi.Index)
            .ToList();

        int toHide = Math.Min(numberToHide, visibleIndices.Count);

        for (int i = 0; i < toHide; i++)
        {
            int pick = _rng.Next(visibleIndices.Count);
            _words[visibleIndices[pick]].Hide();
            visibleIndices.RemoveAt(pick);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => !w.ContainsLetter() || w.IsHidden());
    }
}
