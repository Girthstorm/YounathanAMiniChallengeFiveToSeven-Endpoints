namespace YounathanAMiniChallengeFiveToSeven_Endpoints.services.ReverseWord;

    public class ReverseWordService: IReverseWordService
    {
        public string ReverseIt(string word)
        {
            string revWord = "";
            for(int i = word.Length-1; i >= 0; i--)
            {
                revWord += word[i];
            }
            return revWord;
        }
    }
