using getparking.Models.Content;
using getparking.Models.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace getparking.Controllers
{
    public class TesteController : ApiController
    {
        BancoContent db = new BancoContent();

        public IHttpActionResult PostTest(Teste teste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Testes.Add(teste);
            db.SaveChanges();

            return CreatedAtRoute("Default", new { id = teste.Id }, teste);
         }

        public IHttpActionResult GetAllTest()
        {
            var testes = db.Testes;

            return Ok(testes);

        }
        public IHttpActionResult GetTestById(int id)
        {
            if (id <= 0)
                return BadRequest("O código do teste deve ser maior que 0.");

            var teste = db.Testes.Find(id);

            if(teste == null)
                return NotFound();

            return Ok(teste);
        }

        public IHttpActionResult PutTeste(int id, Teste teste)
        {
            if (!ModelState.IsValid)
               return BadRequest(ModelState);

            if (id != teste.Id)
               return BadRequest("O Id informado na URL é diferente do código do teste");

            if (db.Testes.Count(t => t.Id == teste.Id ) == 0)
                return NotFound();

            //db.Entry(teste).State = System.Data.Entity.EntityState.Modified;

            Teste testeOriginal = db.Testes.Find(id);
            db.Entry(testeOriginal).CurrentValues.SetValues(teste);

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeleteTeste(int id)
        {
            if (id <= 0)
                return BadRequest("O código do teste deve ser maior que 0.");

            Teste teste = db.Testes.Find(id);

            if (teste == null)
                return NotFound();

            db.Testes.Remove(teste);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
