using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassLibraryUpdates
{
	public class Adult : Person
	{
		private int _age = 18;
		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfLessThan(value, 18);
			}
		}
	}
}
