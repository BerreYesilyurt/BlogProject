﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();

        public int BLContactAdd(Contact c)
        {
            if(c.Mail=="" || c.Message=="" || c.Name=="" || c.Surname=="" || c.Subject=="" || c.Mail.Length<=10 || c.Subject.Length<= 3)
            {
                return -1;

            }

            return repocontact.Insert(c);
        }

        public List<Contact> GelAll()
        {
            return repocontact.List();
        }

        public Contact GetContactDetails(int id)
        {
            return repocontact.Find(x=>x.ContactID==id);    
        }
    }
}