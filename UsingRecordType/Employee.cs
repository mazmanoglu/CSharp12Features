namespace UsingRecordType
{
	public record EmployeeRec(int Id, string FirstName, string LastName, decimal Salary);

	public class Employee
	{
		private readonly int _id;
		private readonly string _firstName;
		private readonly string _lastName;
		private readonly decimal _salary;

		public Employee(int id, string firstName, string lastName, decimal salary)
		{
			_id = id;
			_firstName = firstName;
			_lastName = lastName;
			_salary = salary;
		}
		public int Id { get { return _id; } }
		public string FirstName { get { return _firstName; } }
		public string LastName { get { return _lastName; } }
		public decimal Salary { get { return _salary; } }

		//public override string ToString()
		//{
		//	return $"Employee id= {_id} First Name = {_firstName} Last Name = {_lastName} Salary = {_salary}";
		//}

	}
}
