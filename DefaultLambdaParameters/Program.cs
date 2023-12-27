
// Default Lambda Parameters is a new C# 12 feature which allows you to define a default value for a parameter in lambda expressions. 
// To create a lambda with a default parameter value, you only need to specify the value of the parameter, for example:

var lambdaDemo = (string name = "Lambda Default") => Console.WriteLine($"Hello {name}");

lambdaDemo(); // => Hello Lambda Default

// When calling the lambda informing a parameter, the default value will then not be used:

lambdaDemo("Gandalf"); // => Hello Gandalf

// It’s also possible to retrieve the lambda’s default parameter value. For that, you need to use the property Method, and call the GetParemeters informing the position of the parameter you wanna retrieve (in this example there is only one parameter, so for this reason is the position 0):

var retriveDefault = lambdaDemo.Method.GetParameters()[0].DefaultValue;
Console.WriteLine($"Default parameter is ={retriveDefault}");

Console.WriteLine("----------------");

var IncrementBy = (int source, int increment = 1, int thirdOne =+2) => Console.WriteLine($"{source + increment + thirdOne}");

IncrementBy(5); // 8
IncrementBy(3,3,3); // 9
IncrementBy(5, 2); // 9
IncrementBy(5, 2,0); // 7
Console.WriteLine(IncrementBy.Method.GetParameters()[2].DefaultValue); // 2
Console.WriteLine(IncrementBy.Method.GetParameters()[1].DefaultValue); // 1
Console.WriteLine(IncrementBy.Method.GetParameters()[0].DefaultValue); // null
