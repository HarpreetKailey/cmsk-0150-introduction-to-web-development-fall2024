namespace EntityFrameworkOverview;
class Program
{
    static DatabaseContext db = new DatabaseContext();
    static void Main(string[] args)
    {
        AddAuthor("Levsen");
        ListAuthors();
    }

    static void AddAuthor(string name)
    { 
        var author = new Author()
        {
            LastName = name,
        };

        db.Authors.Add(author);
        db.SaveChanges();
    }

    static void ListAuthors()
    {
        var authors = db.Authors;

        foreach (var author in authors) {
            Console.WriteLine($"{author.AuthorId}  {author.LastName}");
        }
    }
}
