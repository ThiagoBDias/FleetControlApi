namespace FleetControlApi.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Plate { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public int Year { get; set; }

        public int Mileage { get; set; }

        public bool Active { get; set; } = true;
    }
}
