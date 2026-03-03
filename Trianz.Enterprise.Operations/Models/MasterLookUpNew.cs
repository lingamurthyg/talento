using System;

namespace Trianz.Enterprise.Operations.Models
{

    public class MasterLookUpNew
    {

        public long LookupID { get; set; }
        public string ApplicationCode { get; set; }
        public string LookupCode { get; set; }
        public string LookupType { get; set; }
        public string LookupName { get; set; }
        public string Description { get; set; }
        public int SeqNumber { get; set; }
        public string ParentCode { get; set; }
        public string ParentName { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
      
    }
    


}