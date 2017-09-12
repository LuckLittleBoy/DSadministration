using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Models
{
    public partial class STOCK
    {
        public string DRUG_ID { get; set; }
        public string DRUG_NAME { get; set; }
        public double DRUG_DOSAGE { get; set; }
        public string DRUG_PROADRESS { get; set; }
        public int DRUG_PACK_NUM { get; set; }
        public int DRUG_STOCK_NUM { get; set; }
        public string DRUG_MOLECULES { get; set; }
        public string DRUG_EFFECTIVE_DATE { get; set; }
        public string DRUG_LOT_NUM { get; set; }
        public string DRUG_CATEGORY { get; set; }
        public string DRUG_SELL_PRICE { get; set; }
        public string DRUG_LOTSELL_PRICE { get; set; }
        public string DRUG_REMARKS { get; set; }
        public string DRUG_OTHERS { get; set; }
    }
}
