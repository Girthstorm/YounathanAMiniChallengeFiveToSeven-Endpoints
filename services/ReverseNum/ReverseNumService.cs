namespace YounathanAMiniChallengeFiveToSeven_Endpoints.services.ReverseNum;

    public class ReverseNumService : IReverseNumService
    {
        public string RevNum(string num1)
        {
            double num2 = 0;
            if(double.TryParse(num1, out num2))
            {
                string reversed = "";
                for(int i = num1.Length-1; i >= 0; i--)
                {
                    reversed += num1[i];
                }
                return $"Your Number:{num1} reversed is: {reversed}";
            }else{
                return "Your Input wasn't a number. Please enter a number!";
            }
        }
    }
