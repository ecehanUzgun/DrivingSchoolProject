using MODEL.Abstracts;
using MODEL.Enums;

namespace MODEL.Concretes
{
    public class BaseEntity : IEntity<string>
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            CreatedComputerName = System.Environment.MachineName;
            Status = DataStatus.Active;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public DataStatus Status { get; set; }
    }
}
