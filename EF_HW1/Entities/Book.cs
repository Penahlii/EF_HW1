namespace EF_HW1.Entities;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public int PageCount { get; set; }

    // Foreign keys
    public int AuthorId { get; set; }  
    public int BookTypeId { get; set; }

    // Navigation properties
    public Author Author { get; set; }
    public List<Student> Students { get; set; }
    public BookType BookType { get; set; }
}