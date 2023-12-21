// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Array
int[] a = [1, 2, 3, 4, 5];
//List
List<string> b = ["one", "two", "three"];
//Span
Span<char> c = ['a', 'b', 'c', 'd'];
// jagged 2d array
int[][] twoDimension = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

int[] z = [6, 7];
int[] x = [8, 9];
int[][] twoDimensionFromVariables = [a, z, x];

//old style
foreach (var i in twoDimensionFromVariables)
{
	foreach (var j in i)
	{
		Console.Write(j);
	}
}

// new style
Console.WriteLine("\nWrite twoD jagged array in one foreach");
int[] single = [.. a, .. z, .. x];
foreach (var i in single)
{
	Console.Write(i);
}