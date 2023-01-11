using System;
namespace Service.Helpers.Exceptions
{
	public class ExistedEmailException: Exception
	{
		public ExistedEmailException(string message) : base(message) { }
	}
}

