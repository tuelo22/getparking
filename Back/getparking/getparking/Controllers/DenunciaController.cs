using getparking.Models.Content;
using getparking.Models.Entity;
using System.Linq;
using System.Web.Http;

namespace getparking.Controllers
{
    public class DenunciaController : ApiController
    {
        BancoContent db = new BancoContent();

        public IHttpActionResult PostDenuncia(Denuncia denuncia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Denuncias.Add(denuncia);
            db.SaveChanges();
            
            return CreatedAtRoute("Default", new { id = denuncia.Id }, denuncia);
        }

        public IHttpActionResult GetAllDenuncia()
        {
            var denuncia = db.Denuncias.ToList();

            return Ok(denuncia);
        }

        public IHttpActionResult GetDenunciaById(int id)
        {
            if (id <= 0)
                return BadRequest("O ID da denuncia deve ser maior que 0.");

            var denuncia = db.Denuncias.Find(id);

            if (denuncia == null)
                return NotFound();

            return Ok(denuncia);
        }

        public IHttpActionResult GetDenunciaByIdUsuario(int IdUsuario)
        {
            if (IdUsuario <= 0)
                return BadRequest("O código do Usuário deve ser maior que 0.");

            var denuncia = db.Denuncias.Where(r => r.IdRelatorFK.Equals(IdUsuario)).ToList();

            if (denuncia == null)
                return NotFound();

            return Ok(denuncia);
        }

    }
}
