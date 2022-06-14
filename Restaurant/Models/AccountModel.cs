using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq

namespace Models
{
    public class AccountModel
    {
        private Model1 context = null;
        public AccountModel()   
        {
            context = new Model1();
        }
        public bool Login(string username, string password)
        {
            var res = context.Database.SqlQuery<bool>("");
        } 
    }
}
