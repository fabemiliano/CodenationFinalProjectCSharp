using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CodenationFinalProject.Models;
using CodenationFinalProject.Repository;
using CodenationFinalProject.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodenationFinalProject.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ProcessesController : Controller
    {
        private readonly IError repo;
        private readonly IMapper mapper;
        public ProcessesController(IError repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<ErrorDTO> Get()
        {
            return repo.GetAll().Select(x => mapper.Map<ErrorDTO>(x)).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Error GetById(int id)
        {
            return repo.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public Error Post([FromBody] Error value)
        {
            var entry = repo.CreateNew(value);
            return entry;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Error Put([FromBody] Error value)
        {
            var entry = repo.Update(value);
            return entry;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Error Delete(int id)
        {
            var entry = repo.Delete(id);
            return entry;
        }
    }
}
