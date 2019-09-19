using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gestao_livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        // GET api/livros
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/livros/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Livro v_Livro = new Livro();
            List<Livro> v_ListaLivros = new List<Livro>();

            v_ListaLivros = v_Livro.ListaLivros();

            v_Livro = v_ListaLivros.SingleOrDefault(q => q.Id == id);

            return "Livro encontrado: Identificador: " + v_Livro.Id + "\n                   Nome: " + v_Livro.Nome ;
        }

        // POST api/livros
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/livros/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/livros/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
