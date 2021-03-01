using AlertMsg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AlertMsg.Models;

namespace AlertMsg.Controllers
{
    public class AlertMessageController
    {
        private readonly AlertMessageContext _context1;
        public AlertMessageController(AlertMessageContext context)
        {
            _context1 = context;
        }

        [HttpGet("alertMessage/all")]
        public IEnumerable<AlertSetting> GetAlertMessage()
        {
            return _context1.AlertMsgs.ToList();
        }

        [HttpPost("alertMessage")]
        
        public void AddAlert([FromBody] AlertModel a)
        {            
            _context1.Alerts.Add(a);
           // var n =_context1.Users.FirstOrDefault((s)=>s.MobileNumber )  tried

         //   UserModel a=_context1.Users.FirstOrDefault((s) => s.Id=a.);
            _context1.SaveChanges();


        }
        [HttpPut("alertMessage/mobile")]
        public void updateAlertMessage(string MobileNo, [FromBody] AlertSetting a)
        {
            AlertSetting alerts = _context1.AlertMsgs.FirstOrDefault((s) => s.MobileNumber.Equals(MobileNo));
            alerts.AlertId = a.AlertId;
            alerts.msg = a.msg;
            _context1.SaveChanges();
        }

        [HttpDelete("alertMessage/id")]
        public void deleteAlertMessage(string MobileNo)
        {
            AlertSetting a = _context1.AlertMsgs.FirstOrDefault((s) => s.MobileNumber.Equals(MobileNo));
            _context1.Remove(a);
            _context1.SaveChanges();
        }
    

    }

}

