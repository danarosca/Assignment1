using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using WindowsFormsApp2;
namespace WindowsFormsApp2.Bussiness
{
    public class RegistrationCore
    {

        
        public bool addClient(string name,string idNr,string PNC,string address,string registrationNr,string password)

        {
            using (var db = new ElectricaEntities1())
            {

                var query = from b in db.ClientNumbers
                            where b.clientNr == registrationNr
                            select b;
             
                if(query.Count()==1)
                {
                    
                    db.Users.Add(new User(-1, "client",registrationNr,name,password));
                    db.SaveChanges();
                    var getId = from b in db.Users
                                where b.registrationNr == registrationNr
                                select b;
                    if(getId.Count()<1)
                    {
                        return false;
                        Console.WriteLine("New client wasn't added");
                    }
                    else
                    {
                        var aux = getId.FirstOrDefault<User>();
                        db.Clients.Add(new Client(1, name,idNr, PNC, address, aux.id));
                        db.SaveChanges();
                        return true;
                    }
                              

                }
                else
                {
                    Console.WriteLine("client nr not found");
                    return false;
                }

            }

        }
    }
}
