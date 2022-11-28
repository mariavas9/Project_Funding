namespace Project_Funding.Domain
{
    public class Creator : User
    {
      public List<Project?>? projectList;

        public Creator()
        {
            isCreator = true;
        }

        public Creator(string firstName, string lastName) : base(firstName, lastName)
        {
            isCreator = true;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
