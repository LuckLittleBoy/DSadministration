using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Models
{
    public partial class SELL
    {
        public string SELL_ID { get; set; }
        public string SELL_PROOF_ID { get; set; }
        public string DRUG_ID { get; set; }
        public string DRUG_MOLECULES { get; set; }
        public int SELL_NUM { get; set; }
        public double SELL_SINGLE_PRICE { get; set; }
        public double SELL_SUM_PRICE { get; set; }
        public string SELL_REMARKS { get; set; }
        public string SELL_OTHERS { get; set; }
    }
}
