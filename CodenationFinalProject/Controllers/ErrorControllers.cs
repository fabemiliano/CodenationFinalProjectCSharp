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
        private readonly IProcesses repo;
        private readonly IMapper mapper;
        public ProcessesController(IProcesses repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<ProcessesDTO> Get()
        {
            return repo.GetAll().Select(x => mapper.Map<ProcessesDTO>(x)).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Processes GetById(int id)
        {
            return repo.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public Processes Post([FromBody] Processes value)
        {
            var entry = repo.CreateNew(value);
            return entry;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Processes Put([FromBody] Processes value)
        {
            var entry = repo.Update(value);
            return entry;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Processes Delete(int id)
        {
            var entry = repo.Delete(id);
            return entry;
        }
    }
}
