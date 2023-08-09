using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoaAuthor = new Repository<Author>();


        // Tüm yazar listesini getirme
        public List<Author> GetAll()
        {
            return repoaAuthor.List();
        }

        // Yeni yazar ekleme
        public int AddAuthorBL(Author p)
        {
            // Parametreden gönderilen değerlerin gçerliliğinin kontrolü
            if(p.AuthorName =="" || p.AboutShort=="" || p.AuthorTitle == "")
            {
                return -1;
            }

            return repoaAuthor.Insert(p);
        }


        public Author FindAuthor(int id)
        {


            return repoaAuthor.Find(x => x.AuthorID == id);


        }

        public int EditAuthor(Author p)
        {
            Author author = repoaAuthor.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;   
            author.AuthorTitle = p.AuthorTitle; 
            author.AuthorAbout=p.AuthorAbout;   
            author.AuthorImage=p.AuthorImage;   
            author.AboutShort=p.AboutShort; 
            author.Password=p.Password; 
            author.PhoneNumber=p.PhoneNumber;   
            author.Mail=p.Mail;

            return repoaAuthor.Update(author);

            
        }
    }
}
