using System;
using System.Collections.Generic;
using System.Linq; 

public class Scripture
{
    
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random(); // Ferramenta para seleção aleatória

    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        
        string[] wordsArray = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        
        foreach (string wordText in wordsArray)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }

    
    public void HideRandomWords(int countToHide)
    {
        
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        
        if (visibleWords.Count == 0)
        {
            return;
        }

        
        int actualCount = Math.Min(countToHide, visibleWords.Count);

        
        for (int i = 0; i < actualCount; i++)
        {
            int index = _random.Next(visibleWords.Count);
            
          
            Word wordToHide = visibleWords[index];
            wordToHide.Hide();

           
            visibleWords.RemoveAt(index);
        }
    }

    
    public string GetDisplayText()
    {
        
        string referenceText = _reference.GetDisplayText();

        
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
          
            displayWords.Add(word.GetDisplayText());
        }

        
        string scriptureText = string.Join(" ", displayWords);

       
        return $"{referenceText} - {scriptureText}";
    }

    
    public bool IsCompletelyHidden()
    {
        
        return _words.All(w => w.IsHidden());
    }
}