using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoQualidade.Models;
using ProjetoQualidade.Repository;
using ProjetoQualidade.Services;
using ProjetoQualidade.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoQualidade.Controllers
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

        // no controller adicionei uma rota para login

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]

        //o retorno desse método é dinâmico, pois pode retornar diferentes opções, como usuário inválido, senha inválida e tals
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Users user)
        {
            var foundUser = repo.getByEmail(user.Email);

            if (foundUser == null) return NotFound();

            //o token é gerado a partir de uma classe de serviço que contém o objeto gerado pelo JWT
            var token = TokenService.GenerateToken(foundUser);

            // essa é uma forma de retornar um objeto sem precisar usar uma classe pronta (bem interessante!)
            // é importante retornar o token pois o front end consome ele na autorizaçÀO
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
