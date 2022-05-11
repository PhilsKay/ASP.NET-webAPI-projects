using FirstApi.data;
using FirstApi.model;
using FirstApi.Repository;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FirstApi.BookData
{
    public class Bookdata : IBooks
    {
        private readonly context _context;
        public Bookdata(context context)
        {
            _context = context; 
        }
        public Book AddBook(Book book)
        {
           _context.Book.Add(book);
            _context.SaveChanges(); 
            return book;
        }

        public void DeleteBook(int id)
        {
            var book = _context.Book.Find(id);
            _context.Book.Remove(book);
            _context.SaveChanges();
        }

        public Book GetBook(int id)
        {
            return _context.Book.Find(id);    
        }

        public List<Book> GetBooks()
        {
            return _context.Book.ToList();
        }

        public void UpdateBook( Book book)
        {
            _context.Book.Update(book);
                _context.SaveChanges();

        }
    }
}
