using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskerTests
{
    public class TaskRepository
    {
        public List<TodoItem> Tasks { get; set; }

        public TaskRepository()
        {
            Tasks = new List<TodoItem>
                {
                    new TodoItem()
                    {
                        Id = 1,
                        TaskName = "Demo Task 1",
                        Duration = new TimeSpan(1, 0, 0),
                        Type = CategoryType.Work
                    },
                    new TodoItem()
                    {
                        Id = 2,
                        TaskName = "Demo Task 2",
                        Duration = new TimeSpan(2, 0, 0),
                        Type = CategoryType.Home
                    },
                    new TodoItem()
                    {
                        Id = 3,
                        TaskName = "Demo Task 3",
                        Duration = new TimeSpan(3, 0, 0),
                        Type = CategoryType.Work
                    },
                    new TodoItem()
                    {
                        Id = 4,
                        TaskName = "Demo Task 4",
                        Duration = new TimeSpan(4, 0, 0),
                        Type = CategoryType.Hobby
                    },
                    new TodoItem()
                    {
                        Id = 5,
                        TaskName = "Demo Task 5",
                        Duration = new TimeSpan(5, 0, 0),
                        Type = CategoryType.Home
                    },
                };
        }
        public void Add(TodoItem task)
        {
            Tasks.Add(task);
        }

        public void Remove(TodoItem task)
        {
            Tasks.Remove(task);
        }

        public TodoItem GetByCategories(CategoryType categoryType) => 
            Tasks.FirstOrDefault(t => t.Type == categoryType);


    }

    public class TimeCalculator
    {
        public TimeSpan ComputeTodoTime(List<TimeSpan> time)
        {
            TimeSpan calculation = TimeSpan.Zero;

            time.ForEach(item => calculation += item);

            return calculation;
        }
    }

}
