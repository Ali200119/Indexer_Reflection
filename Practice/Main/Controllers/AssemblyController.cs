using System;
using System.Reflection;

namespace Main.Controllers
{
	public class AssemblyController
	{
		public void ShowDatasViaAssembly()
		{
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (var item in assembly.GetTypes())
            {
                foreach (var item2 in item.GetMembers())
                {
                    Console.WriteLine(item2);
                }
            }
        }
	}
}