using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class todo
    {
        public int id { get; set; }
        public string titel { get; set; }
        public string content { get; set; }
        public DateTime time { get; set; }
        public bool cheked { get; set; }


    }
}
