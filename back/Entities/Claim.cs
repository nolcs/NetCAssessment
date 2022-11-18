namespace NETAssessment.Entities
{
    public class Claim
    {
        public Claim()
        {
        }

        public Claim(int id, string description, string status, DateTime date, Vehicle vehicle)
        {
            Id = id;
            Description = description;
            Status = status;
            Date = date;
            Vehicle = vehicle;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public Vehicle Vehicle { get; set; }
        
    }
}
