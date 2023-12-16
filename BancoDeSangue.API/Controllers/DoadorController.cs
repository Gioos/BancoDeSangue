using BancoDeSangue.API.Entities;
using BancoDeSangue.API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangue.API.Controllers
{
    [Route("api/v1/doadores")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly DoadorDbContext _context;
        public DoadorController(DoadorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var doador = _context.Doadores.ToList();
            return Ok(doador);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var doador = _context.Doadores.SingleOrDefault(d => d.Id == id);
            if (doador == null)
                return NotFound();

            return Ok(doador);
        }

        [HttpPost]
        public IActionResult Post(Doador doador)
        {
            _context.Doadores.Add(doador);
            return CreatedAtAction(nameof(GetById), new {id = doador.Id}, doador);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Doador dados)
        {
            var doador = _context.Doadores.SingleOrDefault(d => d.Id==id);
            if (doador == null)
                return NotFound();

            doador.Update(dados.Email, dados.Peso);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id) 
        {
         var doador = _context.Doadores.SingleOrDefault(d=> d.Id==id);
            if (doador == null)
                return NotFound();

            doador.Delete();
            return NoContent();
        }

    }
}
