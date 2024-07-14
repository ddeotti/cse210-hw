public class ScriptureGenerator
{
    private List<Reference> _refGenerator = new List<Reference>();
    private Random _randNumber;
    private int rndIndex;

    private List<string> _txtGenerator = new List<string>
    {
    "He who dwells in the shelter of the Most High will abide in the shadow of the Almighty. I will say to the Lord, 'My refuge and my fortress, my God, in whom I trust.'",
    "I lift up my eyes to the hills. From where does my help come? My help comes from the Lord, who made heaven and earth.",
    "Trust in the Lord with all your heart; do not depend on your own understanding." 
    };

    public ScriptureGenerator()
    {
        _refGenerator.Add(new Reference("Psalm", 91, 1, 2));
        _refGenerator.Add(new Reference("Proverbs", 3, 5));
        _refGenerator.Add(new Reference("Psalm", 121, 1, 2));
        _randNumber = new Random();
        rndIndex = _randNumber.Next(0,_refGenerator.Count);
    }

    public string txtGenerator()
    {
        return _txtGenerator[rndIndex];
    }

    public Reference refGenerator()
    {
        return _refGenerator[rndIndex];
    }

}