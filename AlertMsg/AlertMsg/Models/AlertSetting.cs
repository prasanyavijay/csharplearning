using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlertMsg.Models
{
    public class AlertSetting
    {
        public string MobileNumber { get; set; }
        public string AlertId { get; set; }        
        public string msg { get; set; }

        public ICollection<AlertModel> AlertModels { get; set; }

    }


}
