using getparking.Models.Content;
using getparking.Models.Entity;
using System.Linq;
using System.Web.Http;

namespace getparking.Controllers
{
    public class BairroController : ApiController
    {
        BancoContent db = new BancoContent();

        public IHttpActionResult GetBairroPorId(int id)
        {
            if (id <= 0)
                return BadRequest("O Código do teste deve ser maior que 0.");

            var bairro = db.Bairros.Find(id);

            if (bairro == null)
                return NotFound();

            return Ok(bairro);
        }

        public IHttpActionResult GetAllBairros()
        {
            var bairros = db.Bairros.ToList();

            return Ok(bairros);
        }
    }
}
