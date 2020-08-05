using AutoMapper;
using BioFortStat.Dto;
using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace BioFortStat.Controllers.API
{
    public class UserInfoController : ApiController
    {
        private ApplicationDbContext _context;

        public UserInfoController()
        {
            _context = new ApplicationDbContext();
        }



        // GET /api/userinfo
        public IHttpActionResult GetUser()
        {
            var userDtos = _context.Userz
                .Select(Mapper.Map<UserInformation, UserInfoDto>);
            return Ok(userDtos);
        }

        // GET /api/userinfo/1
        public IHttpActionResult GetUser(int id)
        {
            var user = _context.Userz.SingleOrDefault(u => u.Id == id);

            if (user == null) return NotFound();

            return Ok(Mapper.Map<UserInformation, UserInfoDto>(user));
        }

       // POST /api/userinfo
       [HttpPost]
        public IHttpActionResult CreateUser(UserInfoDto userDto)
        {

            userDto.DateCreated = DateTime.Now;
            // Session["FirstName"] = userDto.FirstName;
            // Session["LastName"] = userDto.LastName;
            try
            {
                if (!ModelState.IsValid) return BadRequest();

                var user = Mapper.Map<UserInfoDto, UserInformation>(userDto);
                _context.Userz.Add(user);
                _context.SaveChanges();
                userDto.Id = user.Id;




                return Created(new Uri(Request.RequestUri + "/" + user.Id), new { userDto, value = 1, msg = " Successful Basic Information" });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Data);
            }

            return Ok();
        }

     //   PUT /api/userinfo/1
        [HttpPut]
        public IHttpActionResult UpdateUser(int id, UserInformation userDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var userInDb = _context.Userz.SingleOrDefault(u => u.Id == id);

            if (userInDb == null) return NotFound();

            Mapper.Map(userDto, userInDb);

            

             _context.SaveChanges();
           
            return Ok();
            
        }

        // DELETE /api/userinfo/1
        [HttpDelete]
        public IHttpActionResult DeleteUser(int id)
        {
            var userInDb = _context.Userz.SingleOrDefault(u => u.Id == id);
            if (userInDb == null) return NotFound();

            _context.Userz.Remove(userInDb);
            _context.SaveChanges();
            
            return Ok();
        }

      
     

    }
}
