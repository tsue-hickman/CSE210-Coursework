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
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                _words.Add(new Word(word));
            }
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> visibleWordIndices = Enumerable.Range(0, _words.Count)
            .Where(i => !_words[i].IsHidden())
            .ToList();

        int wordsToHide = Math.Min(numberToHide, visibleWordIndices.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            if (visibleWordIndices.Count == 0)
                break;

            int randomIndex = random.Next(0, visibleWordIndices.Count);
            int wordIndex = visibleWordIndices[randomIndex];
            _words[wordIndex].Hide();
            visibleWordIndices.RemoveAt(randomIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public string GetDisplayText()
    {
        string wordText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordText}";
    }
}