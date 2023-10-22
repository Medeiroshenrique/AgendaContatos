using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaAPI.Context;
using AgendaAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context) {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Contato contato) { 
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id) {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato); 
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato) {
            var contatoNoBanco = _context.Contatos.Find(id);

            if (contatoNoBanco == null) {
                return NotFound();
            }
            contatoNoBanco.Nome = contato.Nome;
            contatoNoBanco.Telefone = contato.Telefone;
            contatoNoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoNoBanco);
            _context.SaveChanges();

            return Ok(contatoNoBanco);
        }
    }
}
