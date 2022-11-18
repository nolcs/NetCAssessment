namespace NETAssessment.Entities
{
    public class Vehicle
    {
        public Vehicle(int id, string brand, string vin, string color, int year, Owner owner)
        {
            Id = id;
            Brand = brand;
            Vin = vin;
            Color = color;
            Year = year;
            Owner = owner;
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public Owner Owner { get; set; }

    }
}
