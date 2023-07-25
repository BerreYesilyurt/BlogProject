using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repocomment=new Repository<Comment>();

        public List<Comment> CommentList()
        {
            return repocomment.List();
        }

        public List<Comment> CommentBybLog(int id)
        {
            return repocomment.List(x => x.BlogID == id);
        }

        public int CommentAdd(Comment c)
        {
            //Yorum yapma kriterleri
            if (c.CommentText.Length<=4 || c.CommentText.Length>=301 || c.UserName=="" || c.Mail=="" || c.UserName.Length <= 5)
            {
                return -1; /*İşlemi yapma*/
            }

            return repocomment.Insert(c); /*Aksi halde c'den gelen değeri ekle*/


        }
    }
}
