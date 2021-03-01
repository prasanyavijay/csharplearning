using AlertMsg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlertMsg.Models;

namespace AlertMsg.Controllers
{
    public class UserController
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        [HttpGet("user/all")]
        public IEnumerable<UserModel> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpPost("user")]
        public void Adduser([FromBody] UserModel u)
        {
            _context.Users.Add(u);
            _context.SaveChanges();
        }

        [HttpPut("user/id")]
        public void updateuser(int id, [FromBody] UserModel u)
        {
            UserModel users = _context.Users.FirstOrDefault((s) => s.Id == id);
            users.UserName = u.UserName;
            users.Specialization = u.Specialization;
            users.MobileNo = u.MobileNo;
            _context.SaveChanges();
        }

        [HttpDelete("user/id")]
        public void deleteusers(int id)
        {
            UserModel u = _context.Users.FirstOrDefault((s) => s.Id == id);
            _context.Remove(u);
            _context.SaveChanges();
        }

    }
}

