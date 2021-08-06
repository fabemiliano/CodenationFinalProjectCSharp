using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CodenationFinalProject.Models;
using CodenationFinalProject.Repository;
using CodenationFinalProject.Services;
using CodenationFinalProject.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodenationFinalProject.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsers repo;
        private readonly IMapper mapper;
        public UsersController(IUsers repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<UsersDTO> Get()
        {
            return repo.GetAll().Select(x => mapper.Map<UsersDTO>(x)).ToList();
        }


        [HttpPost]
        [Route("login")]
        [AllowAnonymous]

        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Users user)
        {
            var foundUser = repo.getByEmail(user.Email);

            if (foundUser == null) return NotFound();
            var token = TokenService.GenerateToken(foundUser);

            return new
            {
                user = foundUser.Email,
                token = token
            };
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public Users GetById(int id)
        {
            return repo.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public UsersDTO Post([FromBody] Users value)
        {
            var entry = repo.CreateNew(value);

            return mapper.Map<UsersDTO>(entry);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Users Put([FromBody] Users value)
        {
            var entry = repo.Update(value);
            return entry;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Users Delete(int id)
        {
            var entry = repo.Delete(id);
            return entry;
        }
    }
}
