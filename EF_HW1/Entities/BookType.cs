namespace EF_HW1.Entities;

public class BookType : BaseEntity
{
    public string Name { get; set; }

    public List<Book> Books { get; set; } // Navigation Property
}