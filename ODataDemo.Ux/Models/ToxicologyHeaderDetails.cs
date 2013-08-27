using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataDemo.Ux.Models
{
    public class ToxicologyHeaderDetails
    {
        public int uarID { get; set; }
        public int uarLngCltID { get; set; }
        public int uarSchedID { get; set; }
        public System.DateTime uarDropDt { get; set; }
        public System.DateTime uarResultDt { get; set; }
        public string uarCreatedBy { get; set; }
        public System.DateTime uarCreatedDt { get; set; }

        public int uardID { get; set; }
        public int uardRecID { get; set; }
        public string uardResult { get; set; }
        public bool uardRX { get; set; }
        public string uaDetail { get; set; }

    }
}