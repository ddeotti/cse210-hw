public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Construtor correto
    public Scripture(Reference reference, string text)
    {

    }

    public void HideRandomWords(int numberToHide)
    {
    } 

    public string GetDisplayText()
    {
       return "hello"; 
    }

    public bool IsCompletelyHidden()
    {
        return false; 
    }
}