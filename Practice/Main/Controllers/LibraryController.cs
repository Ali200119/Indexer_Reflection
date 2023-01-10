using System;
using Domain.Models;

namespace Main.Controllers
{
	public class LibraryController
	{
		public void Show()
		{
			Book book1 = new Book { Id = 1, Name = "Xosrov ve Shirin"};
            Book book2 = new Book { Id = 2, Name = "7 Gozel" };

			Library library = new Library();

			library[0] = book1;
			library[1] = book2;

			Console.WriteLine(library[0].Name);
            Console.WriteLine(library[1].Name);
        }
	}
}