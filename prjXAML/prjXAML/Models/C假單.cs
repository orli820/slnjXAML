using System;
using System.Collections.Generic;
using System.Text;

namespace prjXAML.Models
{
    public class C假單
    {
        public int id { get; set; }
        public string 申請人{ get; set; }
        public string 核可人 { get; set; }
        public string 理由 { get; set; }
        public string 日期 { get; set; }
        public bool 核可 { get; set; }     
    }
}
