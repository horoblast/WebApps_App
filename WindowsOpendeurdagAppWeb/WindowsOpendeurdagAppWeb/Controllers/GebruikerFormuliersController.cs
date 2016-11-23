using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WindowsOpendeurdagAppWeb.Models;

namespace WindowsOpendeurdagAppWeb.Controllers
{
    public class GebruikerFormuliersController : ApiController
    {
        private WindowsOpendeurdagAppWebContext db = new WindowsOpendeurdagAppWebContext();

        // GET: api/GebruikerFormuliers
        public IQueryable<GebruikerFormulier> GetGebruikerFormuliers()
        {
            return db.GebruikerFormuliers;
        }

        // GET: api/GebruikerFormuliers/5
        [ResponseType(typeof(GebruikerFormulier))]
        public IHttpActionResult GetGebruikerFormulier(int id)
        {
            GebruikerFormulier gebruikerFormulier = db.GebruikerFormuliers.Find(id);
            if (gebruikerFormulier == null)
            {
                return NotFound();
            }

            return Ok(gebruikerFormulier);
        }

        // PUT: api/GebruikerFormuliers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGebruikerFormulier(int id, GebruikerFormulier gebruikerFormulier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gebruikerFormulier.GebruikerFormulierId)
            {
                return BadRequest();
            }

            db.Entry(gebruikerFormulier).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GebruikerFormulierExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/GebruikerFormuliers
        [ResponseType(typeof(GebruikerFormulier))]
        public IHttpActionResult PostGebruikerFormulier(GebruikerFormulier gebruikerFormulier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GebruikerFormuliers.Add(gebruikerFormulier);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gebruikerFormulier.GebruikerFormulierId }, gebruikerFormulier);
        }

        // DELETE: api/GebruikerFormuliers/5
        [ResponseType(typeof(GebruikerFormulier))]
        public IHttpActionResult DeleteGebruikerFormulier(int id)
        {
            GebruikerFormulier gebruikerFormulier = db.GebruikerFormuliers.Find(id);
            if (gebruikerFormulier == null)
            {
                return NotFound();
            }

            db.GebruikerFormuliers.Remove(gebruikerFormulier);
            db.SaveChanges();

            return Ok(gebruikerFormulier);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GebruikerFormulierExists(int id)
        {
            return db.GebruikerFormuliers.Count(e => e.GebruikerFormulierId == id) > 0;
        }
    }
}