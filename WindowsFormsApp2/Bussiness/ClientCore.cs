using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp2.DataB;
namespace WindowsFormsApp2.Bussiness
{
    public class ClientCore:Core
    {
        public override Boolean update(object obj)
        {
            return true;
        }
        public override Boolean delete(object id)
        {
            return true;
        }

        public bool updateComplaint(Complaint newC)
        {
            if (newC != null)
                using (Dao db = new Dao())
                {
                    db.updateRecord(newC);
                    return true;
                }
            else
            {
                return false;
            }
        }

        public int getUserId()
        {
            return this.user.id;
        }
        public List<Complaint> checkComplaints()
        {
            using (Dao db = new Dao())
            {
                return db.getComplaints(user.id);
            }
        }
        public bool addComplaint(string input)
        {
            if (input != "")
                using (Dao db = new Dao())
                {
                    db.fileComplaint(input,this.user);
                    return true;
                }
            else
            {
                return false;
            }
        }
    
    
    
        public ClientCore(User user)
        {
            this.user = user;

        }
        public override bool insert(object selected)
        {
          
                return true;

        }
        public List<Bill> getBills(bool paid)
        {
            using (var dao = new Dao())
            {
                return dao.getBills(this.user.id,paid);
            }
        }
        public bool payBill(int id)
        {
            if(id<0)
            {
                return false;
            }
            else
            {
                using (var dao = new Dao())
                {
                    return dao.payBill(id);
                }
            }
        }

    }
}
