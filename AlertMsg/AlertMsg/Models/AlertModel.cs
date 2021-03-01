using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlertMsg.Models
{
    public class AlertModel
    {
        public int Id { get; set; }
        public string Alerttype {get; set;}
        public string AlertMsg { get; set; }
        public int UserId { get; set; }

    }
}
