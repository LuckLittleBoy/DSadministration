using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Models
{
    public partial class Medicine
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string DOSAGE { get; set; }
        public string MOLECULES { get; set; }
        public int STOCK_NUM { get; set; }
        public string PROADRESS { get; set; }
        public string LOTSELL_PRICE { get; set; }
        public string SELL_PRICE { get; set; }
        public string REMARKS { get; set; }
        public Nullable<int> NUMBER { get; set; }
    }
}
