using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.DataB;

namespace WindowsFormsApp2.Bussiness
{
    public class LoginCore
    {

        public LoginCore()
        {

        }
        public  User checkUser(string username,string password)
        {
            if(username!="" &&password!="")
            {
                using (Dao db = new Dao())
                {
                    return db.checkUser(username, password);
                    
                }
            }
            else
            {
                Console.WriteLine("Error.User not found");
                return null;
            }

        }
    }
}
