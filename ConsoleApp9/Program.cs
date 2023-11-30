using System.Diagnostics;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
         
        // var summary = BenchmarkRunner.Run<Program>();

        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        Fn(45);
        
        Stopwatch s = new Stopwatch();
        s.Start();
        Fn(45);
        s.Stop();
        Console.WriteLine(s.ElapsedMilliseconds);
    }

    [Benchmark]
    [Arguments(45)]
    public static int Fn(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        return Fn(n - 1) + Fn(n - 2);
    }
}