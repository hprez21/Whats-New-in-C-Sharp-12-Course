namespace BookerAPI.ProjectData
{
    public class Book
    {
        public Book(){}

        public Book(string title, string author, int year, int id)
        {
            Title = title;
            Author = author;
            Year = year;
            Id = id;
        }

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Year{get; set; }
}
}