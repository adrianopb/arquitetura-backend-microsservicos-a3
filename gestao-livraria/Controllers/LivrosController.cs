using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gestao_livraria.Controllers
{
//    [Produces(MediaTypeNames.Application.Json)]
    [Route("v1/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        // GET api/livros
        [HttpGet]
//        public ActionResult<IEnumerable<Livro>> Get()
//        {
//            Livro v_Livro = new Livro();
//            
//            List<Livro> v_
//            
//            return new string[] { "value1", "value2" };
//        }

        // GET api/livros/5
        [HttpGet("{id}")]
        public IEnumerable<Livro> Get(int? id)
        {
            Livro v_Livro = new Livro();
            List<Livro> v_ListaLivros = new List<Livro>();

            //falta gerar a exceção
            return v_Livro.BuscarLivros(id);
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
