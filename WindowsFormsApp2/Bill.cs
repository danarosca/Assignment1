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
    
    public partial class Bill
    {
        public Bill(int id, int total, bool paid, int clientId)
        {
            this.id = id;
            this.total = total;
            this.paid = paid;
            this.clientId = clientId;
        }
        public Bill()
        {

        }
        public int id { get; set; }
        public int total { get; set; }
        public bool paid { get; set; }
        public int clientId { get; set; }
    }
}
