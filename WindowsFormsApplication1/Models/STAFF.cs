using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Models
{
    public partial class STAFF
    {
        public STAFF()
        {
            this.INSTOCKs = new List<INSTOCK>();
            this.OUTSTOCKs = new List<OUTSTOCK>();
        }

        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string STAFF_USERNAME { get; set; }
        public string STAFF_PASSWORD { get; set; }
        public string STAFF_IDCARDNUM { get; set; }
        public string STAFF_ADRESS { get; set; }
        public string STAFF_CONTACTER { get; set; }
        public string STAFF_POSITION { get; set; }
        public string STAFF_POWER { get; set; }
        public string STAFF_REMARKS { get; set; }
        public string STAFF_OTHERS { get; set; }
        public virtual ICollection<INSTOCK> INSTOCKs { get; set; }
        public virtual ICollection<OUTSTOCK> OUTSTOCKs { get; set; }
    }
}
