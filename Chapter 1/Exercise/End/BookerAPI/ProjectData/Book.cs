namespace BookerAPI.ProjectData
{
    public class Book(string title, string author, int year, int id)
    {
        public int Id => id;
        public string Title => title;
        public string Author => author;
        public int Year => year;
    }
}