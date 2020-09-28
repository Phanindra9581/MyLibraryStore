using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void Create(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1, BookName="Wings of Fire", Author="APJ Kalam", ISBN="IS14678", PublishedDate=Convert.ToDateTime("10/12/2012")},
                new Book{Id=2, BookName="World India", Author="Rufson", ISBN="IS14322", PublishedDate=Convert.ToDateTime("12/05/2017")},
                new Book{Id=3, BookName="2 States", Author="Chetan Bhagat", ISBN="IS13278", PublishedDate=Convert.ToDateTime("05/07/2012")},
            };
        }

        public void Update(int? id, Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(int? id, Book book)
        {
            throw new NotImplementedException();
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
