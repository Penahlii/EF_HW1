using EF_HW1.Enums;

namespace EF_HW1.Entities;

public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int SchoolNumber { get; set; }
    public Gender gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; }

    public List<Book> Books { get; set; } // Navigation Property
}