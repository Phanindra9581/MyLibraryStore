using MyLibraryStore.Data;
using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _dbContext = null;

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Book book)
        {
            throw new NotImplementedException();
        }

        public void CreateBook(Book book)
        {

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int? id)
        {
            var BookDb = _dbContext.Books.SingleOrDefault(x => x.Id == id.Value);
            _dbContext.Books.Remove(BookDb);
            _dbContext.SaveChanges();
        }

        public Book GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void UpdateBook(int? id, Book book)
        {
            var BookDb = _dbContext.Books.SingleOrDefault(x => x.Id == id.Value);
            BookDb.BookName = book.BookName;
            BookDb.Author = book.Author;
            BookDb.ISBN = book.ISBN;
            BookDb.PublishedDate = book.PublishedDate;

            _dbContext.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}

