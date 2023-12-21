
using UsingRecordType;

// Employee employee = new Employee(1, "Fatih", "Ozer", 2500); old version
Employee employee = new(1, "Fatih", "Ozer", 2500);
Console.WriteLine(employee);

Employee employee2 = new(1, "Fatih", "Ozer", 2500);
Console.WriteLine(employee2);

Console.WriteLine($"employee == employee2 is {employee == employee2}"); // false, ref type

Employee employee3 = employee;
Console.WriteLine(employee3);

Console.WriteLine($"employee == employee2 is {employee == employee2}"); // false, ref type
Console.WriteLine($"employee == employee3 is {employee == employee3}"); // true, because both referance at the same object

EmployeeRec employeeRec1 = new(1, "Nese", "Ozer", 3000);
EmployeeRec employeeRec2 = new(1, "Nese", "Ozer", 3000);
Console.WriteLine(employeeRec2);

Console.WriteLine($"employeeRec1==employeeRec2 is {employeeRec1 == employeeRec2}"); // true

EmployeeRec employeeRec3 = employeeRec1 with { Id = 3, FirstName = "Saliha" }; // same lastname and salary as the employeeRec1, but different firstname and id
Console.WriteLine(employeeRec3);



// if we have a requirement to compare two employee objects based on values stored within the objects,
// a record type is easier to use for this purpose than a class.
// No additional comparison code is necessary. This functionality is all built into the record type feature

// Code is also synthesized for the record type. For example if you write the employeeRec1 object to the screen,
// it automatically writes out the relevant arguments passed to the relevant record type during the insansiation process.
// to achive this functionality using a class, you need to manually override the toString method.

/*
public override string ToString()
{
	return $"Employee id= {_id} First Name = {_firstName} Last Name = {_lastName} Salary = {_salary}";
}
*/

// On record type, you can create an object base on another object and one or many of the new objects properties
// on one line of code using the word "with" keyword

