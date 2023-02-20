// See https://aka.ms/new-console-template for more information

using CliWrap;
using CliWrap.Buffered;
// 使用以下方式， 每行作为调用命令行的用户输入
var stdin = """
			Yoda
			yoda@gmail.com
			""";
var cmd = stdin | Cli.Wrap(@"C:\Users\root\RiderProjects\ConsoleApp1\ConsoleApp1\bin\Debug\net7.0\ConsoleApp1.exe");
var bufferedCommandResult = await cmd.ExecuteBufferedAsync();
Console.WriteLine(bufferedCommandResult.StandardOutput);