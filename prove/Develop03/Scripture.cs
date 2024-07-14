
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private List<int> genIndex = new List<int>(); // List of indexes

    public Scripture(Reference reference, string text)
    {  
        _reference = reference;
        _words = new List<Word>();

        string[] spacedText = text.Split(" ");
        foreach (string word in spacedText)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
           _words[numberToHide].Hide();
    }

    public string GetDisplayText()
    {
        List<string> showWords = new List<string>();
        
        foreach (Word word in _words)
        {
            showWords.Add(word.GetDisplayText()); // shows ___ or the word of the scripture
        }
        string scripture = string.Join(" ", showWords);
        return $"{_reference.GetDisplayText()} {scripture}";
    }

    public int rndIndexHideWord()
    {
        Random rnd = new();

        int rndNumber;
        while(true)
        {
            rndNumber =  rnd.Next(0, _words.Count);
            if(!genIndex.Contains(rndNumber))
            {
                genIndex.Add(rndNumber);
                break;
            }
        }
        return rndNumber;
    }


    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }

}