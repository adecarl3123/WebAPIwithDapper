using ProjectName.Models;
using ProjectName.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Services
{
    public class BookService
    {
        public BookService() 
        { 
            
        }

        public IEnumerable<Book> GetAll()
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.GetbyId(id);
        }
        public bool Add(Book book)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.Add(book);
        }

        public bool Delete(int id)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.Delete(id);
        }
        public bool Updatet(Book book)
        {
            BookRepository bookRepository = new BookRepository();
            return bookRepository.Update(book);
        }


    }
}
