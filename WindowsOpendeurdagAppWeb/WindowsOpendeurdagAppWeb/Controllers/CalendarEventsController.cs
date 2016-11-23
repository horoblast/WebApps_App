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
    public class CalendarEventsController : ApiController
    {
        private WindowsOpendeurdagAppWebContext db = new WindowsOpendeurdagAppWebContext();

        // GET: api/CalendarEvents
        public IQueryable<CalendarEvent> GetCalendarEvents()
        {
            return db.CalendarEvents;
        }

        // GET: api/CalendarEvents/5
        [ResponseType(typeof(CalendarEvent))]
        public IHttpActionResult GetCalendarEvent(int id)
        {
            CalendarEvent calendarEvent = db.CalendarEvents.Find(id);
            if (calendarEvent == null)
            {
                return NotFound();
            }

            return Ok(calendarEvent);
        }

        // PUT: api/CalendarEvents/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCalendarEvent(int id, CalendarEvent calendarEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != calendarEvent.CalendarEventId)
            {
                return BadRequest();
            }

            db.Entry(calendarEvent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalendarEventExists(id))
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

        // POST: api/CalendarEvents
        [ResponseType(typeof(CalendarEvent))]
        public IHttpActionResult PostCalendarEvent(CalendarEvent calendarEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CalendarEvents.Add(calendarEvent);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = calendarEvent.CalendarEventId }, calendarEvent);
        }

        // DELETE: api/CalendarEvents/5
        [ResponseType(typeof(CalendarEvent))]
        public IHttpActionResult DeleteCalendarEvent(int id)
        {
            CalendarEvent calendarEvent = db.CalendarEvents.Find(id);
            if (calendarEvent == null)
            {
                return NotFound();
            }

            db.CalendarEvents.Remove(calendarEvent);
            db.SaveChanges();

            return Ok(calendarEvent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CalendarEventExists(int id)
        {
            return db.CalendarEvents.Count(e => e.CalendarEventId == id) > 0;
        }
    }
}