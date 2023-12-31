﻿using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PlanController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public PlanController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<PersonaController>
        [HttpGet]
        public async Task<IEnumerable<Plan>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Plan);
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public async Task<Plan> Get(int id)
        {
            return await _AcademiaContext.Plan.SingleOrDefaultAsync(x => x.idPlan == id);
        }

        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody] Plan plan)
        {
        _AcademiaContext.Plan.Add(plan);
        _AcademiaContext.SaveChanges();
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Plan plan)
        {
            var item = _AcademiaContext.Plan.FirstOrDefault(x=> x.idPlan==id);
            if(item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Plan.Update(plan);
                _AcademiaContext.SaveChanges();
            }
            
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Plan.FirstOrDefault(x=>x.idPlan==id);
            if (item!=null)
            {
                _AcademiaContext.Plan.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }
    }
}
