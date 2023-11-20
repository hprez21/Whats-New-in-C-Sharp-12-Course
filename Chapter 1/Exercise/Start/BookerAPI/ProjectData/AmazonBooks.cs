namespace BookerAPI.ProjectData
{
    public class AmazonBooks : IBookService
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1954, Id = 1
                },
                new Book
                {
                    Title ="The Fellowship of the Ring", Author = "J.R.R. Tolkien", Year = 1954, Id = 2
                },
                new Book
                {
                    Title = "The Two Towers", Author = "J.R.R. Tolkien", Year = 1954, Id = 3
                }
            };
        }
    }
}