using System;
namespace Service.Services.Interfaces
{
	public interface IAccountService
	{
		string Register(string username, string email, string password);
	}
}