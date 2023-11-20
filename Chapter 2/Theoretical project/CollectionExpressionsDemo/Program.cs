using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

//int[] arrayNumbersA = new[] { 1, 2, 3, 4, 5 };
int[] arrayNumbersA = { 1, 2, 3, 4, 5 };

List<int> listNumbersA =
    new List<int> { 1, 2, 3, 4, 5 };

Span<int> spanNumbersA =
    stackalloc int[5] { 1, 2, 3, 4, 5 };

ImmutableArray<int> immutableArrayNumbersA =
    ImmutableArray.Create(1, 2, 3, 4, 5);

//[e1, e2, e3, e4, e5]
//[e1, ..l1, e2]


int[] arrayNumbersB = [1, 2, 3, 4, 5];

List<int> listNumbersB =
    [ 1, 2, 3, 4, 5 ];

Span<int> spanNumbersB =
    [ 1, 2, 3, 4, 5 ];

ImmutableArray<int> immutableArrayNumbersB =
    [1, 2, 3, 4, 5];


double AverageImproved(IEnumerable<int> value) =>
    value.Average() + 250;

AverageImproved([24, 30, 100]);



List<int> list1 = [1, 2, 3, 4, 5];
List<int> list2 = [6, 7, 8, 9, 10];

List<int> list3 = new List<int>(list1);
list3.AddRange(list2);

List<int> combinedList = [.. list1, .. list2, 100];



TaskList tasks = ["buy eggs", "learn C# 100"];


[CollectionBuilder(typeof(TaskListBuilder), "Create")]
public class TaskList : IEnumerable<string>
{
    private readonly string[] _tasks;

    public TaskList(ReadOnlySpan<string> tasks)
    {
        _tasks = new string[tasks.Length];
        for (int i = 0; i < tasks.Length; i++)
        {
            _tasks[i] = tasks[i];
        }
    }

    public IEnumerator<string> GetEnumerator() => _tasks
        .AsEnumerable<string>().GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => _tasks.GetEnumerator();
}

internal static class TaskListBuilder
{
    internal static TaskList Create(ReadOnlySpan<string> values) => new TaskList(values);
}


