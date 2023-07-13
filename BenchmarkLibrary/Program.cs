using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

var config = ManualConfig.Create(DefaultConfig.Instance)
    .WithOptions(ConfigOptions.StopOnFirstError);

BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);