using AlertMsg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlertMsg.Models;

namespace AlertMsg.Controllers
{
    public class AlertController:Controller
    {
        private readonly AlertContext _context1;

        public AlertController(AlertContext context)
        {
            _context1 = context;
        }
        
        [HttpGet("alert/all")]
        public IEnumerable<AlertModel> GetAlerts()
        {
            return _context1.Alerts.ToList();
        }

        [HttpPost("alert")]
        public ActionResult AddAlert([FromBody] AlertModel a)
        {            
            _context1.Alerts.Add(a);
            _context1.SaveChanges();

            return new RedirectResult(@"~\AlertMessage\");
        }

        [HttpPut("alert/id")]
        public void updateAlert(int id, [FromBody] AlertModel a)
        {
            AlertModel alerts = _context1.Alerts.FirstOrDefault((s) => s.Id == id);
            alerts.Alerttype = a.Alerttype;
            alerts.AlertMsg = a.AlertMsg;
            alerts.UserId= a.UserId;
            
            _context1.SaveChanges();
        }

        [HttpDelete("alert/id")]
        public void deleteAlert(int id)
        {
            AlertModel a = _context1.Alerts.FirstOrDefault((s) => s.Id == id);
            _context1.Remove(a);
            _context1.SaveChanges();
        }

    }
}

