string[] strings = { "46654", "76", "987", "87654", "4", "7654" }; 
var result = strings.Where(s => s.Length <= 3).ToArray(); 
Console.WriteLine(string.Join(", ", result)); 
