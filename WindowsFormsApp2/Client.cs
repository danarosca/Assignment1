//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public Client(int id, string name, string iDN, string pNC, string address, int userId)
        {
            this.id = id;
            this.name = name;
            IDN = iDN;
            PNC = pNC;
            this.address = address;
            this.userId = userId;
        }
        public Client()
        {

        }
        public int id { get; set; }
        public string name { get; set; }
        public string IDN { get; set; }
        public string PNC { get; set; }
        public string address { get; set; }
        public int userId { get; set; }
    }
}
