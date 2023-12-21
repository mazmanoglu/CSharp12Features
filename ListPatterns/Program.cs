// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// sequence of patterns

int[] numbers = { 1, 2, 3 };

Console.WriteLine(numbers is [1, 2, 3]);  // True
Console.WriteLine(numbers is [1, 2, 4]);  // False
Console.WriteLine(numbers is [1, 2, 3, 4]);  // False
Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);  // first expression 0 or 1 == true
																	  // second expression <=2 == true
																	  // third expression >=3 == true


// var pattern
if (numbers is [var first, var second, var third])
{
	Console.WriteLine($"The first element of a three-item list is {first}"); // The first element of a three-item list is 1.
	Console.WriteLine($"The first element of a three-item list is {second}"); // The first element of a three-item list is 2.
	Console.WriteLine($"The first element of a three-item list is {third}"); // The first element of a three-item list is 3.

}

// slice pattern
// The preceding examples match a whole input sequence against a list pattern. To match elements only at the start or/and the end of an input sequence,
// use the slice pattern .., as the following example shows:

Console.WriteLine(new[] { 1, 2, 3, 4, 5 } is [> 0, > 0, ..]);  // True
Console.WriteLine(new[] { 1, 1 } is [_, _, ..]);  // True
Console.WriteLine(new[] { 0, 1, 2, 3, 4 } is [> 0, > 0, ..]);  // False
Console.WriteLine(new[] { 1 } is [1, 2, ..]);  // False

Console.WriteLine(new[] { 1, 2, 3, 4 } is [.., > 0, > 0]);  // True
Console.WriteLine(new[] { 2, 4 } is [.., > 0, 4]);  // True
Console.WriteLine(new[] { 2, 4 } is [.., > 0, 2, 4]);  // False
Console.WriteLine(new[] { 2, 4 } is [.., 2, 4]);  // True

Console.WriteLine(new[] { 1, 2, 3, 4 } is [>= 0, .., 2 or 4]);  // True
Console.WriteLine(new[] { 1, 0, 0, 1 } is [1, 0, .., 0, 1]);  // True
Console.WriteLine(new[] { 1, 0, 1 } is [1, 0, .., 0, 1]);  // False