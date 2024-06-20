// See https://aka.ms/new-console-template for more information
using JSONSerialization;
using System.Text.Json;

Console.WriteLine("Hello, World!");

var person = JsonSerializer.Deserialize<Person>(
	"{\"FirstName\":\"Fatih\",\"MiddleNames\":[\"Ronald\",\"Veli\"],\"LastName\":\"Ozer\"}");
Console.WriteLine(String.Join(" ", person!.MiddleNames));
