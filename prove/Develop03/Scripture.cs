public class Scripture
{
    // ---------------------------------variables----------------------------------------
        private List<Scripture> _words = new List<Scripture>();
        
        private Reference _ref;

        private string _verse;


    // --------------------------------constructor----------------------------------------

    public Scripture(Reference reference, string verse)
    {
        _ref = reference;
        _verse = verse;

    }

    // ----------------------------------methods----------------------------------------


    public void PrintVerse()
    {
        Console.WriteLine(_verse);

    }
    public void DisplayRef()
    {
        _ref.Display();
    }


    public void ConvertStringToList()
    {
        string [] individualWords = _verse.Split(" ");
        foreach(string word in individualWords)
        {
            _words.Add(new Word(word, false));
            

        }


    }

    public void HideWords()
    {
        

    }

    public void IsCompletelyHidden()
    {

    }

    public void ShowAllWords()
    {

    }



}