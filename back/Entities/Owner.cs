namespace NETAssessment.Entities
{
    public class Owner
    {
        public Owner(int id, string firstName, string lastName, string driverLicense)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DriverLicense = driverLicense;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DriverLicense { get; set; }

    }
}
