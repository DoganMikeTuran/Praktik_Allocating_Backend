﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_4.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend_4.Controllers
{
    [Route("apiaa/[controller]")]
    public class UserController : Controller
    {
        private readonly DB_context _context;
        public UserController(DB_context context) {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _context.User.ToListAsync();
        }

        // Hvis man vil vise alle users (id,firstname,lastname m.v)
        //{
        //    var numbers = new List<String>();
        //    foreach(User element in await _context.User.ToListAsync())
        //    {
        //        numbers.Add(element.firstname);
        //    }
        //    return numbers;
        //}



// GET api/values/5
[HttpGet("{id}")]
        public async Task<User> GetUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            //if (user == null) {
                
            //}
            return user;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User user)
        {
            using (DB_context db = new DB_context())
            {
                db.User.Add(user);
                db.SaveChanges();
            }

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
