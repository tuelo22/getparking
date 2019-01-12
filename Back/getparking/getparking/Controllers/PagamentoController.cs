using getparking.Models.Content;
using getparking.Models.Entity;
using System.Linq;
using System.Web.Http;

namespace getparking.Controllers
{
    public class PagamentoController : ApiController
    {
        BancoContent db = new BancoContent();

        public IHttpActionResult PostPagamento(Pagamento pagamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Pagamentos.Add(pagamento);
            db.SaveChanges();

            return CreatedAtRoute("Default", new { id = pagamento.Id }, pagamento);
        }

        public IHttpActionResult GetAllPagamentos()
        {
            var pagamentos = db.Pagamentos.ToList();

            return Ok(pagamentos);
        }

        public IHttpActionResult GetPagamentoById(int id)
        {
            if (id <= 0)
                return BadRequest("O ID do Pagamento deve ser maior que 0.");

            var pagamento = db.Pagamentos.Find(id);

            if (pagamento == null)
                return NotFound();

            return Ok(pagamento);
        }

        public IHttpActionResult GetPagamentoByIdUsuario(int IdUsuario)
        {
            if (IdUsuario <= 0)
                return BadRequest("O código do Usuário deve ser maior que 0.");

            var pagamento = db.Pagamentos.Where(r => r.IdUsuarioFK.Equals(IdUsuario)).ToList();

            if (pagamento == null)
                return NotFound();

            return Ok(pagamento);
        }

    }
}
