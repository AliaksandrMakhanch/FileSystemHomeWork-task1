using System.IO;

string dirName = "C:/Users/Aliaksandr_Makhnach/source/repos/FileSystemHomeWork/";
 
var directory = new DirectoryInfo(dirName);

if (directory.Exists)
{
    Console.WriteLine("Folders:");
    DirectoryInfo[] dirs = directory.GetDirectories();
    foreach (DirectoryInfo dir in dirs)
    {
        Console.WriteLine(dir.FullName);
    }
    Console.WriteLine();
    Console.WriteLine("Files:");
    FileInfo[] files = directory.GetFiles();
    foreach (FileInfo file in files)
    {
        Console.WriteLine(file.FullName);
    }
}