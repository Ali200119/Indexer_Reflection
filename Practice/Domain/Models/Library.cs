using System;
using Domain.Commons;

namespace Domain.Models
{
	public class Library: BaseEntity
	{
		public string Name { get; set; }
		private Book[] _books;

		public Library(int size = 70)
		{
			_books = new Book[size];
		}

		public Book this[int index]
		{
			get
			{
				return _books[index];
			}

			set
			{
				_books[index] = value;
			}
		}
	}
}