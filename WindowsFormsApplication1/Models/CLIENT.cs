using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Models
{
    public partial class CLIENT
    {
        public CLIENT()
        {
            this.OUTSTOCKs = new List<OUTSTOCK>();
        }

        public string CLIENT_ID { get; set; }
        public string CLIENT_NAME { get; set; }
        public string CLIENT_ADRESS { get; set; }
        public string CLIENT_CONTACTER { get; set; }
        public string CLIENT_TEL { get; set; }
        public string CLIENT_REMARKS { get; set; }
        public string CLIENT_OTHERS { get; set; }
        public virtual ICollection<OUTSTOCK> OUTSTOCKs { get; set; }
    }
}
