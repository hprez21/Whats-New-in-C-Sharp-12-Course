using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskerTests
{
    public class TodoItem(int id, string taskName, TimeSpan duration, CategoryType type)
    {
        public int Id { get; set; } = id;
        public string TaskName { get; set; } = taskName;
        public TimeSpan Duration { get; set; } = duration;
        public CategoryType Type { get; set; }  = type;
    }

    public enum CategoryType
    {
        Work,
        Home,
        Hobby
    }
}
