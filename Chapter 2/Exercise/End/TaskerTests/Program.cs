
using TaskerTests;

var taskRepository = new TaskRepository();


var homeTasks = taskRepository.Tasks.Where(t => t.Type == CategoryType.Home)
    .ToList();

var workTasks = taskRepository.Tasks.Where(t => t.Type == CategoryType.Work)
    .ToList();

var hobbyTasks = taskRepository.Tasks.Where(t => t.Type == CategoryType.Hobby)
    .ToList();


//CALCULATOR SECTION

var calculator = new TimeCalculator();

//var totalHomeTasksDuration = calculator.ComputeTodoTime(new List<TimeSpan>
//{
//    new TimeSpan(1,1,1),
//    new TimeSpan(2,2,2),
//    new TimeSpan(3,3,3),
//    new TimeSpan(4,4,4),
//    new TimeSpan(5,5,5),
//});

var totalHomeTasksDuration =
    calculator.ComputeTodoTime(
       [
           new(1, 1, 1),
           new(2, 2, 2),
           new TimeSpan(3, 3, 3),
           new TimeSpan(4, 4, 4),
           new TimeSpan(5, 5, 5),
       ]);

Console.WriteLine($"Estimated Duration: {totalHomeTasksDuration.Hours}:{totalHomeTasksDuration.Minutes}:{totalHomeTasksDuration.Seconds}");

//var allTasks = homeTasks.Concat(workTasks).Concat(hobbyTasks).ToList();
List<TodoItem> allTasks =
    [..homeTasks, ..workTasks, ..hobbyTasks];

var totalAllTasksDuration = calculator.ComputeTodoTime(allTasks.Select(t => t.Duration).ToList());

Console.WriteLine($"Total Duration: {totalAllTasksDuration.Hours}:{totalAllTasksDuration.Minutes}:{totalAllTasksDuration.Seconds}");
