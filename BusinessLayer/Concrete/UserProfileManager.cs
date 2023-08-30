using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repouser = new Repository<Author>();
        Repository<Blog> repoblog = new Repository<Blog>();

        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List(x => x.Mail == p);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoblog.List(x=>x.AuthorID == id);  
        }

        public int EditAuthor(Author p)
        {
            Author author = repouser.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorImage = p.AuthorImage;
            author.AboutShort = p.AboutShort;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;
            author.Mail = p.Mail;

            return repouser.Update(author);


        }
    }
}
