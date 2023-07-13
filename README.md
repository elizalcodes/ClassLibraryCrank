# ClassLibraryCrank

sample repo for testing comparing BenchmarksDotNet result json files using dotnet Crank.

# running crank
you need to install crank controller and crank agent to run the crank compare command
start crank agent
$ crank-agent

start crank conroller pass configuration details
$ crank --config .\library-benchmark.yml --scenario runbenchmarks --profile local --json main.json

uncomment the benchmark in the BenchmarkLibrary.Benchmark class

'''
// [Benchmark]
// public string BenchmarkNew() => ClassLibraryCrank.SomeClass.Method2(_data);
'''

run crank again
$ crank --config .\library-benchmark.yml --scenario runbenchmarks --profile local --json branch.json

run crank compare
$ crank compare main.json branch.json

