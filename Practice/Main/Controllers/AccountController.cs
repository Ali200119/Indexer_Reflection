using System;
using Service.Services;
using Service.Services.Interfaces;

namespace Main.Controllers
{
	public class AccountController
	{
		private readonly IAccountService _account;

		public AccountController()
		{
			_account = new AccountService();
		}

		public void Authentication()
		{
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("------- Welcome -------\n");
			Console.ResetColor();

			Registration: Console.Write("Please enter username: ");

			string username = Console.ReadLine();

			Console.Write("Now enter email: ");

			string email = Console.ReadLine();

			Console.Write($"{username}, create strong password: ");

			string password = Console.ReadLine();

			Console.WriteLine(_account.Register(username, email, password));
		}
	}
}