namespace BookerAPI.ProjectData
{
    public class AmazonBooks : IBookService
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new("The Hobbit", "J.R.R. Tolkien", 1954, 1),
                new("The Fellowship of the Ring", "J.R.R. Tolkien", 1954, 2),
                new("The Two Towers", "J.R.R. Tolkien", 1954, 3)
            };
        }
    }
}