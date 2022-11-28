namespace Project_Funding.Domain
{
    public class Project
    {
        public int projectId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int CreatorId { get; set; }
        public List<Backer?>? backers { get; set; }
        decimal moneyCollected { get; set; } = 0;
        decimal price { get; set; }

        public Project(string title, string description, int CreatorId, decimal price) 
        {
            this.title = title;
            this.description = description;
            this.CreatorId = CreatorId;
            this.price = price;
        }


    }
}
