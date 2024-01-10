
namespace YounathanAMiniChallengeFiveToSeven_Endpoints.services.MadLib;

    public class MadLibServices : IMadLibServices
    {
        public string MadLibbing(string name, string villian, string devilFruit, string crewMate, string islandName, string trait, string islandName2, string shipName, string bountyAmount, string catchphrase)
        {
            return $"In the world of One Piece, our brave main character, {name}, possesses the incredible \"{devilFruit}\" power. Alongside his loyal crew member, {crewMate}, who is known for {trait}, {name} sets sail on the grand adventure to find the legendary treasure of the One Piece. Their journey takes them to the mysterious island of {islandName}, where they encounter strange creatures and face various challenges.\n\tBut it's not all fun and games on the Grand Line. The notorious villain, {villian}, with a bounty of {bountyAmount} Berries on their head, relentlessly pursues {name} and his crew. They must navigate treacherous waters, including the perilous {islandName2}, and fend off other pirates in their fearsome pirate ship, the \"{shipName}.\" Whenever they\'re faced with danger, {name} and his crew shout their battle cry, \"{catchphrase},\" as they bravely strive to become the Pirate King and uncover the ultimate treasure of the One Piece!";
        }
    }
