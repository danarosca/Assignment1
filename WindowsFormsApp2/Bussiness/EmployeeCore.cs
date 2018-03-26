using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp2.DataB;

namespace WindowsFormsApp2.Bussiness
{
    public class EmployeeCore:Core
    {
        public EmployeeCore(User user)
        {
            this.user = user;
        }
        public EmployeeCore()
        {
            
        }

        public bool  insertNr(string number)
        {
            using (Dao db = new Dao())
            {
                return db.insertClientNr(number);
            }
            

           
        }

        public bool approveRequest(int id)
        {
            if (id < 0)
                return false;
            else
            {
                using (Dao db = new Dao())
                {
                    return db.markApproved(id);
                }
            }
        }
        public List<Client> getClients()
        {
            using (Dao db = new Dao())
            {
                return (db.getClients());
            }
        }
        public  override bool insert(object obj)
        {
            using (Dao db = new Dao())
            {
                db.insertInDao(obj);
            }

            return true;
        }

        public override Boolean update(object obj)
        {
            using (Dao db = new Dao())
            {
                db.updateRecord(obj);
            }

            return true;
        }
        public override Boolean delete(object obj)
        {
            using (Dao db = new Dao())
            {
                db.delete(obj);
            }

            return true;
            
        }

        public List<Complaint> getComplaintsPending()
        {
            return (getComplaints().Where(b => b.status.Contains("waiting"))).ToList();
        }
        public List<Complaint> getComplaints()
        {
            using (Dao db = new Dao())
            {
                return (db.getComplaints()).ToList();
            }
        }

    }
}
