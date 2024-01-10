namespace YounathanAMiniChallengeFiveToSeven_Endpoints.services.OddEven;

    public class OddEvenService: IOddEvenService
    {
        int userInput = 0;
        public string OddEven(string num1)
        {
            if (int.TryParse(num1, out userInput )){
                if(userInput % 2 == 0){
                    return $"The number {userInput} is an EVEN number.";
                }else{
                    return $"The number {userInput} is an ODD number.";   
                }
            } else {
                return "Input was not a WHOLE NUMBER, please enter a Whole Number";
            }
        }
    }
