
var pathToFiles = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\..\");
var directories = Directory.GetDirectories(pathToFiles);

foreach (var directory in directories)
{
    var files = Directory.GetFiles(directory);
    foreach (var file in files)
    {
        Console.WriteLine(directory.Replace(pathToFiles, string.Empty));
        var content = File.ReadAllText(file);
        Console.WriteLine(content);
        Console.WriteLine();
    }
}

Console.ReadKey();
