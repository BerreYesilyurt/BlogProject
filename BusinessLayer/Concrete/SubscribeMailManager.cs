﻿using BusinessLayer.Abstract;
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
    public class SubscribeMailManager:IMailService
    {
        IMailDal _mailDal;
        Repository<SubscribeMail> reposubscribemail=new Repository<SubscribeMail>();

        public SubscribeMailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }
        public SubscribeMail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubscribeMail> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubscribeMail t)
        {
            _mailDal.Insert(t); 
        }

        public void TDelete(SubscribeMail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubscribeMail t)
        {
            throw new NotImplementedException();
        }
    }
}
