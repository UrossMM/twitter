using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;
using WebApp1.Models.ViewModels;
using WebApp1.Repositories;

namespace WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private IJWTManagerRepository _repository;

        public UsersController(IJWTManagerRepository r)
        {
            _repository = r;
        }

        [HttpGet]
        [Route("userlist")]
        public List<string> Get()
        {
            var users = new List<string>
            {
                "Satinder singh",
                "Amit Sarna",
                "David John"
            };

            return users;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(Users userdata)
        {
            var token = _repository.Authenticate(userdata);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

       /* [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] UsersVM user)
        {
            _repository.AddNewUser(user);
            return Ok();
        }*/
    }
}
