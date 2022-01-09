using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> reposubscribemail = new Repository<SubscribeMail>();
        public int BLAdd(SubscribeMail p)
        {
            //@gmail.com
            if(p.Mail.Length<=10 || p.Mail.Length >= 50)
            {
                return -1; //işlemi gerçekleştirmek icin
            }
            return reposubscribemail.Insert(p);
        }
    }
}
//subscribeyi abstracta dahil etmedim çünkü sadece kaydetme işlemi var.

