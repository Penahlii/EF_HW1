using EF_HW1.Enums;

namespace EF_HW1.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DataStatus Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }

    public BaseEntity() { }
}