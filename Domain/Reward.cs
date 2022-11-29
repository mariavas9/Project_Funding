namespace Project_Funding.Domain
{
    public class Reward
    {
        public enum Rewards { Poster, Cup, TShirt };

        public string GetReward(decimal amountFunded, decimal price)
        {
            // Find % and decide the reward
            return Rewards.TShirt.ToString();
        }
    }
}
