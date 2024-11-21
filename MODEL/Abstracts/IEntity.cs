using MODEL.Enums;

namespace MODEL.Abstracts
{
    public interface IEntity<T>
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public DataStatus Status { get; set; }
    }
}
