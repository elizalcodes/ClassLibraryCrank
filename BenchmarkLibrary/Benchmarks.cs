using BenchmarkDotNet.Attributes;

namespace BenchmarkLibrary;

public class Benchmarks
{
    private string _data = "";

    [Params(4, 6)] public int Number;

    [GlobalSetup]
    public void Setup()
    {
        for (int i = 0; i < Number; i++)
        {
            _data += $"{i % 8}";
        }
    }

    [Benchmark]
    public string BenchmarkExisting() => ClassLibraryCrank.SomeClass.Method1(_data, 3);

    // [Benchmark]
    // public string BenchmarkNew() => ClassLibraryCrank.SomeClass.Method2(_data);
}