using getparking.Models.Content;
using getparking.Models.Entity;
using System.Linq;
using System.Web.Http;

namespace getparking.Controllers
{
    public class ReservaController : ApiController
    {
        BancoContent db = new BancoContent();

        public IHttpActionResult PostReserva(Reserva reserva)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Reservas.Add(reserva);
            db.SaveChanges();

            return CreatedAtRoute("Default", new { id = reserva.Id }, reserva);
        }

        public IHttpActionResult GetAllReservas()
        {
            var reservas = db.Reservas.ToList();

            return Ok(reservas);

        }

        public IHttpActionResult GetReservaById(int id)
        {
            if (id <= 0)
                return BadRequest("O ID da Reserva deve ser maior que 0.");

            var reserva = db.Reservas.Find(id);

            if (reserva == null)
                return NotFound();

            return Ok(reserva);
        }

        public IHttpActionResult GetReservaByIdUsuario(int IdUsuario)
        {
            if (IdUsuario <= 0)
                return BadRequest("O código do Usuário deve ser maior que 0.");

            var reserva = db.Reservas.Where(r => r.IdUsuarioFK.Equals(IdUsuario)).ToList();

            if (reserva == null)
                return NotFound();

            return Ok(reserva);
        }
    }
}
