using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Create the list of Word objects by splitting the input string
        string[] splitText = text.Split(' ');
        foreach (string wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Only consider words that aren't hidden yet (Stretch Challenge)
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Don't pick the same word twice in one call
        }
    }

    public string GetDisplayText()
    {
        string textContent = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {textContent}";
    }

    public bool IsCompletelyHidden() => _words.All(w => w.IsHidden());
}