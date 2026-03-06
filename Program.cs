using System;
using System.IO;
public class Program
{
	static void NumOfLines(string file)
	{
		int num=0;
		var lines = ReadFrom(file);
		foreach (var line in lines)
		{
			num++;
		}
		Console.WriteLine(num);
	}
    public static void Main(string[] args)
    {
	if (args[0]=="-l")
		{
			NumOfLines(args[1]);
		}
	}
	static IEnumerable<string> ReadFrom(string file)
	{
		string? line;
		using (var reader = File.OpenText(file))
		{
			while ((line = reader.ReadLine()) != null)
			{
				yield return line;
			}
		}
	}
}