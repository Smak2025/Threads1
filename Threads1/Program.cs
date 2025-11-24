using System.Diagnostics;
using Threads1;

var n = 2_000_000_000;
var sequentialSummator = new SequentialSummator(n);
var stopwatch = new Stopwatch();
stopwatch.Start();
sequentialSummator.CalcSum();
stopwatch.Stop();
Console.WriteLine("{0} за {1} мс.", sequentialSummator.Result, stopwatch.ElapsedMilliseconds);

var parallelSummator = new ParallelSummator(n);
stopwatch.Restart();
parallelSummator.CalcSum();
stopwatch.Stop();
Console.WriteLine("{0} за {1} мс.", parallelSummator.Result, stopwatch.ElapsedMilliseconds);