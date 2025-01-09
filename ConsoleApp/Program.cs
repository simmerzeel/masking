// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using ConsoleApp;

var x = BenchmarkRunner.Run<NewtonsoftTest>();
var y = BenchmarkRunner.Run<SystemTextTest>();

// var x = await new SystemTextTest().MaskWithSystemText();
// Console.WriteLine(x);
