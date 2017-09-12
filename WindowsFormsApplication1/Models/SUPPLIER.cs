using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Models
{
    public partial class SUPPLIER
    {
        public SUPPLIER()
        {
            this.INSTOCKs = new List<INSTOCK>();
        }

        public string SUPPLIER_ID { get; set; }
        public string SUPPLIER_NAME { get; set; }
        public string SUPPLIER_ADRESS { get; set; }
        public string SUPPLIER_CONTACTER { get; set; }
        public string SUPPLIER_TEL { get; set; }
        public string SUPPLIER_REMARKS { get; set; }
        public string SUPPLIER_OTHERS { get; set; }
        public virtual ICollection<INSTOCK> INSTOCKs { get; set; }
    }
}
