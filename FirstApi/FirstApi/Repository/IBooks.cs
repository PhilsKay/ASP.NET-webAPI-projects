using FirstApi.model;

namespace FirstApi.Repository
{
    public interface IBooks
    {
        List<Book> GetBooks();  

        Book GetBook(int id);   
        Book AddBook(Book book);
        void UpdateBook(Book book); 
        void DeleteBook(int id);
    }
}
