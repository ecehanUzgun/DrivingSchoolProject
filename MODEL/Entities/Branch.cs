namespace MODEL.Entities
{
    public class Branch
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string PhoneNumber { get; set; } //todo:10 hane

        //Relational Properties
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
