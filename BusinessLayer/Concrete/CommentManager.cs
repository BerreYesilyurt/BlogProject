using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;
        Repository<Comment> repocomment=new Repository<Comment>();

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> CommentList()
        {
            return repocomment.List();
        }

        public List<Comment> CommentByStatusTrue()
        {

            return _commentDal.List(x => x.CommentStatus == true);
        }

        public List<Comment> CommentBybLog(int id)
        {
            return _commentDal.List(x => x.BlogID == id);
        }

        public void CommentStatusChangeToFalse(int id)
        {
            Comment comment = _commentDal.Find(x=>x.CommentID==id);
            comment.CommentStatus= false;
            _commentDal.Update(comment);

        }

        public List<Comment> CommentStatusFalse()
        {
            return repocomment.List(x=>x.CommentStatus==false); 
        }

        public void CommentStatusChangeToTrue(int id)
        {
            Comment comment2=_commentDal.Find(x=>x.CommentID==id);      
            comment2.CommentStatus= true;
            repocomment.Update(comment2);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public void CommenttAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void CommentDelete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void CommentUpdate(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
