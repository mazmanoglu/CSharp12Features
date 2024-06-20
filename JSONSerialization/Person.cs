using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSONSerialization
{
	public class Person
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		[JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
		public List<string> MiddleNames { get; } = new List<string>();// we didnt use set, thats why normally we couldnt see the result. to solve this problem instead write set; use Json.

		// new in JSON
		// - Populate read-only properties
		// - Additional naming policies
		// - support for additional types
		// - source generators for AOT
	}
}
