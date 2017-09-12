using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Models
{
    public partial class INSTOCK
    {
        public string INSTOCK_ID { get; set; }
        public string FK_DRUG_ID { get; set; }
        public string INSTOCK_DATE { get; set; }
        public string INSTOCK_PROOF_ID { get; set; }
        public int INSTOCK_NUM { get; set; }
        public string FK_SUPPLIER_ID { get; set; }
        public string INSTOCK_LOTBUY_PRICE { get; set; }
        public string FK_STAFF_ID { get; set; }
        public string INSTOCK_REMARKS { get; set; }
        public string INSTOCK_OTHERS { get; set; }
        public string FK_DRUG_NAME { get; set; }
        public string INSTOCK_SELL_PRICE { get; set; }
        public virtual STAFF STAFF { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
