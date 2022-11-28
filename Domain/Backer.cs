namespace Project_Funding.Domain
{
    public class Backer : User
    {
        public List<Project?>? ProjectsFunded { get; set; } = null;
        decimal? Funded { get; set; }
        public Backer()
        {
            isCreator = false;
        }

        public Backer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            isCreator = false;
        }
    }
}
