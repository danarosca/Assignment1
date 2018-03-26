using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Bussiness
{
    public abstract  class Core
    {
        protected User user;

        public abstract bool insert( object obj);
        public abstract bool update(object obj);
        public abstract bool delete(object obj);




    }
}
