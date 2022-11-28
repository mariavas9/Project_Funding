namespace Project_Funding.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;

        public bool isCreator;

        public User() { }

        public User(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

    
}


