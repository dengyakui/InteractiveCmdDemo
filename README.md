# InteractiveCmdDemo
Use CliWrap to invoke cmd tools, and use it's pipe syntax as stdin for use prompt args


## Steps:
1. build console1 project, and copy the exe path
2. open console2 project, find code with  Cli.Wrap("{path}"), and replace path value
3. run console2 project, view the result.

### invoke cmd
```c#
var stdin = """
            Yoda
            yoda@gmail.com
            """;
var cmd = stdin | Cli.Wrap("path-to-cmd.exe")  // make strings as stdi, pipes to the cmd
```


### app to get user input:
```c#
Console.WriteLine($"arg length: {args.Length}");
for (var i = 0; i < args.Length; i++)
{
    Console.WriteLine($"args[{i}] is: {args[i]}");
}


Console.WriteLine("input your name:");
var userName = Console.ReadLine();
Console.WriteLine($"got user name: {userName}");

Console.WriteLine("input your email:");
var email = Console.ReadLine();
Console.WriteLine($"got email: {email}");

Console.WriteLine($"user name: {userName}, email: {email}");
```

## images:
![image](https://user-images.githubusercontent.com/3945919/220051724-31b00c0d-7bed-4469-8e2a-d32e5bf6f094.png)

![image](https://user-images.githubusercontent.com/3945919/220048325-6f34bd8c-cfd4-4da2-9c3b-1045a5855371.png)
