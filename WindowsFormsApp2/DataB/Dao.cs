using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2.DataB
{
    public class Dao:IDisposable
    {
        public void Dispose()
        {
           
        }
        public List<Complaint> getComplaints(int id)
        {
            using (var db = new ElectricaEntities1())
            {
                var query = from b in db.Complaints
                    where b.clientId == id && b.status.Contains("Approved")
                    select b;
                return query.ToList();
            }
        }
        public bool payBill(int id)
        {
            using (var db = new ElectricaEntities1())
            {
                var query = from b in db.Bills
                            where b.id == id
                            select b;
                if(query.Count()!=1)
                {
                    Console.WriteLine("Too many or no bills with same id");
                    return false;
                }
                else
                {
                    foreach(Bill f in query)
                    {
                        f.paid = true;
                    }
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool fileComplaint(string input, User user)
        {
            using (var db = new ElectricaEntities1())
            {
                Complaint newComplaint=new Complaint(-1,"waiting",-1,-1,-1,input,"",user.id);
                db.Complaints.Add(newComplaint);
                db.SaveChanges();
                return true;
            }
        }
       
        public List<User> getUsers()
        {
            using (var db = new ElectricaEntities1())
            {
                return (from b in db.Users select b).ToList();
            }
        }
        public List<Client> getClients()
        {
            using (var db = new ElectricaEntities1())
            {
                return (from b in db.Clients select b).ToList();
            }
        }

        public bool insertInDao(object obj)
        {
            try {
                using (var db = new ElectricaEntities1())
                {
                    Type type = obj.GetType();
                    dynamic converted = Convert.ChangeType(obj, type);

                    if (type == Type.GetType("WindowsFormsApp2.Client"))
                    {
                        db.Clients.Add(converted);
                        db.SaveChanges();
                    }
                    else if (type == Type.GetType("WindowsFormsApp2.Complaint"))
                    {

                        db.Complaints.Add(converted);
                        db.SaveChanges();

                    }

                }


            }
        
        catch
        {
            return false;
        }

            return true;
        }

        public bool updateRecord(object obj)
        {
            try
            {
                using (var db = new ElectricaEntities1())
                {
                    Type type = obj.GetType();
                    dynamic converted = Convert.ChangeType(obj, type);
                    int id = converted.id;
                    if (type == Type.GetType("WindowsFormsApp2.Client"))
                    {
                        var query = db.Clients.Find(id);
                        db.Entry(query).CurrentValues.SetValues(converted);
                        db.SaveChanges();
                    }
                    else if (type == Type.GetType("WindowsFormsApp2.Complaint"))
                    {
                        var query = db.Complaints.Find(id);
                        db.Entry(query).CurrentValues.SetValues(converted);
                        db.SaveChanges();

                    }

                }


            }

            catch
            {
                return false;
            }

            return true;
        }
        public bool delete(object obj)
        {
            try
            {
                using (var db = new ElectricaEntities1())
                {
                    Type type = obj.GetType();
                    dynamic converted = Convert.ChangeType(obj, type);
                    int id = converted.id;
                    if (type == Type.GetType("WindowsFormsApp2.Client"))
                    {
                        var removed = db.Clients.First(c => c.id == id);
                        db.Clients.Remove(removed);
                        db.SaveChanges();
                        ;

                    }
                    else if (type == Type.GetType("WindowsFormsApp2.Complaint"))
                    {

                        var removed = db.Complaints.First(c => c.id == id);
                        db.Complaints.Remove(removed);
                        db.SaveChanges();

                    }

                }


            }

            catch
            {
                return false;
            }

            return true;
        }

        public bool insertClientNr(string number)
        {
            using (var db = new ElectricaEntities1())
            {
                db.ClientNumbers.Add(new ClientNumber(-1, number));
                db.SaveChanges();
            }

            return true;
        }
        public bool insertClient(Client obj)
        {
            try
            {
                using (var db = new ElectricaEntities1())
                {
                    db.Clients.Add(obj);
                    db.SaveChanges();

                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool markApproved(int id)
        {
            using (var db = new ElectricaEntities1())
            {
                var query = from b in db.Complaints
                    where b.status.Contains("waiting")
                    select b;
                if (query.Count() < 1)
                {
                    return false;

                }
                else
                {
                    Complaint aux=db.Complaints.Single(b =>b.id==id);
                    aux.status = "Approved";
                    db.SaveChanges();
                    return true;
                }
            }
        }
        public List<Complaint> getComplaints()
        {
            using (var db = new ElectricaEntities1())
            {
                return (from b in db.Complaints select b).ToList();
            }
        }
        public List<Bill> getBills(int id,bool paid)
        {
            using (var db = new ElectricaEntities1())
            {
                var query = from b in db.Bills
                            where (b.clientId == id) &&
                            (b.paid==paid)
                            select b;
                return query.ToList();
            }
        }

        public User checkUser(string username, string password)
        {
            using (var db = new ElectricaEntities1())
            {
                var query = from b in db.Users
                            where b.name == username && b.password == password
                            select b;
                if(query.Count()==1)
                {
                    return query.First();
                }
                else
                {
                    
                    return null;
                }
            }
        }
    }
}
