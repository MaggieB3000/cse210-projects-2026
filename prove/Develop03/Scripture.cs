using System.Net.Http.Headers;

public class Scripture
{
    private List<Word> _text;
    private Reference _reference;

    private int _wordsToHide;

    public Scripture(List<Word> text, Reference reference, int wordsToHide)
    {
        _text = text;
        _reference = reference;
        _wordsToHide = wordsToHide;
    }

    public string ScriptureGetRenderedText()
    {
        List<string> newText = new List<string>();
        int counter = _wordsToHide;

        foreach (Word word in _text)
        {
            bool isHidden = word.IsHidden();

            if (isHidden == false)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 3);

                if (randomNumber == 1 && counter > 0)
                {
                    word.Hide();
                    string hiddenWord = word.GetRenderedText();
                    newText.Add(hiddenWord);
                    counter = counter-1;
                }

                else
                {
                    string visibleWord = word.GetRenderedText();
                    newText.Add(visibleWord);
                }
            }

            else
            {
                string hiddenWord = word.GetRenderedText();
                newText.Add(hiddenWord);
            }
        }
        return string.Join(" ", newText);;
    }
}