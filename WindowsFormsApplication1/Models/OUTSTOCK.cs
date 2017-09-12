using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Models
{
    public partial class OUTSTOCK
    {
        public string OUTSTOCK_ID { get; set; }
        public string FK_DRUG_ID { get; set; }
        public string OUTSTOCK_DATE { get; set; }
        public double OUTSTOCK_SELLPRICE { get; set; }
        public string FK_CLIENT_ID { get; set; }
        public string FK_STAFF_ID { get; set; }
        public string OUTSTOCK_REMARKS { get; set; }
        public string OUTSTOCK_OTHERS { get; set; }
        public virtual CLIENT CLIENT { get; set; }
        public virtual STAFF STAFF { get; set; }
    }
}
