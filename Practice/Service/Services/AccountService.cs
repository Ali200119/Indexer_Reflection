using System;
using Service.Helpers.Constants;
using Service.Helpers.Exceptions;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public string Register(string username, string email, string password)
        {
            try
            {
                foreach (string databaseEmail in GetUsers())
                {
                    if (databaseEmail == email)
                    {
                        throw new ExistedEmailException(ResponseMessages.UsedEmail);
                    }
                }

                GetUsers().Add(email);

                Console.ForegroundColor = ConsoleColor.Green;
                return ResponseMessages.SuccessRegister;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return ex.Message;
            }
        }

        private List<string> GetUsers()
        {
            return new List<string> { "aliit@code.edu.az", "test1.23@gmail.com" };
        }
    }
}